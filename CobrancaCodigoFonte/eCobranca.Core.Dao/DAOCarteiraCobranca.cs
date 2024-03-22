using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;
using Newtonsoft.Json;

namespace eCobranca.Core.Dao;

public class DAOCarteiraCobranca : IObserver, IObservable
{
	private IList<EnumTipoNotificacao> observableNotifyTypes;

	private Guid guid;

	private readonly string chaveCriptografia = "ac}SK4G[6.^BkMUk";

	private readonly string vetorInicializacao = "q{)C*aS%7uG/48S+";

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public DAOCarteiraCobranca(Guid guid)
	{
		this.guid = guid;
		Logger.Debug("Criando DAO para carteira de cobrança...");
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.CRIAR_CARTEIRA_COBRANCA);
		observableNotifyTypes.Add(EnumTipoNotificacao.CARREGAR_CARTEIRA_COBRANCA);
		observableNotifyTypes.Add(EnumTipoNotificacao.SALVAR_CARTEIRA_COBRANCA);
		observableNotifyTypes.Add(EnumTipoNotificacao.INSTANCIAR_CARTEIRA_COBRANCA);
		Logger.Debug("Registrando DAOCarteiraCobranca como observer...");
		NotifyEventInterceptor.GetInstance().AddObserver(this);
		Logger.Debug("Registrando DAOCarteiraCobranca como observable...");
		Logger.Debug("DAO carteira de cobrança criado com sucesso.");
	}

	private void InstanciarCarteiraCobranca(string chaveCarteira)
	{
		try
		{
			Logger.Debug("Instanciando carteira de cobrança...");
			if (string.IsNullOrEmpty(chaveCarteira))
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.StringVaziaParaCriptografar(), new StackTrace().GetFrame(1).GetMethod());
				return;
			}
			ConfiguracaoCarteiraPOCO configuracaoCarteiraPOCO = JsonConvert.DeserializeObject<ConfiguracaoCarteiraPOCO>(AESEncryptionUtil.Decriptar(chaveCriptografia, vetorInicializacao, chaveCarteira));
			CarteiraCobranca carteira = FactoryCarteiraCobranca.GetInstance().GetCarteira(configuracaoCarteiraPOCO.ParseTo());
			carteira.ConfiguracaoCarteiraCobranca.DiretorioCarteiraCobranca = AppDomain.CurrentDomain.BaseDirectory;
			NotifyEventInterceptor.GetInstance().AddObserver(carteira);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoArquivoRemessa);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoArquivoRetorno);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoBoleto);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoCarteiraCobranca);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoDocumentoCobranca);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoImpressao);
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.LIBERAR_ESCRITA_CARTEIRA_COBRANCA));
			});
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARTEIRA_COBRANCA_CARREGADA, carteira));
			});
		}
		catch (Exception ex)
		{
			if (ex != null)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ChaveCarteiraCobrancaInvalida(), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void CarregarCarteiraCobranca(string nomeAbsolutoCarteiraCobranca)
	{
		try
		{
			Logger.Debug($"Carregando arquivo de carteira de cobrança [{nomeAbsolutoCarteiraCobranca}]");
			if (!File.Exists(nomeAbsolutoCarteiraCobranca))
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNaoEncontradoOuInexistente(nomeAbsolutoCarteiraCobranca, new FileNotFoundException()), new StackTrace().GetFrame(1).GetMethod());
				return;
			}
			string binStringEncrypted = FileManager.ReadStringFromFile(nomeAbsolutoCarteiraCobranca);
			CarteiraCobranca carteira = BinarySerializerManager<CarteiraCobranca>.DeserializeFromEncryptedString(binStringEncrypted);
			carteira.ConfiguracaoCarteiraCobranca.DiretorioCarteiraCobranca = Path.GetDirectoryName(nomeAbsolutoCarteiraCobranca) + "\\";
			carteira.RefreshNotifyEventHandler();
			carteira.ConfiguracaoArquivoRemessa.RefreshNotifyEventHandler();
			carteira.ConfiguracaoArquivoRetorno.RefreshNotifyEventHandler();
			carteira.ConfiguracaoBoleto.RefreshNotifyEventHandler();
			carteira.ConfiguracaoCarteiraCobranca.RefreshNotifyEventHandler();
			carteira.ConfiguracaoDocumentoCobranca.RefreshNotifyEventHandler();
			carteira.ConfiguracaoImpressao.RefreshNotifyEventHandler();
			NotifyEventInterceptor.GetInstance().AddObserver(carteira);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoArquivoRemessa);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoArquivoRetorno);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoBoleto);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoCarteiraCobranca);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoDocumentoCobranca);
			NotifyEventInterceptor.GetInstance().AddObserver(carteira.ConfiguracaoImpressao);
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_GUID));
			});
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_REFERENCIA_CARTEIRA_COBRANCA, carteira));
			});
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS, carteira.ParametrosDisponiveis));
			});
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARTEIRA_COBRANCA_CARREGADA, carteira));
			});
		}
		catch (Exception ex)
		{
			if (ex != null)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ImpossivelCarregarCarteiraCobranca(nomeAbsolutoCarteiraCobranca, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void CreateCarteiraCobranca(ConfiguracaoCarteiraCobranca configuracaoCarteira)
	{
		try
		{
			Logger.Debug($"Criando arquivo de carteira de cobrança a partir da configuração da carteira...");
			if (configuracaoCarteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.ConfiguracaoCarteiraCobrancaInexistente(new NullReferenceException()), new StackTrace().GetFrame(1).GetMethod());
			}
			CarteiraCobranca carteira = FactoryCarteiraCobranca.GetInstance().GetCarteira(configuracaoCarteira);
			string dataFile = BinarySerializerManager<CarteiraCobranca>.SerializeToEncryptedString(carteira);
			string nomeArquivoCarteiraCobranca = carteira.ConfiguracaoCarteiraCobranca.DiretorioCarteiraCobranca + StringUtil.RemoverMascara(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario) + "-" + configuracaoCarteira.TipoCarteiraCobranca + ".cart";
			FileManager.WriteStringToFile(nomeArquivoCarteiraCobranca, dataFile);
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.LIBERAR_ESCRITA_CARTEIRA_COBRANCA));
			});
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARTEIRA_COBRANCA_CRIADA, nomeArquivoCarteiraCobranca));
			});
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCriandoCarteiraCobranca(configuracaoCarteira, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void SalvarCarteiraCobranca(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug($"Salvando alterações na carteira de cobrança [{carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca}]");
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoArquivoRemessa);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoArquivoRetorno);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoBoleto);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoCarteiraCobranca);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoDocumentoCobranca);
			NotifyEventInterceptor.GetInstance().RemoveObserver(carteira.ConfiguracaoImpressao);
			if (carteira == null)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.CarteiraCobrancaNula(new NullReferenceException()), new StackTrace().GetFrame(1).GetMethod());
			}
			string dataFile = BinarySerializerManager<CarteiraCobranca>.SerializeToEncryptedString(carteira);
			string nomeArquivoCarteiraCobranca = carteira.ConfiguracaoCarteiraCobranca.DiretorioCarteiraCobranca + StringUtil.RemoverMascara(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario) + "-" + carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca + ".cart";
			FileManager.WriteStringToFile(nomeArquivoCarteiraCobranca, dataFile);
			Launcher.GetInstance().Executar(delegate
			{
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARTEIRA_COBRANCA_GRAVADA, nomeArquivoCarteiraCobranca));
			});
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaSalvandoAlteracoesCarteiraCobranca(carteira, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Update(NotifyEvent ne)
	{
		Logger.Debug($"Atendendo evento de notificação {ne.Type.ToString()}");
		switch (ne.Type)
		{
		case EnumTipoNotificacao.CRIAR_CARTEIRA_COBRANCA:
			if (ne.Parameters[0].GetType().Equals(typeof(ConfiguracaoCarteiraCobranca)))
			{
				CreateCarteiraCobranca((ConfiguracaoCarteiraCobranca)ne.Parameters[0]);
			}
			break;
		case EnumTipoNotificacao.CARREGAR_CARTEIRA_COBRANCA:
			if (ne.Parameters[0].GetType().Equals(typeof(string)))
			{
				CarregarCarteiraCobranca((string)ne.Parameters[0]);
			}
			break;
		case EnumTipoNotificacao.SALVAR_CARTEIRA_COBRANCA:
			if (ne.Parameters[0] is CarteiraCobranca)
			{
				SalvarCarteiraCobranca((CarteiraCobranca)ne.Parameters[0]);
			}
			break;
		case EnumTipoNotificacao.INSTANCIAR_CARTEIRA_COBRANCA:
			if (ne.Parameters[0] is string)
			{
				InstanciarCarteiraCobranca(ne.Parameters[0].ToString());
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
