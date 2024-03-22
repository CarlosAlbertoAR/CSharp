using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Printing;
using System.Runtime.Serialization;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public class ConfiguracaoImpressao : ConfiguracaoECobranca
{
	public const string IMPRESSORA_PADRAO = "Impressora Padrão";

	private ArrayList impressorasDisponiveis;

	private ArrayList modosImpressao;

	private ArrayList modosSaida;

	private ArrayList formatosSaida;

	private string modoImpressao;

	private string modoSaida;

	private string formatoSaida;

	private string nomeImpressora;

	private string programaLeitorPdf;

	private bool impressaoAtiva;

	private bool impressoraValida;

	public bool ImpressoraValida
	{
		get
		{
			bool result = false;
			if (string.IsNullOrEmpty(NomeImpressora))
			{
				impressoraValida = false;
				Launcher.GetInstance().Executar(delegate
				{
					result = impressoraValida;
				});
			}
			else
			{
				if (NomeImpressora.Equals("Impressora Padrão"))
				{
					return true;
				}
				PrinterSettings printerSettings = new PrinterSettings();
				printerSettings.PrinterName = NomeImpressora;
				impressoraValida = printerSettings.IsValid;
				Launcher.GetInstance().Executar(delegate
				{
					result = impressoraValida;
				});
			}
			return result;
		}
	}

	public string NomeImpressora
	{
		get
		{
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.IMP_IMPRESSORA_PERSONALIZADA, carteira.ConfiguracaoImpressao.ParametrosDisponiveis.Impressao.ImpressoraPersonalizada(), carteira.ConfiguracaoImpressao.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional))
			{
				if (!nomeImpressora.Equals(valorParametroAdicional) && new PrinterSettings
				{
					PrinterName = valorParametroAdicional
				}.IsValid)
				{
					nomeImpressora = valorParametroAdicional;
				}
			}
			else
			{
				nomeImpressora = "Impressora Padrão";
			}
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = nomeImpressora;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (value.Equals("Impressora Padrão"))
				{
					Launcher.GetInstance().Executar(delegate
					{
						nomeImpressora = value;
					});
				}
				else if (new PrinterSettings
				{
					PrinterName = value
				}.IsValid)
				{
					Launcher.GetInstance().Executar(delegate
					{
						nomeImpressora = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ImpressoraSelecionadaInvalidaOuIndisponivel(value), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("NomeImpressora", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public bool ImpressaoAtiva
	{
		get
		{
			bool result = false;
			Launcher.GetInstance().Executar(delegate
			{
				result = impressaoAtiva;
			});
			return result;
		}
		set
		{
			if (bool.TryParse(value.ToString(), out var _))
			{
				Launcher.GetInstance().Executar(delegate
				{
					impressaoAtiva = value;
				});
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ImpressaoAtiva", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ModoImpressao
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = modoImpressao;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumModoImpressao), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						modoImpressao = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ModoImpressao", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ModoImpressao", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string ModoSaida
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = modoSaida;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumModoSaida), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						modoSaida = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ModoSaida", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ModoSaida", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string FormatoSaida
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = formatoSaida;
			});
			return result;
		}
		set
		{
			if (value != null)
			{
				if (Enum.IsDefined(typeof(EnumFormatoSaida), value.ToString().ToUpper()))
				{
					Launcher.GetInstance().Executar(delegate
					{
						formatoSaida = value;
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("FormatoSaida", new ArgumentOutOfRangeException()), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("FormatoSaida", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public ArrayList ImpressorasDisponiveis
	{
		get
		{
			ArrayList result = new ArrayList();
			try
			{
				impressorasDisponiveis = new ArrayList();
				impressorasDisponiveis.Add("Impressora Padrão");
			}
			catch (Exception ex)
			{
				if (ex is ExcecaoECobranca)
				{
					Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaObtendoListaDeImpressorasInstaladas(ex), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			Launcher.GetInstance().Executar(delegate
			{
				result = impressorasDisponiveis;
			});
			return result;
		}
	}

	public ArrayList ModosSaida
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = modosSaida;
			});
			return result;
		}
	}

	public ArrayList ModosImpressao
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = modosImpressao;
			});
			return result;
		}
	}

	public ArrayList FormatosSaida
	{
		get
		{
			return formatosSaida;
		}
		set
		{
			formatosSaida = value;
		}
	}

	[Obsolete("Propriedade depreciada pois não existe mais a necessidade de informar o programa leitor de pdf.")]
	public string ProgramaLeitorPdf
	{
		get
		{
			return programaLeitorPdf;
		}
		set
		{
			programaLeitorPdf = value;
		}
	}

	public ConfiguracaoImpressao(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
		: base(guid, banco, modoUso, carteira)
	{
		try
		{
			Logger.Debug("Criando configuração de impressão de documentos de cobrança...");
			RepositorioCodigosCobranca repositorio = FactoryRepositorioCodigosCobranca.GetInstance().GetRepositorio((EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>());
			CarregarListas(repositorio);
			modoImpressao = "";
			nomeImpressora = "";
			impressaoAtiva = false;
			formatoSaida = EnumFormatoSaida.PDF.ToString();
			modoSaida = EnumModoSaida.SAIDA_INDIVIDUAL.ToString();
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

	public ConfiguracaoImpressao(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
		modoImpressao = (string)serobj.GetValue("ModoImpressao", typeof(string));
		modoSaida = (string)serobj.GetValue("ModoSaida", typeof(string));
		formatoSaida = (string)serobj.GetValue("FormatoSaida", typeof(string));
		nomeImpressora = (string)serobj.GetValue("NomeImpressora", typeof(string));
		programaLeitorPdf = (string)serobj.GetValue("ProgramaLeitorPdf", typeof(string));
		modosImpressao = (ArrayList)serobj.GetValue("ModosImpressao", typeof(ArrayList));
		formatosSaida = (ArrayList)serobj.GetValue("FormatosSaida", typeof(ArrayList));
		modosSaida = (ArrayList)serobj.GetValue("ModosSaida", typeof(ArrayList));
		impressaoAtiva = (bool)serobj.GetValue("ImpressaoAtiva", typeof(bool));
	}

	public string GetImpressoraPadraoDoUsuario()
	{
		string text = "";
		using LocalPrintServer localPrintServer = new LocalPrintServer();
		return localPrintServer.DefaultPrintQueue.FullName;
	}

	public string GetExtensaoArquivoSaida()
	{
		switch ((EnumFormatoSaida)(object)FormatoSaida.ToEnum<EnumFormatoSaida>())
		{
		case EnumFormatoSaida.PDF:
		case EnumFormatoSaida.HTML:
			return ".pdf";
		case EnumFormatoSaida.IMAGEM:
			return ".tif";
		case EnumFormatoSaida.IMAGEM_ROTACIONADA:
			return ".png";
		default:
			return ".pdf";
		}
	}

	public override void CarregarListas(RepositorioCodigosCobranca repositorio)
	{
		modosImpressao = repositorio.ModosImpressao;
		formatosSaida = repositorio.FormatosSaida;
		modosSaida = repositorio.ModosSaida;
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("ModoImpressao", modoImpressao);
		info.AddValue("ModoSaida", modoSaida);
		info.AddValue("FormatoSaida", formatoSaida);
		info.AddValue("NomeImpressora", nomeImpressora);
		info.AddValue("ProgramaLeitorPdf", programaLeitorPdf);
		info.AddValue("ModosImpressao", modosImpressao);
		info.AddValue("FormatosSaida", formatosSaida);
		info.AddValue("ModosSaida", modosSaida);
		info.AddValue("ImpressaoAtiva", impressaoAtiva);
	}
}
