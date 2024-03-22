using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Configuracoes;

[Serializable]
public abstract class ConfiguracaoECobranca : IObserver, IObservable, ISerializable
{
	private ArrayList parametrosAdicionais;

	[NonSerialized]
	private ParametrosAdicionaisDisponiveis parametrosDisponiveis;

	[NonSerialized]
	protected IList<EnumTipoNotificacao> observableNotifyTypes;

	[NonSerialized]
	protected EnumChaveContexto chaveFebraban240;

	[NonSerialized]
	protected EnumChaveContexto chaveCnab400;

	protected EnumCodigoBanco banco;

	private EnumModoUsoECobranca modoUso;

	[NonSerialized]
	protected CarteiraCobranca carteira;

	protected Guid guid;

	public EnumModoUsoECobranca ModoUso => modoUso;

	public ParametrosAdicionaisDisponiveis ParametrosDisponiveis => parametrosDisponiveis;

	public ArrayList ParametrosAdicionais => parametrosAdicionais;

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ConfiguracaoECobranca(Guid guid, string banco, EnumModoUsoECobranca modoUso, CarteiraCobranca carteira)
	{
		this.guid = guid;
		this.modoUso = modoUso;
		this.carteira = carteira;
		parametrosAdicionais = new ArrayList();
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_GUID);
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS);
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_REFERENCIA_CARTEIRA_COBRANCA);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
		this.banco = (EnumCodigoBanco)(object)banco.ToEnum<EnumCodigoBanco>();
	}

	public ConfiguracaoECobranca(SerializationInfo serobj, StreamingContext scontext)
	{
		guid = (Guid)serobj.GetValue("Guid", typeof(Guid));
		banco = (EnumCodigoBanco)serobj.GetValue("Banco", typeof(EnumCodigoBanco));
		modoUso = (EnumModoUsoECobranca)serobj.GetValue("ModoUso", typeof(EnumModoUsoECobranca));
		parametrosAdicionais = (ArrayList)serobj.GetValue("ParametrosAdicionais", typeof(ArrayList));
		RefreshNotifyEventHandler();
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_GUID);
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS);
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_REFERENCIA_CARTEIRA_COBRANCA);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
	}

	public ParametroConfiguracao NovoParametroAdicional(ParametroConfiguracao pc)
	{
		Logger.Info("Criando parâmetro de configuração adicional...");
		if (parametrosAdicionais == null)
		{
			parametrosAdicionais = new ArrayList();
		}
		parametrosAdicionais.Add(pc);
		return pc;
	}

	public ParametroConfiguracao NovoParametroAdicional()
	{
		Logger.Info("Criando parâmetro de configuração adicional...");
		if (parametrosAdicionais == null)
		{
			parametrosAdicionais = new ArrayList();
		}
		ParametroConfiguracao parametroConfiguracao = new ParametroConfiguracao();
		parametrosAdicionais.Add(parametroConfiguracao);
		return parametroConfiguracao;
	}

	public void LimparParametrosAdicionais()
	{
		parametrosAdicionais = new ArrayList();
	}

	public abstract void CarregarListas(RepositorioCodigosCobranca repositorio);

	public virtual void Update(NotifyEvent ne)
	{
		switch (ne.Type)
		{
		case EnumTipoNotificacao.SET_REFERENCIA_PARAMETROS_DISPONIVEIS:
			if (ne.Parameters[0] is ParametrosAdicionaisDisponiveis)
			{
				parametrosDisponiveis = (ParametrosAdicionaisDisponiveis)ne.Parameters[0];
			}
			break;
		case EnumTipoNotificacao.SET_REFERENCIA_CARTEIRA_COBRANCA:
			if (!(ne.Parameters[0] is CarteiraCobranca))
			{
				break;
			}
			carteira = (CarteiraCobranca)ne.Parameters[0];
			if (this is ConfiguracaoBoleto)
			{
				Launcher.GetInstance().Executar(delegate
				{
					TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.CARREGAR_MODELOS_BOLETO));
				});
			}
			break;
		case EnumTipoNotificacao.SET_GUID:
			guid = ne.Guid;
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

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Guid", guid);
		info.AddValue("Banco", banco);
		info.AddValue("ModoUso", modoUso);
		info.AddValue("ParametrosAdicionais", parametrosAdicionais);
	}
}
