using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using eCobranca.Core;
using eCobranca.Core.Carteira;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Dao;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Modelo;
using eCobranca.Core.Parametros;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;
using eCobranca.Properties;
using eCobranca.Util;
using FastReport;
using log4net.Config;

namespace eCobranca;

[Serializable]
[Guid("993D8FF0-A710-42da-8027-0DF08ECE68EA")]
[ClassInterface(ClassInterfaceType.AutoDual)]
[ProgId("eCobranca.ControleCobranca")]
[ComVisible(true)]
public class ControleCobranca : IObservable, IObserver
{
	private CarteiraCobranca carteira;

	private string arquivoCarteiraCobranca;

	private string chaveCarteira;

	private string ultimaMensagemErro;

	private string ultimoErroInterno;

	private ArrayList documentosCobranca;

	private Guid guid;

	private DAOCarteiraCobranca daoCarteira;

	private IList<EnumTipoNotificacao> observableNotifyTypes;

	private string versao;

	private bool liberado;

	private bool habilitaEnvioExcecoes;

	public bool HabilitaEnvioExcecoes
	{
		get
		{
			return habilitaEnvioExcecoes;
		}
		set
		{
			habilitaEnvioExcecoes = value;
			Launcher.GetInstance().ThrowExceptions = habilitaEnvioExcecoes;
		}
	}

	public string ArquivoCarteiraCobranca
	{
		get
		{
			string result = null;
			Launcher.GetInstance().Executar(delegate
			{
				result = arquivoCarteiraCobranca;
			});
			return result;
		}
		set
		{
			try
			{
				Logger.Info("Carregando carteira de cobrança...");
				if (!string.IsNullOrEmpty(value))
				{
					if (!File.Exists(value))
					{
						Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ArquivoCarteiraCobrancaNaoExiste(), new StackTrace().GetFrame(1).GetMethod());
					}
					string conteudoArquivoCarteira = FileManager.ReadStringFromFile(value);
					if (conteudoArquivoCarteira.Length < 5000)
					{
						Launcher.GetInstance().Executar(delegate
						{
							ChaveCarteira = conteudoArquivoCarteira;
						});
						return;
					}
					Launcher.GetInstance().Executar(delegate
					{
						arquivoCarteiraCobranca = value;
					});
					Logger.Debug("Disparando evento para carregar carteira de cobrança...");
					Launcher.GetInstance().Executar(delegate
					{
						TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARREGAR_CARTEIRA_COBRANCA, ArquivoCarteiraCobranca));
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ArquivoCarteiraCobrancaNuloOuVazio(), new StackTrace().GetFrame(1).GetMethod());
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
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ArquivoCarteiraCobranca", ex), new StackTrace().GetFrame(1).GetMethod());
				}
			}
		}
	}

	public string ChaveCarteira
	{
		get
		{
			string result = null;
			Launcher.GetInstance().Executar(delegate
			{
				result = chaveCarteira;
			});
			return result;
		}
		set
		{
			try
			{
				Logger.Info("Carregando carteira de cobrança...");
				if (!string.IsNullOrEmpty(value))
				{
					Launcher.GetInstance().Executar(delegate
					{
						chaveCarteira = value;
					});
					Logger.Debug("Disparando evento para carregar carteira de cobrança...");
					Launcher.GetInstance().Executar(delegate
					{
						TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.INSTANCIAR_CARTEIRA_COBRANCA, chaveCarteira));
					});
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ChaveCarteiraCobrancaInvalida(), new StackTrace().GetFrame(1).GetMethod());
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
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInvalidoInformadoParaPropriedade("ArquivoCarteiraCobranca", ex), new StackTrace().GetFrame(1).GetMethod());
				}
			}
		}
	}

	public string UltimaMensagemErro
	{
		get
		{
			string result = "";
			Launcher.GetInstance().Executar(delegate
			{
				result = ultimaMensagemErro;
			});
			return result;
		}
		set
		{
			ultimoErroInterno = (ultimaMensagemErro = value);
		}
	}

	public ConfiguracaoCarteiraCobranca ConfiguracaoCarteiraCobranca
	{
		get
		{
			ConfiguracaoCarteiraCobranca result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoCarteiraCobranca == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoCarteiraCobrancaNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoCarteiraCobranca;
				});
			}
			return result;
		}
	}

	public ConfiguracaoBoleto ConfiguracaoBoleto
	{
		get
		{
			ConfiguracaoBoleto result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoBoleto == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoBoletoNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoBoleto;
				});
			}
			return result;
		}
	}

	public ConfiguracaoArquivoRemessa ConfiguracaoArquivoRemessa
	{
		get
		{
			ConfiguracaoArquivoRemessa result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoArquivoRemessa == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoArquivoRemessaNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoArquivoRemessa;
				});
			}
			return result;
		}
	}

	public ConfiguracaoArquivoRetorno ConfiguracaoArquivoRetorno
	{
		get
		{
			ConfiguracaoArquivoRetorno result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoArquivoRetorno == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoArquivoRetornoNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoArquivoRetorno;
				});
			}
			return result;
		}
	}

	public ConfiguracaoDocumentoCobranca ConfiguracaoDocumentoCobranca
	{
		get
		{
			ConfiguracaoDocumentoCobranca result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoDocumentoCobranca == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoDocumentoCobrancaNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoDocumentoCobranca;
				});
			}
			return result;
		}
	}

	public ConfiguracaoImpressao ConfiguracaoImpressao
	{
		get
		{
			ConfiguracaoImpressao result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoImpressao == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoDocumentoCobrancaNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoImpressao;
				});
			}
			return result;
		}
	}

	public ConfiguracaoEmail ConfiguracaoEmail
	{
		get
		{
			ConfiguracaoEmail result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.ConfiguracaoImpressao == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoDocumentoCobrancaNula(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ConfiguracaoEmail;
				});
			}
			return result;
		}
	}

	public ParametrosAdicionaisDisponiveis ParametrosDisponiveis
	{
		get
		{
			ParametrosAdicionaisDisponiveis result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.ParametrosDisponiveis;
				});
			}
			return result;
		}
	}

	public Contrato Contrato
	{
		get
		{
			Contrato result = null;
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else if (carteira.Contrato == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ContratoNulo(), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.Contrato;
				});
			}
			return result;
		}
	}

	public ArrayList DadosConfiguracao
	{
		get
		{
			ArrayList result = new ArrayList();
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().Executar(delegate
				{
					result = carteira.DadosConfiguracao;
				});
			}
			return result;
		}
		set
		{
			try
			{
				Logger.Debug("Atribuindo valor para a propriedade DadosConfiguracao");
				foreach (DadoConfiguracao item in value)
				{
					foreach (DadoConfiguracao item2 in DadosConfiguracao)
					{
						if (item.Nome == item2.Nome)
						{
							item2.Valor = item.Valor;
							break;
						}
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
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaGenericaDetectada(ex), new StackTrace().GetFrame(1).GetMethod());
				}
			}
		}
	}

	public ArrayList DocumentosCobranca
	{
		get
		{
			ArrayList result = new ArrayList();
			Launcher.GetInstance().Executar(delegate
			{
				result = documentosCobranca;
			});
			return result;
		}
	}

	public string Versao => versao;

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ControleCobranca()
	{
		guid = Guid.NewGuid();
		XmlConfigurator.Configure((Stream)new MemoryStream(Resources.log4netApp));
		Logger.Info("Iniciando eCobranca...");
		daoCarteira = new DAOCarteiraCobranca(guid);
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.CARTEIRA_COBRANCA_CRIADA);
		observableNotifyTypes.Add(EnumTipoNotificacao.CARTEIRA_COBRANCA_CARREGADA);
		observableNotifyTypes.Add(EnumTipoNotificacao.CARTEIRA_COBRANCA_GRAVADA);
		observableNotifyTypes.Add(EnumTipoNotificacao.ATUALIZAR_MENSAGEM_ERRO);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
		versao = Assembly.GetAssembly(GetType()).GetName().Version.ToString();
		HabilitaEnvioExcecoes = false;
		Logger.Info("eCobranca inicializado com sucesso.");
	}

	public ControleCobranca(string chaveCarteira)
		: this()
	{
		if (string.IsNullOrEmpty(chaveCarteira))
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ChaveCarteiraCobrancaInvalida(), new StackTrace().GetFrame(1).GetMethod());
		}
		ChaveCarteira = chaveCarteira;
		if (carteira == null)
		{
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(null), new StackTrace().GetFrame(1).GetMethod());
		}
	}

	public DocumentoCobranca NovoDocumentoCobranca()
	{
		DocumentoCobranca result = null;
		if (liberado)
		{
			Logger.Info("Criando novo documento de cobrança...");
			if (Launcher.GetInstance().Executar(delegate
			{
				result = CriarNovoDocumentoCobranca();
			}) && string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Criando novo documento de cobrança...OK");
			}
			else
			{
				Logger.Info("Criando novo documento de cobrança...ERRO");
				ultimoErroInterno = null;
			}
		}
		return result;
	}

	public void LimparDocumentosCobranca()
	{
		if (liberado)
		{
			Logger.Info("Limpado documentos de cobrança...");
			documentosCobranca = new ArrayList();
			if (string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Limpado documentos de cobrança...OK");
				return;
			}
			Logger.Info("Limpado documentos de cobrança...ERRO");
			ultimoErroInterno = null;
		}
	}

	public void CalcularDadosBoletos()
	{
		if (liberado)
		{
			Logger.Info("Calculando dados dos boletos...");
			if (Launcher.GetInstance().Executar(delegate
			{
				documentosCobranca = carteira.CalcularDadosBoletos(documentosCobranca);
			}) && string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Calculando dados dos boletos...OK");
				return;
			}
			Logger.Info("Calculando dados dos boletos...ERRO");
			ultimoErroInterno = null;
		}
	}

	public void GerarBoletos()
	{
		if (liberado)
		{
			Logger.Info("Gerando boletos...");
			if (Launcher.GetInstance().Executar(delegate
			{
				carteira.GerarBoletos(documentosCobranca);
			}) && string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Gerando boletos...OK");
				return;
			}
			Logger.Info("Gerando boletos...ERRO");
			ultimoErroInterno = null;
		}
	}

	public IList<BoletoStream> GerarBoletos(bool modoIndividual)
	{
		IList<BoletoStream> list = new List<BoletoStream>();
		try
		{
			if (liberado)
			{
				Logger.Info("Gerando boletos...");
				list = carteira.GerarBoletos(documentosCobranca, modoIndividual);
				if (list.Count > 0 && string.IsNullOrEmpty(ultimoErroInterno))
				{
					Logger.Info("Gerando boletos...OK");
					return list;
				}
				Logger.Info("Gerando boletos...ERRO");
				ultimoErroInterno = null;
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return list;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			return list;
		}
	}

	public void GerarPreview()
	{
		if (liberado)
		{
			Logger.Info("Gerando preview do boleto...");
			carteira.GetPreview();
			if (string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Gerando preview do boleto...OK");
				return;
			}
			Logger.Info("Gerando preview do boleto...ERRO");
			ultimoErroInterno = null;
		}
	}

	public string GerarArquivoRemessa()
	{
		string result = string.Empty;
		if (liberado)
		{
			Logger.Info("Gerando arquivo de remessa...");
			if (Launcher.GetInstance().Executar(delegate
			{
				result = carteira.GerarArquivoRemessa(documentosCobranca);
			}) && string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Gerando arquivo de remessa...OK");
			}
			else
			{
				Logger.Info("Gerando arquivo de remessa...ERRO");
				ultimoErroInterno = null;
			}
		}
		return result;
	}

	public ArrayList CarregarArquivoRetorno(string nomeArquivoRetorno)
	{
		ArrayList result = null;
		if (liberado)
		{
			Logger.Info("Carregando registros do arquivo de retorno [" + nomeArquivoRetorno + "]...");
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			if (Launcher.GetInstance().Executar(delegate
			{
				result = carteira.CarregarArquivoRetorno(nomeArquivoRetorno);
			}) && string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Carregando registros do arquivo de retorno [" + nomeArquivoRetorno + "]...OK");
			}
			else
			{
				Logger.Info("Carregando registros do arquivo de retorno [" + nomeArquivoRetorno + "]...ERRO");
				ultimoErroInterno = null;
			}
			stopwatch.Stop();
			Logger.Info($"Tempo gasto no processamento do arquivo de retorno em milisegundos: {stopwatch.ElapsedMilliseconds}");
			if (result != null)
			{
				Logger.Info($"Total de ocorrências de cobrança processadas: {result.Count}");
			}
		}
		return result;
	}

	[Obsolete("Método não mais suportado desde a versão 1.1.21.0500 do eCobrança")]
	public void SalvarAlteracoesCarteiraCobranca()
	{
	}

	public void LiberarRecursos()
	{
		if (liberado)
		{
			Logger.Info("Liberando recursos...");
			if (carteira != null)
			{
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoArquivoRemessa);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoArquivoRetorno);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoBoleto);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoCarteiraCobranca);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoDocumentoCobranca);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoImpressao);
				NotifyEventInterceptor.GetInstance().RemoveObserver(carteira);
			}
			if (daoCarteira != null)
			{
				NotifyEventInterceptor.GetInstance().RemoveObserver(daoCarteira);
			}
			NotifyEventInterceptor.GetInstance().RemoveObserver(this);
			if (string.IsNullOrEmpty(ultimoErroInterno))
			{
				Logger.Info("Liberando recursos...OK");
				return;
			}
			Logger.Info("Liberando recursos...ERRO");
			ultimoErroInterno = null;
		}
	}

	public void PersonalizarModeloBoleto(EnumTipoModeloBoleto tipoModeloBoleto)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		ModeloBoleto modeloBoleto = null;
		foreach (ModeloBoleto item in carteira.ConfiguracaoBoleto.ModelosBoleto)
		{
			if (item.Tipo == tipoModeloBoleto)
			{
				modeloBoleto = item;
				break;
			}
		}
		Report val = new Report();
		try
		{
			val.Load((Stream)new MemoryStream(modeloBoleto.ModeloBoletoFastReports));
			val.Design();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private DocumentoCobranca CriarNovoDocumentoCobranca()
	{
		Logger.Info("Criando novo documento de cobrança...");
		if (documentosCobranca == null)
		{
			documentosCobranca = new ArrayList();
		}
		DocumentoCobranca dc = null;
		if (Launcher.GetInstance().Executar(delegate
		{
			dc = new DocumentoCobranca((carteira.ConfiguracaoDocumentoCobranca.ModalidadesCobranca[0] as ItemLista).Valor);
		}))
		{
			documentosCobranca.Add(dc);
		}
		return dc;
	}

	private void TransferirConfiguracaoEntreCarteiras(CarteiraCobranca carteiraOrigem, CarteiraCobranca carteiraDestino)
	{
		for (int i = 0; i < carteiraOrigem.DadosConfiguracao.Count; i++)
		{
			if (!string.IsNullOrEmpty((carteiraOrigem.DadosConfiguracao[i] as DadoConfiguracao).Valor))
			{
				(carteiraDestino.DadosConfiguracao[i] as DadoConfiguracao).Valor = (carteiraOrigem.DadosConfiguracao[i] as DadoConfiguracao).Valor;
			}
		}
		carteiraDestino.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao = carteiraOrigem.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao;
		carteiraDestino.ConfiguracaoArquivoRemessa.DataUltimaRemessa = carteiraOrigem.ConfiguracaoArquivoRemessa.DataUltimaRemessa;
		carteiraDestino.ConfiguracaoArquivoRemessa.DiretorioArquivoRemessa = carteiraOrigem.ConfiguracaoArquivoRemessa.DiretorioArquivoRemessa;
		carteiraDestino.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa = carteiraOrigem.ConfiguracaoArquivoRemessa.LayoutArquivoRemessa;
		carteiraDestino.ConfiguracaoArquivoRemessa.SequenciaLote = carteiraOrigem.ConfiguracaoArquivoRemessa.SequenciaLote;
		carteiraDestino.ConfiguracaoArquivoRemessa.SequenciaRemessa = carteiraOrigem.ConfiguracaoArquivoRemessa.SequenciaRemessa;
		carteiraDestino.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria = carteiraOrigem.ConfiguracaoArquivoRemessa.SequenciaRemessaDiaria;
		foreach (ParametroConfiguracao parametrosAdicionai in carteiraOrigem.ConfiguracaoArquivoRemessa.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoArquivoRemessa.ParametrosAdicionais.Add(parametrosAdicionai);
		}
		carteiraDestino.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno = carteiraOrigem.ConfiguracaoArquivoRetorno.DiretorioArquivoRetorno;
		carteiraDestino.ConfiguracaoArquivoRetorno.LayoutArquivoRetorno = carteiraOrigem.ConfiguracaoArquivoRetorno.LayoutArquivoRetorno;
		foreach (ParametroConfiguracao parametrosAdicionai2 in carteiraOrigem.ConfiguracaoArquivoRetorno.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoArquivoRetorno.ParametrosAdicionais.Add(parametrosAdicionai2);
		}
		carteiraDestino.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega = carteiraOrigem.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboEntrega;
		carteiraDestino.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador = carteiraOrigem.ConfiguracaoBoleto.AlturaCampoDemonstrativoReciboPagador;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.DiretorioGeracaoBoleto))
		{
			carteiraDestino.ConfiguracaoBoleto.DiretorioGeracaoBoleto = carteiraOrigem.ConfiguracaoBoleto.DiretorioGeracaoBoleto;
		}
		carteiraDestino.ConfiguracaoBoleto.DiretorioImagens = carteiraOrigem.ConfiguracaoBoleto.DiretorioImagens;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado))
		{
			carteiraDestino.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado = carteiraOrigem.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado;
		}
		carteiraDestino.ConfiguracaoBoleto.ExibeCodigoBancoCompensacaoRecibo = carteiraOrigem.ConfiguracaoBoleto.ExibeCodigoBancoCompensacaoRecibo;
		carteiraDestino.ConfiguracaoBoleto.ExibeEspelhoLinhaDigitavel = carteiraOrigem.ConfiguracaoBoleto.ExibeEspelhoLinhaDigitavel;
		carteiraDestino.ConfiguracaoBoleto.ExibeLogotipoCedente = carteiraOrigem.ConfiguracaoBoleto.ExibeLogotipoCedente;
		carteiraDestino.ConfiguracaoBoleto.ExibeLogotipoBeneficiario = carteiraOrigem.ConfiguracaoBoleto.ExibeLogotipoBeneficiario;
		carteiraDestino.ConfiguracaoBoleto.ExibePropaganda = carteiraOrigem.ConfiguracaoBoleto.ExibePropaganda;
		carteiraDestino.ConfiguracaoBoleto.ExibeSAC = carteiraOrigem.ConfiguracaoBoleto.ExibeSAC;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.FormatoBoletoPersonalizado))
		{
			carteiraDestino.ConfiguracaoBoleto.FormatoBoletoPersonalizado = carteiraOrigem.ConfiguracaoBoleto.FormatoBoletoPersonalizado;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.LocalPagamento))
		{
			carteiraDestino.ConfiguracaoBoleto.LocalPagamento = carteiraOrigem.ConfiguracaoBoleto.LocalPagamento;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.LogotipoCedente))
		{
			carteiraDestino.ConfiguracaoBoleto.LogotipoCedente = carteiraOrigem.ConfiguracaoBoleto.LogotipoCedente;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.LogotipoBeneficiario))
		{
			carteiraDestino.ConfiguracaoBoleto.LogotipoBeneficiario = carteiraOrigem.ConfiguracaoBoleto.LogotipoBeneficiario;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.ModeloBoletoPersonalizado))
		{
			carteiraDestino.ConfiguracaoBoleto.ModeloBoletoPersonalizado = carteiraOrigem.ConfiguracaoBoleto.ModeloBoletoPersonalizado;
		}
		carteiraDestino.ConfiguracaoBoleto.NumeroBoletosPorPagina = carteiraOrigem.ConfiguracaoBoleto.NumeroBoletosPorPagina;
		carteiraDestino.ConfiguracaoBoleto.PrefixoNomenclatura = carteiraOrigem.ConfiguracaoBoleto.PrefixoNomenclatura;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.Propaganda))
		{
			carteiraDestino.ConfiguracaoBoleto.Propaganda = carteiraOrigem.ConfiguracaoBoleto.Propaganda;
		}
		carteiraDestino.ConfiguracaoBoleto.TipoModeloBoletoUtilizado = carteiraOrigem.ConfiguracaoBoleto.TipoModeloBoletoUtilizado;
		carteiraDestino.ConfiguracaoBoleto.TipoNomenclatura = carteiraOrigem.ConfiguracaoBoleto.TipoNomenclatura;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoBoleto.TipoPropaganda))
		{
			carteiraDestino.ConfiguracaoBoleto.TipoPropaganda = carteiraOrigem.ConfiguracaoBoleto.TipoPropaganda;
		}
		foreach (ParametroConfiguracao parametrosAdicionai3 in carteiraOrigem.ConfiguracaoBoleto.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoBoleto.ParametrosAdicionais.Add(parametrosAdicionai3);
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoAceite))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoAceite = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoAceite;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoDesconto = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoDesconto;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoJuros = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoJuros;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoMoeda))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoMoeda = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoMoeda;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoMulta = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoMulta;
		}
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoProtesto))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.CodigoProtesto = carteiraOrigem.ConfiguracaoDocumentoCobranca.CodigoProtesto;
		}
		carteiraDestino.ConfiguracaoDocumentoCobranca.DiasBaixa = carteiraOrigem.ConfiguracaoDocumentoCobranca.DiasBaixa;
		carteiraDestino.ConfiguracaoDocumentoCobranca.DiasProtesto = carteiraOrigem.ConfiguracaoDocumentoCobranca.DiasProtesto;
		carteiraDestino.ConfiguracaoDocumentoCobranca.PercentualDesconto = carteiraOrigem.ConfiguracaoDocumentoCobranca.PercentualDesconto;
		carteiraDestino.ConfiguracaoDocumentoCobranca.PercentualJurosAoDia = carteiraOrigem.ConfiguracaoDocumentoCobranca.PercentualJurosAoDia;
		carteiraDestino.ConfiguracaoDocumentoCobranca.PercentualMulta = carteiraOrigem.ConfiguracaoDocumentoCobranca.PercentualMulta;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca))
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca = carteiraOrigem.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca;
		}
		carteiraDestino.ConfiguracaoDocumentoCobranca.ValorDesconto = carteiraOrigem.ConfiguracaoDocumentoCobranca.ValorDesconto;
		carteiraDestino.ConfiguracaoDocumentoCobranca.ValorJurosAoDia = carteiraOrigem.ConfiguracaoDocumentoCobranca.ValorJurosAoDia;
		carteiraOrigem.ConfiguracaoDocumentoCobranca.ValorMulta = carteiraOrigem.ConfiguracaoDocumentoCobranca.ValorMulta;
		foreach (ParametroConfiguracao parametrosAdicionai4 in carteiraOrigem.ConfiguracaoDocumentoCobranca.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoDocumentoCobranca.ParametrosAdicionais.Add(parametrosAdicionai4);
		}
		carteiraDestino.ConfiguracaoImpressao.FormatoSaida = carteiraOrigem.ConfiguracaoImpressao.FormatoSaida;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoImpressao.ModoImpressao))
		{
			carteiraDestino.ConfiguracaoImpressao.ModoImpressao = carteiraOrigem.ConfiguracaoImpressao.ModoImpressao;
		}
		carteiraDestino.ConfiguracaoImpressao.ModoSaida = carteiraOrigem.ConfiguracaoImpressao.ModoSaida;
		if (!string.IsNullOrEmpty(carteiraOrigem.ConfiguracaoImpressao.NomeImpressora))
		{
			carteiraDestino.ConfiguracaoImpressao.NomeImpressora = carteiraOrigem.ConfiguracaoImpressao.NomeImpressora;
		}
		foreach (ParametroConfiguracao parametrosAdicionai5 in carteiraOrigem.ConfiguracaoImpressao.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoImpressao.ParametrosAdicionais.Add(parametrosAdicionai5);
		}
		carteiraDestino.ConfiguracaoEmail.ServidorSMTP = carteiraOrigem.ConfiguracaoEmail.ServidorSMTP;
		carteiraDestino.ConfiguracaoEmail.Assunto = carteiraOrigem.ConfiguracaoEmail.Assunto;
		carteiraDestino.ConfiguracaoEmail.EnviaEmail = carteiraOrigem.ConfiguracaoEmail.EnviaEmail;
		carteiraDestino.ConfiguracaoEmail.HostSMTP = carteiraOrigem.ConfiguracaoEmail.HostSMTP;
		carteiraDestino.ConfiguracaoEmail.Mensagem = carteiraOrigem.ConfiguracaoEmail.Mensagem;
		carteiraDestino.ConfiguracaoEmail.PortaSMTP = carteiraOrigem.ConfiguracaoEmail.PortaSMTP;
		carteiraDestino.ConfiguracaoEmail.PossuiAutenticacao = carteiraOrigem.ConfiguracaoEmail.PossuiAutenticacao;
		carteiraDestino.ConfiguracaoEmail.Remetente = carteiraOrigem.ConfiguracaoEmail.Remetente;
		carteiraDestino.ConfiguracaoEmail.SenhaSMTP = carteiraOrigem.ConfiguracaoEmail.SenhaSMTP;
		carteiraDestino.ConfiguracaoEmail.UsuarioSMTP = carteiraOrigem.ConfiguracaoEmail.UsuarioSMTP;
		carteiraDestino.ConfiguracaoEmail.UtilizaSSL = carteiraOrigem.ConfiguracaoEmail.UtilizaSSL;
		foreach (ParametroConfiguracao parametrosAdicionai6 in carteiraOrigem.ConfiguracaoEmail.ParametrosAdicionais)
		{
			carteiraDestino.ConfiguracaoEmail.ParametrosAdicionais.Add(parametrosAdicionai6);
		}
	}

	private bool ValidarCarteira(CarteiraCobranca carteira)
	{
		bool result = true;
		try
		{
			if (carteira == null)
			{
				result = false;
				return result;
			}
			if (carteira.ConfiguracaoCarteiraCobranca.DataVigencia < DateTime.Today)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.DataVigenciaExpirada(carteira.ConfiguracaoCarteiraCobranca.DataVigencia), new StackTrace().GetFrame(1).GetMethod());
				result = false;
				return result;
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public void Update(NotifyEvent ne)
	{
		switch (ne.Type)
		{
		case EnumTipoNotificacao.CARTEIRA_COBRANCA_CRIADA:
			ArquivoCarteiraCobranca = ne.Parameters[0].ToString();
			Logger.Debug("Carteira de cobrança criada com sucesso.");
			break;
		case EnumTipoNotificacao.CARTEIRA_COBRANCA_GRAVADA:
			ArquivoCarteiraCobranca = ne.Parameters[0].ToString();
			Logger.Debug("Carteira de cobrança salva com sucesso.");
			break;
		case EnumTipoNotificacao.CARTEIRA_COBRANCA_CARREGADA:
			if (ne.Parameters[0].GetType().IsSubclassOf(typeof(CarteiraCobranca)))
			{
				carteira = (CarteiraCobranca)ne.Parameters[0];
				liberado = ValidarCarteira((CarteiraCobranca)ne.Parameters[0]);
				if (liberado)
				{
					Logger.Info("Carteira de cobrança carregada com sucesso.");
				}
			}
			break;
		case EnumTipoNotificacao.ATUALIZAR_MENSAGEM_ERRO:
			if (ne.Parameters[0].GetType().IsSubclassOf(typeof(Exception)))
			{
				UltimaMensagemErro = (ne.Parameters[0] as Exception).Message;
			}
			break;
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
}
