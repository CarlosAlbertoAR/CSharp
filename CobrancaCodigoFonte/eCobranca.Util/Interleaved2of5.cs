using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Util;

public class Interleaved2of5 : AbstractBarCode2D
{
	private static readonly string START_PATTERN = "NNNN";

	private static readonly string STOP_PATTERN = "WNN";

	private static readonly string BLACK_N = "a.bmp";

	private static readonly string WHITE_N = "b.bmp";

	private static readonly string BLACK_W = "c.bmp";

	private static readonly string WHITE_W = "d.bmp";

	private const string NAMESPACE_IMAGENS = "eCobranca/Core/Modelo/Imagens/";

	private static readonly string[] I25PATTERN = new string[10] { "NNWWN", "WNNNW", "NWNNW", "WWNNN", "NNWNW", "WNWNN", "NWWNN", "NNNWW", "WNNWN", "NWNWN" };

	private ConfiguracaoBoleto configuracaoBoleto;

	private bool autoQuietZones;

	private bool autoStartStopMarks;

	private List<Bitmap> imagensCodigoBarras;

	private ImageUtil imageUtil;

	private ParameterUtil parameterUtil;

	private string diretorioTemporarioImagens = AppDomain.CurrentDomain.BaseDirectory + "\\Temp\\";

	public bool AutoQuietZones
	{
		get
		{
			return autoQuietZones;
		}
		set
		{
			autoQuietZones = value;
		}
	}

	public bool AutoStartStopMarks
	{
		get
		{
			return autoStartStopMarks;
		}
		set
		{
			autoStartStopMarks = value;
		}
	}

	public Interleaved2of5()
	{
		imageUtil = ImageUtil.GetInstance();
		parameterUtil = ParameterUtil.GetInstance();
	}

	public Interleaved2of5(ConfiguracaoBoleto configuracaoBoleto)
		: this()
	{
		try
		{
			Logger.Debug("Criando instância Interleaved2of5...");
			autoQuietZones = true;
			autoStartStopMarks = true;
			this.configuracaoBoleto = configuracaoBoleto;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public Interleaved2of5(bool autoQuietZones, bool autoStartStopMarks, ConfiguracaoBoleto configuracaoBoleto)
		: this(configuracaoBoleto)
	{
		try
		{
			this.autoQuietZones = autoQuietZones;
			this.autoStartStopMarks = autoStartStopMarks;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(ConfiguracaoBoleto configuracaoBoleto, bool autoQuietZones, bool autoStartStopMarks)
	{
		this.autoQuietZones = autoQuietZones;
		this.autoStartStopMarks = autoStartStopMarks;
		this.autoStartStopMarks = autoStartStopMarks;
		this.configuracaoBoleto = configuracaoBoleto;
	}

	public override string EncodeValue(string value)
	{
		try
		{
			Logger.Debug($"Codificando valor [{value}]");
			string text = "";
			if (value.Length == 0 || value.Length % 2 != 0 || configuracaoBoleto.DiretorioImagens == "")
			{
				return "";
			}
			char[] array = value.ToCharArray();
			if (AutoQuietZones)
			{
				text += "!";
			}
			if (AutoStartStopMarks)
			{
				text += START_PATTERN;
			}
			for (int i = 0; i < value.Length; i += 2)
			{
				if (!char.IsDigit(array[i]) || !char.IsDigit(array[i + 1]))
				{
					return "";
				}
				string text2 = I25PATTERN[array[i] - 48];
				string text3 = I25PATTERN[array[i + 1] - 48];
				for (int j = 0; j <= 4; j++)
				{
					text += text2.Substring(j, 1);
					text += text3.Substring(j, 1);
				}
			}
			if (AutoStartStopMarks)
			{
				text += STOP_PATTERN;
			}
			if (AutoQuietZones)
			{
				text += "!";
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaCodificandoCodigoBarras(value, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public override string GetRenderedHtmlString(string encodedValue, bool modoFastReports)
	{
		imagensCodigoBarras = new List<Bitmap>();
		Bitmap bitmap = null;
		Bitmap bitmap2 = null;
		Bitmap bitmap3 = null;
		Bitmap bitmap4 = null;
		try
		{
			Logger.Debug($"Gerando string html com as imagens que compõem o código de barras...");
			string text = "";
			imagensCodigoBarras = new List<Bitmap>();
			bitmap = new Bitmap(1, 50);
			bitmap2 = new Bitmap(3, 50);
			bitmap3 = new Bitmap(1, 50);
			bitmap4 = new Bitmap(3, 50);
			bitmap.SetResolution(300f, 300f);
			bitmap2.SetResolution(300f, 300f);
			bitmap3.SetResolution(300f, 300f);
			bitmap4.SetResolution(300f, 300f);
			ColorBitmap(bitmap, Color.White);
			ColorBitmap(bitmap2, Color.White);
			ColorBitmap(bitmap3, Color.Black);
			ColorBitmap(bitmap4, Color.Black);
			if (encodedValue.Length == 0)
			{
				return "";
			}
			bool flag = false;
			int num = Convert.ToInt32(parameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_LARGURA_CODIGO_BARRAS, configuracaoBoleto.ParametrosDisponiveis.Boleto.LarguraCodigoBarras(), configuracaoBoleto.ParametrosAdicionais)) * 860 / 170;
			int num2 = Convert.ToInt32(parameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_ALTURA_CODIGO_BARRAS, configuracaoBoleto.ParametrosDisponiveis.Boleto.AlturaCodigoBarras(), configuracaoBoleto.ParametrosAdicionais)) * 50 / 10;
			for (int i = 0; i < encodedValue.Length; i++)
			{
				switch (encodedValue.Substring(i, 1))
				{
				case "!":
					num += 20;
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					imagensCodigoBarras.Add(bitmap);
					break;
				case "N":
					if (flag)
					{
						imagensCodigoBarras.Add(bitmap3);
					}
					else
					{
						imagensCodigoBarras.Add(bitmap);
					}
					break;
				case "W":
					if (flag)
					{
						imagensCodigoBarras.Add(bitmap4);
					}
					else
					{
						imagensCodigoBarras.Add(bitmap2);
					}
					break;
				}
				flag = !flag;
			}
			if (modoFastReports)
			{
				return imageUtil.MergeImages(imagensCodigoBarras, diretorioTemporarioImagens, "codigoBarrasCompleto", EnumOrientacaoConcatenacao.HORIZONTAL, EnumFormatoImagem.TIF);
			}
			return string.Format("<img src=\"{0}\" width={1} height={2} />", imageUtil.MergeImages(imagensCodigoBarras, diretorioTemporarioImagens, "codigoBarrasCompleto", EnumOrientacaoConcatenacao.HORIZONTAL), num + 20, num2);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoRepresentacaoHtmlCodigoBarras(encodedValue, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		finally
		{
			bitmap?.Dispose();
			bitmap2?.Dispose();
			bitmap3?.Dispose();
			bitmap4?.Dispose();
		}
		return null;
	}

	private void ColorBitmap(Bitmap bmp, Color color)
	{
		using Graphics graphics = Graphics.FromImage(bmp);
		using SolidBrush brush = new SolidBrush(color);
		graphics.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
	}
}
