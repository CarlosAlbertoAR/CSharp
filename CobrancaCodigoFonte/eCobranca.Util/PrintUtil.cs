using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Modelo;
using eCobranca.Enumerator;
using FastReport;
using FastReport.Utils;

namespace eCobranca.Util;

public static class PrintUtil
{
	[DllImport("shell32.dll")]
	public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, EnumShowCommand nShowCmd);

	public static void ImprimirDocumento(string nomeAbsolutoArquivo, ConfiguracaoImpressao configuracaoImpressao)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = nomeAbsolutoArquivo,
			Verb = "Print",
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Normal
		}).WaitForExit();
	}

	public static bool ImprimirDocumentoFastReport(ModeloBoleto modelo, ArrayList dadosImpressao, ConfiguracaoImpressao configuracaoImpressao)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		bool result = true;
		try
		{
			if (modelo != null)
			{
				Report val = new Report();
				try
				{
					val.Load((Stream)new MemoryStream(modelo.ModeloBoletoFastReports));
					val.set_FileName("eCobrançaBoletos.pdf");
					DataSet dataSet = new DataSet();
					if (dadosImpressao != null)
					{
						if (dadosImpressao.Count > 0)
						{
							string s = string.Join("", dadosImpressao.ToArray(typeof(string)) as string[]);
							MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
							memoryStream.Position = 0L;
							dataSet.ReadXml(memoryStream);
							val.RegisterData(dataSet);
							if (((Base)val).get_Report().Prepare())
							{
								if (configuracaoImpressao.NomeImpressora.Equals("Impressora Padrão"))
								{
									val.get_PrintSettings().set_Printer(configuracaoImpressao.GetImpressoraPadraoDoUsuario());
								}
								else
								{
									val.get_PrintSettings().set_Printer(configuracaoImpressao.NomeImpressora);
								}
								val.get_PrintSettings().set_ShowDialog(false);
								Config.get_ReportSettings().set_ShowProgress(false);
								val.Print();
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
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaImprimindoDocumentoViaFastReport(ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return false;
		}
	}
}
