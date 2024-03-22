using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Modelo;
using eCobranca.Enumerator;
using FastReport;
using FastReport.Export;
using FastReport.Export.Image;
using FastReport.Export.Pdf;

namespace eCobranca.Util;

public static class FastReportsUtil
{
	private static readonly string TAG_FIM_DATABASE = "</Dataset>";

	private static readonly string EXTENSAO_PDF = ".pdf";

	private static readonly string EXTENSAO_PNG = ".png";

	private static readonly string EXTENSAO_TIF = ".tif";

	public static MemoryStream SalvarBoleto(CarteiraCobranca carteira, ModeloBoleto modelo, ArrayList dadosBoleto, string nomeArquivo, EnumFormatoSaida formato = EnumFormatoSaida.PDF)
	{
		switch (formato)
		{
		case EnumFormatoSaida.PDF:
		{
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_SENHA_BLOQUEIO_BOLETOS, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ModeloBoletoSecundario(), carteira.ConfiguracaoBoleto.ParametrosAdicionais);
			bool flag = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_ENVELOPAR_IMAGEM_DE_BOLETO_EM_ARQUIVO_PDF, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ModeloBoletoSecundario(), carteira.ConfiguracaoBoleto.ParametrosAdicionais).Equals("S");
			bool comprimirPDF = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_COMPRIMIR_PDF, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ComprimirPDF(), carteira.ConfiguracaoBoleto.ParametrosAdicionais).Equals("S");
			if (!string.IsNullOrEmpty(valorParametroAdicional))
			{
				return SalvarBoletoComoPdf(modelo, dadosBoleto, nomeArquivo, valorParametroAdicional, comprimirPDF);
			}
			if (flag)
			{
				return SalvarBoletoComoPdfNaoEditavel(modelo, dadosBoleto, nomeArquivo);
			}
			return SalvarBoletoComoPdf(modelo, dadosBoleto, nomeArquivo, string.Empty, comprimirPDF);
		}
		case EnumFormatoSaida.IMAGEM:
			return SalvarBoletoComoImagem(modelo, dadosBoleto, nomeArquivo);
		case EnumFormatoSaida.IMAGEM_ROTACIONADA:
			return SalvarBoletoNoFormatoPngRotacionado(modelo, dadosBoleto, nomeArquivo);
		default:
			return SalvarBoletoComoPdfNaoEditavel(modelo, dadosBoleto, nomeArquivo);
		}
	}

	private static MemoryStream SalvarBoletoComoPdf(ModeloBoleto modelo, ArrayList dadosBoleto, string nomeArquivo, string senha, bool comprimirPDF)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		MemoryStream result = new MemoryStream();
		try
		{
			if (!nomeArquivo.Contains(EXTENSAO_PDF))
			{
				nomeArquivo += EXTENSAO_PDF;
			}
			if (!dadosBoleto.Contains(TAG_FIM_DATABASE))
			{
				dadosBoleto.Add(TAG_FIM_DATABASE);
			}
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivo));
			if (File.Exists(nomeArquivo))
			{
				File.Delete(nomeArquivo);
			}
			if (modelo != null)
			{
				Report val = new Report();
				try
				{
					val.Load((Stream)new MemoryStream(modelo.ModeloBoletoFastReports));
					DataSet dataSet = new DataSet();
					if (dadosBoleto != null)
					{
						if (dadosBoleto.Count > 0)
						{
							string s = string.Join("", dadosBoleto.ToArray(typeof(string)) as string[]);
							MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
							memoryStream.Position = 0L;
							dataSet.ReadXml(memoryStream);
							val.RegisterData(dataSet);
							if (((Base)val).get_Report().Prepare())
							{
								PDFExport val2 = new PDFExport();
								((ExportBase)val2).set_ShowProgress(false);
								val2.set_Compressed(comprimirPDF);
								val2.set_AllowPrint(true);
								val2.set_EmbeddingFonts(true);
								val2.set_AllowModify(false);
								val2.set_ImageLossless(false);
								val2.set_PrintOptimized(false);
								val2.set_JpegQuality(100);
								if (!string.IsNullOrEmpty(senha))
								{
									val2.set_UserPassword(senha);
								}
								MemoryStream memoryStream2 = new MemoryStream();
								((Base)val).get_Report().Export((ExportBase)(object)val2, (Stream)memoryStream2);
								((Component)(object)val).Dispose();
								((Component)(object)val2).Dispose();
								memoryStream2.Position = 0L;
								using FileStream fileStream = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write);
								memoryStream2.WriteTo(fileStream);
								fileStream.Close();
								result = memoryStream2;
								return result;
							}
							return result;
						}
						return result;
					}
					return result;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSalvandoBoletoFastReportNoFormatoPdf(nomeArquivo, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static MemoryStream SalvarBoletoNoFormatoPngRotacionado(ModeloBoleto modelo, ArrayList dadosBoleto, string nomeArquivo)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		MemoryStream result = new MemoryStream();
		try
		{
			if (!nomeArquivo.Contains(EXTENSAO_PNG))
			{
				nomeArquivo += EXTENSAO_PNG;
			}
			if (!dadosBoleto.Contains(TAG_FIM_DATABASE))
			{
				dadosBoleto.Add(TAG_FIM_DATABASE);
			}
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivo));
			if (File.Exists(nomeArquivo))
			{
				File.Delete(nomeArquivo);
			}
			if (modelo != null)
			{
				Report val = new Report();
				try
				{
					val.Load((Stream)new MemoryStream(modelo.ModeloBoletoFastReports));
					DataSet dataSet = new DataSet();
					if (dadosBoleto != null)
					{
						if (dadosBoleto.Count > 0)
						{
							string s = string.Join("", dadosBoleto.ToArray(typeof(string)) as string[]);
							MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
							memoryStream.Position = 0L;
							dataSet.ReadXml(memoryStream);
							val.RegisterData(dataSet);
							if (((Base)val).get_Report().Prepare())
							{
								ImageExport val2 = new ImageExport();
								((ExportBase)val2).set_ShowProgress(false);
								val2.set_ImageFormat((ImageExportFormat)1);
								val2.set_Resolution(190);
								MemoryStream memoryStream2 = new MemoryStream();
								MemoryStream memoryStream3 = new MemoryStream();
								((Base)val).get_Report().Export((ExportBase)(object)val2, (Stream)memoryStream2);
								((Component)(object)val).Dispose();
								((Component)(object)val2).Dispose();
								ImageUtil.GetInstance().RotateImage(memoryStream2, 90f).Save(memoryStream3, ImageFormat.Png);
								memoryStream2.Position = 0L;
								memoryStream3.Position = 0L;
								using FileStream fileStream = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write);
								memoryStream3.WriteTo(fileStream);
								fileStream.Close();
								result = memoryStream3;
								return result;
							}
							return result;
						}
						return result;
					}
					return result;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSalvandoBoletoFastReportNoFormatoImage(nomeArquivo, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static MemoryStream SalvarBoletoComoPdfNaoEditavel(ModeloBoleto modelo, ArrayList dadosBoleto, string nomeArquivo)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		MemoryStream result = new MemoryStream();
		try
		{
			if (!nomeArquivo.Contains(EXTENSAO_PDF))
			{
				nomeArquivo += EXTENSAO_PDF;
			}
			if (!dadosBoleto.Contains(TAG_FIM_DATABASE))
			{
				dadosBoleto.Add(TAG_FIM_DATABASE);
			}
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivo));
			if (File.Exists(nomeArquivo))
			{
				File.Delete(nomeArquivo);
			}
			if (modelo != null)
			{
				Report val = new Report();
				try
				{
					val.Load((Stream)new MemoryStream(modelo.ModeloBoletoFastReports));
					DataSet dataSet = new DataSet();
					if (dadosBoleto != null)
					{
						if (dadosBoleto.Count > 0)
						{
							string s = string.Join("", dadosBoleto.ToArray(typeof(string)) as string[]);
							MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
							new MemoryStream();
							MemoryStream memoryStream2 = new MemoryStream();
							memoryStream.Position = 0L;
							dataSet.ReadXml(memoryStream);
							val.RegisterData(dataSet);
							if (((Base)val).get_Report().Prepare())
							{
								ImageExport val2 = new ImageExport();
								((ExportBase)val2).set_ShowProgress(false);
								val2.set_ImageFormat((ImageExportFormat)2);
								val2.set_JpegQuality(100);
								val2.set_Resolution(190);
								string path = "boletoTemp" + Guid.NewGuid().ToString() + ".jpg";
								path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
								((Base)val).get_Report().Export((ExportBase)(object)val2, path);
								List<FileInfo> arquivos = new DirectoryInfo(Path.GetDirectoryName(path)).GetFiles("*" + Path.GetFileNameWithoutExtension(path) + "*.jpg").ToList();
								memoryStream2 = PdfUtil.GetInstance().ImageToPdf(arquivos);
								using FileStream destination = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write, FileShare.None);
								memoryStream2.Position = 0L;
								memoryStream2.CopyTo(destination);
								result = memoryStream2;
								return result;
							}
							return result;
						}
						return result;
					}
					return result;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSalvandoBoletoFastReportNoFormatoImage(nomeArquivo, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	private static MemoryStream SalvarBoletoComoImagem(ModeloBoleto modelo, ArrayList dadosBoleto, string nomeArquivo)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		MemoryStream result = new MemoryStream();
		try
		{
			if (!nomeArquivo.Contains(EXTENSAO_TIF))
			{
				nomeArquivo += EXTENSAO_TIF;
			}
			if (!dadosBoleto.Contains(TAG_FIM_DATABASE))
			{
				dadosBoleto.Add(TAG_FIM_DATABASE);
			}
			Directory.CreateDirectory(Path.GetDirectoryName(nomeArquivo));
			if (File.Exists(nomeArquivo))
			{
				File.Delete(nomeArquivo);
			}
			if (modelo != null)
			{
				Report val = new Report();
				try
				{
					val.Load((Stream)new MemoryStream(modelo.ModeloBoletoFastReports));
					DataSet dataSet = new DataSet();
					if (dadosBoleto != null)
					{
						if (dadosBoleto.Count > 0)
						{
							string s = string.Join("", dadosBoleto.ToArray(typeof(string)) as string[]);
							MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
							memoryStream.Position = 0L;
							dataSet.ReadXml(memoryStream);
							val.RegisterData(dataSet);
							if (((Base)val).get_Report().Prepare())
							{
								ImageExport val2 = new ImageExport();
								((ExportBase)val2).set_ShowProgress(false);
								val2.set_ImageFormat((ImageExportFormat)4);
								val2.set_Resolution(190);
								string path = "boletoTemp" + Guid.NewGuid().ToString() + ".jpg";
								path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
								((Base)val).get_Report().Export((ExportBase)(object)val2, path);
								List<FileInfo> list = new DirectoryInfo(Path.GetDirectoryName(path)).GetFiles("*" + Path.GetFileNameWithoutExtension(path) + "*.jpg").ToList();
								List<Bitmap> imagens = new List<Bitmap>();
								list.ForEach(delegate(FileInfo x)
								{
									imagens.Add(new Bitmap(x.FullName));
								});
								path = ImageUtil.GetInstance().MergeImages(imagens, AppDomain.CurrentDomain.BaseDirectory, "BoletoTempMerged", EnumOrientacaoConcatenacao.VERTICAL);
								FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
								MemoryStream memoryStream2 = new MemoryStream();
								fileStream.CopyTo(memoryStream2);
								memoryStream2.Position = 0L;
								using FileStream fileStream2 = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write);
								memoryStream2.WriteTo(fileStream2);
								fileStream2.Close();
								result = memoryStream2;
								return result;
							}
							return result;
						}
						return result;
					}
					return result;
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaSalvandoBoletoFastReportNoFormatoImage(nomeArquivo, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
