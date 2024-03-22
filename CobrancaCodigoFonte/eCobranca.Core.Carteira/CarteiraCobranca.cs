using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Comando;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Patterns.Command;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Core.Provedor;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Carteira;

[Serializable]
public abstract class CarteiraCobranca : IObserver, IObservable, IParametrosAdicionaisDisponiveis, ISerializable
{
	[NonSerialized]
	protected ModeloBoleto modeloBoleto;

	protected ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca;

	protected ConfiguracaoBoleto configuracaoBoleto;

	protected ConfiguracaoArquivoRemessa configuracaoArquivoRemessa;

	protected ConfiguracaoArquivoRetorno configuracaoArquivoRetorno;

	protected ConfiguracaoDocumentoCobranca configuracaoDocumentoCobranca;

	protected ConfiguracaoImpressao configuracaoImpressao;

	protected ConfiguracaoEmail configuracaoEmail;

	[NonSerialized]
	protected Contrato contrato;

	[NonSerialized]
	protected ParametrosAdicionaisDisponiveis parametrosDisponiveis;

	protected EnumModoUsoECobranca modoUso;

	private Guid guid;

	[NonSerialized]
	protected IList<EnumTipoNotificacao> observableNotifyTypes;

	[NonSerialized]
	private bool modoEscritaCarteiraON;

	[NonSerialized]
	protected MacroCommand comandoGerarRemessaFebraban240;

	[NonSerialized]
	protected MacroCommand comandoGerarRemessaCnab400;

	[NonSerialized]
	protected MacroCommand comandoProcessarRetornoFebraban240;

	[NonSerialized]
	protected MacroCommand comandoProcessarRetornoCnab400;

	[NonSerialized]
	protected MacroCommand comandoProcessarRetornoFebraban150;

	[NonSerialized]
	protected ArquivoCobrancaRemessaFebraban240 remessaFebraban240;

	[NonSerialized]
	protected ArquivoCobrancaRemessaCnab400 remessaCnab400;

	[NonSerialized]
	protected ArquivoCobrancaRetornoFebraban240 retornoFebraban240;

	[NonSerialized]
	protected ArquivoCobrancaRetornoCnab400 retornoCnab400;

	[NonSerialized]
	protected ArquivoCobrancaRetornoFebraban150 retornoFebraban150;

	[NonSerialized]
	protected ComandoGerarPreviewBoleto comandoGerarPreviewBoleto;

	[NonSerialized]
	protected ComandoGerarBoletos comandoGerarBoletos;

	[NonSerialized]
	protected ProvedorDadosModeloBoleto provedorDadosBoleto;

	[NonSerialized]
	protected FactoryModeloBoleto factoryModeloBoleto;

	[NonSerialized]
	protected FactorySegmentoFebraban240 factorySegmentoFebraban240;

	protected string diretorioTemporarioImagens = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\Temp\\");

	public FactorySegmentoFebraban240 FactorySegmentoFebraban240 => factorySegmentoFebraban240;

	public FactoryModeloBoleto FactoryModeloBoleto => factoryModeloBoleto;

	public ProvedorDadosModeloBoleto ProvedorDadosBoleto => provedorDadosBoleto;

	public EnumModoUsoECobranca ModoUso => modoUso;

	public ParametrosAdicionaisDisponiveis ParametrosDisponiveis => parametrosDisponiveis;

	public ConfiguracaoArquivoRemessa ConfiguracaoArquivoRemessa => configuracaoArquivoRemessa;

	public ConfiguracaoBoleto ConfiguracaoBoleto => configuracaoBoleto;

	public ConfiguracaoCarteiraCobranca ConfiguracaoCarteiraCobranca => configuracaoCarteiraCobranca;

	public ConfiguracaoArquivoRetorno ConfiguracaoArquivoRetorno => configuracaoArquivoRetorno;

	public ConfiguracaoDocumentoCobranca ConfiguracaoDocumentoCobranca => configuracaoDocumentoCobranca;

	public ConfiguracaoImpressao ConfiguracaoImpressao => configuracaoImpressao;

	public ConfiguracaoEmail ConfiguracaoEmail => configuracaoEmail;

	public Contrato Contrato => contrato;

	public string UltimaMensagemErro { get; set; }

	public ArrayList DadosConfiguracao { get; set; }

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public CarteiraCobranca(Guid guid)
	{
		try
		{
			Logger.Debug("Criando classe base CarteiraCobranca...");
			this.guid = guid;
			observableNotifyTypes = new List<EnumTipoNotificacao>();
			observableNotifyTypes.Add(EnumTipoNotificacao.DADO_CONFIGURACAO_CARTEIRA_ALTERADO);
			observableNotifyTypes.Add(EnumTipoNotificacao.BLOQUEAR_ESCRITA_CARTEIRA_COBRANCA);
			observableNotifyTypes.Add(EnumTipoNotificacao.LIBERAR_ESCRITA_CARTEIRA_COBRANCA);
			observableNotifyTypes.Add(EnumTipoNotificacao.GET_NOME_ARQUIVO_REMESSA);
			NotifyEventInterceptor.GetInstance().AddObserver(this);
			factoryModeloBoleto = FactoryModeloBoleto.GetInstance();
			factorySegmentoFebraban240 = CarregarFabricaSegmentoFebraban240();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCriandoCarteiraCobranca(configuracaoCarteiraCobranca, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public CarteiraCobranca(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: this(configuracaoCarteiraCobranca.GetGuid())
	{
		try
		{
			this.configuracaoCarteiraCobranca = configuracaoCarteiraCobranca;
			if (string.IsNullOrEmpty(this.configuracaoCarteiraCobranca.ChaveLicenca))
			{
				modoUso = EnumModoUsoECobranca.DEMONSTRACAO;
			}
			else
			{
				modoUso = EnumModoUsoECobranca.COMERCIAL;
			}
			configuracaoDocumentoCobranca = CarregarConfiguracaoDocumentoCobranca();
			configuracaoBoleto = CarregarConfiguracaoBoleto();
			configuracaoArquivoRemessa = CarregarConfiguracaoArquivoRemessa();
			configuracaoArquivoRetorno = CarregarConfiguracaoArquivoRetorno();
			configuracaoImpressao = CarregarConfiguracaoImpressao();
			configuracaoEmail = CarregarConfiguracaoEmail();
			parametrosDisponiveis = CarregarParametrosDisponiveis();
			TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS, parametrosDisponiveis));
			remessaFebraban240 = CarregarArquivoRemessaFebraban240();
			remessaCnab400 = CarregarArquivoRemessaCnab400();
			retornoFebraban150 = CarregarArquivoRetornoFebraban150();
			retornoFebraban240 = CarregarArquivoRetornoFebraban240();
			retornoCnab400 = CarregarArquivoRetornoCnab400();
			comandoGerarRemessaFebraban240 = CarregarComandoGerarRemessaFebraban240();
			comandoGerarRemessaCnab400 = CarregarComandoGerarRemessaCnab400();
			comandoProcessarRetornoFebraban150 = CarregarComandoProcessarRetornoFebraban150();
			comandoProcessarRetornoFebraban240 = CarregarComandoProcessarRetornoFebraban240();
			comandoProcessarRetornoCnab400 = CarregarComandoProcessarRetornoCnab400();
			comandoGerarPreviewBoleto = new ComandoGerarPreviewBoleto();
			comandoGerarBoletos = new ComandoGerarBoletos();
			provedorDadosBoleto = CarregarProvedorDadosModeloBoleto();
			Init();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCriandoCarteiraCobranca(configuracaoCarteiraCobranca, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public CarteiraCobranca(SerializationInfo serobj, StreamingContext scontext)
	{
		modoUso = (EnumModoUsoECobranca)serobj.GetValue("ModoUso", typeof(EnumModoUsoECobranca));
		guid = (Guid)serobj.GetValue("Guid", typeof(Guid));
		configuracaoArquivoRemessa = (ConfiguracaoArquivoRemessa)serobj.GetValue("ConfiguracaoArquivoRemessa", typeof(ConfiguracaoArquivoRemessa));
		configuracaoArquivoRetorno = (ConfiguracaoArquivoRetorno)serobj.GetValue("ConfiguracaoArquivoRetorno", typeof(ConfiguracaoArquivoRetorno));
		configuracaoBoleto = (ConfiguracaoBoleto)serobj.GetValue("ConfiguracaoBoleto", typeof(ConfiguracaoBoleto));
		configuracaoCarteiraCobranca = (ConfiguracaoCarteiraCobranca)serobj.GetValue("ConfiguracaoCarteiraCobranca", typeof(ConfiguracaoCarteiraCobranca));
		configuracaoDocumentoCobranca = (ConfiguracaoDocumentoCobranca)serobj.GetValue("ConfiguracaoDocumentoCobranca", typeof(ConfiguracaoDocumentoCobranca));
		configuracaoImpressao = (ConfiguracaoImpressao)serobj.GetValue("ConfiguracaoImpressao", typeof(ConfiguracaoImpressao));
		configuracaoEmail = (ConfiguracaoEmail)serobj.GetValue("ConfiguracaoEmail", typeof(ConfiguracaoEmail));
		DadosConfiguracao = (ArrayList)serobj.GetValue("DadosConfiguracao", typeof(ArrayList));
		diretorioTemporarioImagens = (string)serobj.GetValue("DiretorioTemporarioImagens", typeof(string));
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.DADO_CONFIGURACAO_CARTEIRA_ALTERADO);
		observableNotifyTypes.Add(EnumTipoNotificacao.BLOQUEAR_ESCRITA_CARTEIRA_COBRANCA);
		observableNotifyTypes.Add(EnumTipoNotificacao.LIBERAR_ESCRITA_CARTEIRA_COBRANCA);
		observableNotifyTypes.Add(EnumTipoNotificacao.GET_NOME_ARQUIVO_REMESSA);
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_GUID);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
		RefreshNotifyEventHandler();
		CarregarRecursos();
	}

	private void CarregarRecursos()
	{
		factorySegmentoFebraban240 = CarregarFabricaSegmentoFebraban240();
		parametrosDisponiveis = CarregarParametrosDisponiveis();
		TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS, parametrosDisponiveis));
		remessaFebraban240 = CarregarArquivoRemessaFebraban240();
		remessaCnab400 = CarregarArquivoRemessaCnab400();
		retornoFebraban150 = CarregarArquivoRetornoFebraban150();
		retornoFebraban240 = CarregarArquivoRetornoFebraban240();
		retornoCnab400 = CarregarArquivoRetornoCnab400();
		comandoGerarRemessaFebraban240 = CarregarComandoGerarRemessaFebraban240();
		comandoGerarRemessaCnab400 = CarregarComandoGerarRemessaCnab400();
		comandoProcessarRetornoFebraban150 = CarregarComandoProcessarRetornoFebraban150();
		comandoProcessarRetornoFebraban240 = CarregarComandoProcessarRetornoFebraban240();
		comandoProcessarRetornoCnab400 = CarregarComandoProcessarRetornoCnab400();
		comandoGerarPreviewBoleto = new ComandoGerarPreviewBoleto();
		comandoGerarBoletos = new ComandoGerarBoletos();
		provedorDadosBoleto = CarregarProvedorDadosModeloBoleto();
	}

	public ArrayList CalcularDadosBoletos(ArrayList dcList)
	{
		try
		{
			if (configuracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				return dcList;
			}
			if (!PossuiDisponibilidadeSequencialParaNossoNumero(dcList.Count))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(GetFimSequenciaNossoNumero());
			}
			Logger.Debug("Calculando dados dos boletos...");
			foreach (DocumentoCobranca dc in dcList)
			{
				if (string.IsNullOrEmpty(dc.NossoNumero) && string.IsNullOrEmpty(dc.NossoNumeroSemMascara))
				{
					dc.NossoNumero = GerarNossoNumeroCompleto(dc);
				}
				else if (string.IsNullOrEmpty(dc.NossoNumero) && !string.IsNullOrEmpty(dc.NossoNumeroSemMascara))
				{
					dc.NossoNumero = AplicarMascaraNossoNumero(dc);
				}
				if (string.IsNullOrEmpty(dc.CodigoBarras))
				{
					dc.CodigoBarras = GerarCodigoBarras(dc);
				}
				if (string.IsNullOrEmpty(dc.LinhaDigitavel))
				{
					dc.LinhaDigitavel = GetLinhaDigitavel(dc);
				}
			}
			return dcList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return dcList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDadosBoleto(ex), new StackTrace().GetFrame(1).GetMethod());
			return dcList;
		}
	}

	public void GerarBoletos(ArrayList dcList)
	{
		try
		{
			comandoGerarBoletos.Preparar(this, dcList);
			comandoGerarBoletos.Execute();
			ExcluirDiretorioTemporario();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public IList<BoletoStream> GerarBoletos(ArrayList dcList, bool modoIndividual)
	{
		try
		{
			comandoGerarBoletos.Preparar(this, dcList, modoStream: true, modoIndividual);
			comandoGerarBoletos.Execute();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return comandoGerarBoletos.BoletosStream;
	}

	public void GetPreview()
	{
		try
		{
			comandoGerarPreviewBoleto.Preparar(this);
			comandoGerarPreviewBoleto.GetPreview();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoPreview(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string GerarArquivoRemessa(ArrayList dcList)
	{
		string result = string.Empty;
		try
		{
			Logger.Debug("Gerando arquivo de remessa com os documentos de cobrança...");
			if (ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				if (Enum.IsDefined(typeof(EnumLayoutArquivoRemessa), ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToUpper()))
				{
					switch ((EnumLayoutArquivoRemessa)Enum.Parse(typeof(EnumLayoutArquivoRemessa), ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToUpper()))
					{
					case EnumLayoutArquivoRemessa.FEBRABAN240:
						result = GerarArquivoRemessaFebraban240(dcList);
						break;
					case EnumLayoutArquivoRemessa.CNAB400:
						result = GerarArquivoRemessaCNAB400(dcList);
						break;
					case EnumLayoutArquivoRemessa.CBR641:
						result = GerarArquivoRemessaCNAB400(dcList);
						break;
					case EnumLayoutArquivoRemessa.FEBRABAN150:
						result = GerarArquivoRemessaFebraban150(dcList);
						break;
					}
				}
				return result;
			}
			throw ExcecaoECobranca.CarteiraCobranca.GeracaoArquivoRemessaNegadoCarteiraDeCobrancaSemRegistro();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Remessa.FalhaGerandoRemessa(ConfiguracaoArquivoRemessa.LayoutArquivoRemessa.ToUpper(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return result;
		}
	}

	public ArrayList CarregarArquivoRetorno(string nomeArquivoRetorno)
	{
		ArrayList result = new ArrayList();
		try
		{
			Logger.Debug("Carregando arquivo de retorno...");
			if (Enum.IsDefined(typeof(EnumLayoutArquivoRetorno), ConfiguracaoArquivoRetorno.LayoutArquivoRetorno.ToUpper()))
			{
				switch ((EnumLayoutArquivoRetorno)Enum.Parse(typeof(EnumLayoutArquivoRetorno), ConfiguracaoArquivoRetorno.LayoutArquivoRetorno.ToUpper()))
				{
				case EnumLayoutArquivoRetorno.FEBRABAN240:
					result = CarregarArquivoRetornoFebraban240(nomeArquivoRetorno);
					return result;
				case EnumLayoutArquivoRetorno.CNAB400:
					result = CarregarArquivoRetornoCnab400(nomeArquivoRetorno);
					return result;
				case EnumLayoutArquivoRetorno.CBR643:
					result = CarregarArquivoRetornoCnab400(nomeArquivoRetorno);
					return result;
				default:
					return result;
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Retorno.FalhaCarregandoArquivoRetorno(ConfiguracaoArquivoRetorno.LayoutArquivoRetorno.ToUpper(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public abstract string GetCodigoCarteiraImpressao();

	protected void Init()
	{
		try
		{
			Logger.Debug("Inicializando carteira de cobrança...");
			contrato = new Contrato();
			CarregarDadosConfiguracao();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaInicializandoCarteiraCobranca(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected abstract void CarregarDadosConfiguracao();

	protected abstract FactorySegmentoFebraban240 CarregarFabricaSegmentoFebraban240();

	protected abstract ConfiguracaoArquivoRemessa CarregarConfiguracaoArquivoRemessa();

	protected abstract ArquivoCobrancaRemessaFebraban240 CarregarArquivoRemessaFebraban240();

	protected abstract ArquivoCobrancaRemessaCnab400 CarregarArquivoRemessaCnab400();

	protected abstract MacroCommand CarregarComandoGerarRemessaFebraban240();

	protected abstract MacroCommand CarregarComandoGerarRemessaCnab400();

	protected abstract string GerarArquivoRemessaFebraban240(ArrayList dcList);

	protected abstract string GerarArquivoRemessaCNAB400(ArrayList dcList);

	protected abstract string GerarArquivoRemessaFebraban150(ArrayList dcList);

	protected abstract ConfiguracaoArquivoRetorno CarregarConfiguracaoArquivoRetorno();

	protected abstract ArquivoCobrancaRetornoFebraban240 CarregarArquivoRetornoFebraban240();

	protected abstract ArquivoCobrancaRetornoCnab400 CarregarArquivoRetornoCnab400();

	protected abstract ArquivoCobrancaRetornoFebraban150 CarregarArquivoRetornoFebraban150();

	protected abstract MacroCommand CarregarComandoProcessarRetornoFebraban240();

	protected abstract MacroCommand CarregarComandoProcessarRetornoCnab400();

	protected abstract MacroCommand CarregarComandoProcessarRetornoFebraban150();

	protected abstract ArrayList CarregarArquivoRetornoFebraban240(string nomeArquivoRetorno);

	protected abstract ArrayList CarregarArquivoRetornoCnab400(string nomeArquivoRetorno);

	protected abstract ArrayList CarregarArquivoRetornoFebraban150(string nomeArquivoRetorno);

	protected abstract ConfiguracaoBoleto CarregarConfiguracaoBoleto();

	protected abstract ConfiguracaoDocumentoCobranca CarregarConfiguracaoDocumentoCobranca();

	protected abstract ConfiguracaoImpressao CarregarConfiguracaoImpressao();

	protected abstract ConfiguracaoEmail CarregarConfiguracaoEmail();

	protected abstract ProvedorDadosModeloBoleto CarregarProvedorDadosModeloBoleto();

	protected virtual string GerarCodigoBarras(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug($"Criando código de barras para o documento de cobrança [{dc.NumeroDocumento}]");
			string text = GerarFatorVencimento(dc);
			string campoLivre = GetCampoLivre(dc);
			string text2 = "";
			text2 = ((!ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO)) ? StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10) : StringUtil.FormatValueToSizedString(1.0, 10));
			string codigoBarras = ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + "9" + text + text2 + campoLivre;
			string text3 = CalcularDVCodigoBarras(codigoBarras);
			result = ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + "9" + text3 + text + text2 + campoLivre;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCodigoBarrasDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected abstract string GetNossoNumeroSemDV(DocumentoCobranca dc);

	protected abstract string GetDVNossoNumero(string nossoNumero);

	protected virtual string CalcularDVCodigoBarras(string codigoBarras)
	{
		int num = -1;
		try
		{
			Logger.Debug($"Gerando DV para o código de barras [{codigoBarras}]");
			int num2 = 2;
			int num3 = 9;
			int num4 = 2;
			int num5 = 0;
			for (int num6 = codigoBarras.Length - 1; num6 >= 0; num6--)
			{
				int num7 = Convert.ToInt32(codigoBarras[num6].ToString());
				num5 += num7 * num2;
				num2 = ((num2 != num3) ? (num2 + 1) : num4);
			}
			int num8 = num5 % 11;
			int num9 = 11 - num8;
			num = ((num9 == 0 || num9 > 9) ? 1 : num9);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVCodigoBarrasDocumentoCobranca(codigoBarras, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}

	protected virtual string CalcularDVLinhaDigitavel(string campoLinhaDigitavel)
	{
		int num = -1;
		try
		{
			Logger.Debug("Calculando DV pelo Módulo10...");
			int num2 = 0;
			int num3 = 2;
			for (int num4 = campoLinhaDigitavel.Length - 1; num4 >= 0; num4--)
			{
				int num5 = Convert.ToInt32(campoLinhaDigitavel[num4].ToString()) * num3;
				while (num5 > 9)
				{
					int num6 = 0;
					for (int i = 0; i < Convert.ToString(num5).Length; i++)
					{
						num6 += Convert.ToInt32(Convert.ToString(num5)[i].ToString());
					}
					num5 = num6;
				}
				num2 += num5;
				num3 = ((num3 == 2) ? 1 : 2);
			}
			_ = num2 % 10;
			int j;
			for (j = num2; j % 10 > 0; j++)
			{
			}
			num = j - num2;
			if (num == 10)
			{
				num = 0;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculandoDVCampoLinhaDigitavel(campoLinhaDigitavel, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(num);
	}

	protected abstract string CalcularDVNossoNumero(string nossoNumeroSemDV);

	private ModeloBoleto GetInstanciaModeloBoleto(EnumTipoModeloBoleto tmb)
	{
		try
		{
			Logger.Debug($"Obtendo instância do modelo de boleto [{tmb.ToString()}]");
			foreach (ModeloBoleto item in ConfiguracaoBoleto.ModelosBoleto)
			{
				if (item.Tipo == tmb)
				{
					return item;
				}
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaObtendoModeloBoleto(tmb.ToString().ToUpper(), ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	protected virtual string GerarFatorVencimento(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug($"Gerando fator de vencimento para o documento [{dc.NumeroDocumento}]");
			DateTime dateTime = Convert.ToDateTime("07/10/1997");
			if (!dc.DataVencimento.HasValue)
			{
				throw ExcecaoECobranca.CarteiraCobranca.ImpossivelCalcularFatorVencimento(dc);
			}
			result = StringUtil.ZerosLeft(Convert.ToString((dc.DataVencimento.Value - dateTime).TotalDays), 4);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoFatorVencimento(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected abstract string GetCampoLivre(DocumentoCobranca dc);

	protected virtual string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Codigo() + "9" + dc.CodigoBarras.Substring(19, 5);
			string text2 = text + CalcularDVLinhaDigitavel(text);
			text2 = text2.Insert(5, ".");
			string text3 = dc.CodigoBarras.Substring(24, 10);
			string text4 = text3 + CalcularDVLinhaDigitavel(text3);
			text4 = text4.Insert(5, ".");
			string text5 = dc.CodigoBarras.Substring(34, 10);
			string text6 = text5 + CalcularDVLinhaDigitavel(text5);
			text6 = text6.Insert(5, ".");
			string text7 = dc.CodigoBarras.Substring(4, 1);
			string text8 = "";
			text8 = ((!ModoUso.Equals(EnumModoUsoECobranca.DEMONSTRACAO)) ? (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10)) : (GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(1.0, 10)));
			result = text2 + " " + text4 + " " + text6 + " " + text7 + " " + text8;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoLinhaDigitavel(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected virtual string GerarNossoNumeroCompleto(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug($"Obtendo nosso número completo para o documento [{dc.NumeroDocumento}]");
			string nossoNumeroSemDV = GetNossoNumeroSemDV(dc);
			string text = "";
			if (dc.CalculaDacNossoNumero)
			{
				text = GetDVNossoNumero(nossoNumeroSemDV);
			}
			if (text != "")
			{
				result = nossoNumeroSemDV + text;
				return result;
			}
			result = nossoNumeroSemDV;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroCompletoDocumentoCobranca(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected virtual string AplicarMascaraNossoNumero(DocumentoCobranca dc)
	{
		return StringUtil.AplicarMascara(dc.NossoNumeroSemMascara, GetMascaraNossoNumero());
	}

	protected abstract string GerarNomeArquivoRemessa();

	public abstract string GetMascaraNossoNumero();

	protected abstract string GetInicioSequenciaNossoNumero();

	protected abstract string GetFimSequenciaNossoNumero();

	protected abstract string GetSequenciaAtualNossoNumero();

	private void ExcluirDiretorioTemporario()
	{
		try
		{
			if (Directory.Exists(diretorioTemporarioImagens))
			{
				FileManager.LimparDiretorioESubPastas(diretorioTemporarioImagens);
				Directory.Delete(diretorioTemporarioImagens);
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaExcluindoArquivosTemporarios(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private bool PossuiDisponibilidadeSequencialParaNossoNumero(int quantidadeDocumentos)
	{
		if (string.IsNullOrEmpty(GetInicioSequenciaNossoNumero()) || string.IsNullOrEmpty(GetFimSequenciaNossoNumero()) || string.IsNullOrEmpty(GetSequenciaAtualNossoNumero()))
		{
			return false;
		}
		Convert.ToInt64(GetInicioSequenciaNossoNumero());
		long num = Convert.ToInt64(GetFimSequenciaNossoNumero());
		return Convert.ToInt64(GetSequenciaAtualNossoNumero()) + quantidadeDocumentos <= num;
	}

	public void Update(NotifyEvent ne)
	{
		switch (ne.Type)
		{
		case EnumTipoNotificacao.DADO_CONFIGURACAO_CARTEIRA_ALTERADO:
			if (modoEscritaCarteiraON)
			{
				Launcher.GetInstance().Executar(delegate
				{
					TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SALVAR_CARTEIRA_COBRANCA, this));
				});
			}
			break;
		case EnumTipoNotificacao.BLOQUEAR_ESCRITA_CARTEIRA_COBRANCA:
			modoEscritaCarteiraON = false;
			break;
		case EnumTipoNotificacao.LIBERAR_ESCRITA_CARTEIRA_COBRANCA:
			modoEscritaCarteiraON = true;
			break;
		case EnumTipoNotificacao.GET_NOME_ARQUIVO_REMESSA:
		{
			string nomeRemessa = GerarNomeArquivoRemessa();
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_NOME_ARQUIVO_REMESSA, nomeRemessa));
			});
			break;
		}
		}
	}

	public Guid GetGuid()
	{
		return guid;
	}

	public void TriggerNotifyEvent(object sender, NotifyEvent notifyEvent)
	{
		if (this.onNotifyEvent == null)
		{
			onNotifyEvent += NotifyEventInterceptor.GetInstance().OnNotifyEvent;
		}
		this.onNotifyEvent(sender, notifyEvent);
	}

	public void RefreshNotifyEventHandler()
	{
		this.onNotifyEvent = null;
		onNotifyEvent += NotifyEventInterceptor.GetInstance().OnNotifyEvent;
	}

	public abstract ParametrosAdicionaisDisponiveis CarregarParametrosDisponiveis();

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("ModoUso", modoUso);
		info.AddValue("Guid", guid);
		info.AddValue("ConfiguracaoArquivoRemessa", configuracaoArquivoRemessa);
		info.AddValue("ConfiguracaoArquivoRetorno", configuracaoArquivoRetorno);
		info.AddValue("ConfiguracaoBoleto", configuracaoBoleto);
		info.AddValue("ConfiguracaoCarteiraCobranca", configuracaoCarteiraCobranca);
		info.AddValue("ConfiguracaoDocumentoCobranca", configuracaoDocumentoCobranca);
		info.AddValue("ConfiguracaoImpressao", configuracaoImpressao);
		info.AddValue("ConfiguracaoEmail", configuracaoEmail);
		info.AddValue("DadosConfiguracao", DadosConfiguracao);
		info.AddValue("DiretorioTemporarioImagens", diretorioTemporarioImagens);
	}
}
