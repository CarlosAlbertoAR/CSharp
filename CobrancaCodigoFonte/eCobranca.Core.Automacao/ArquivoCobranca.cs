using System;
using System.Collections.Generic;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao;

public abstract class ArquivoCobranca : IArquivoCobranca, IObservable, IObserver
{
	protected EnumPadraoArquivoCobranca padrao;

	protected EnumTipoArquivoCobranca tipo;

	protected string diretorio;

	protected string versao;

	protected long sequencia;

	protected DateTime dataGeracao;

	protected IList<EnumTipoNotificacao> observableNotifyTypes;

	protected string nomeArquivoRemessa;

	protected Guid guid;

	protected EnumTipoCarteiraCobranca tipoCarteiraCobranca;

	private ParameterUtil parameterUtil;

	public ParameterUtil ParameterUtil => parameterUtil;

	public EnumTipoCarteiraCobranca TipoCarteiraCobranca => tipoCarteiraCobranca;

	public EnumPadraoArquivoCobranca Padrao => padrao;

	public EnumTipoArquivoCobranca Tipo => tipo;

	public string Versao => versao;

	protected string NomeArquivoRemessa => nomeArquivoRemessa;

	public string Diretorio
	{
		get
		{
			return diretorio;
		}
		set
		{
			diretorio = value;
		}
	}

	public DateTime DataGeracao
	{
		get
		{
			return dataGeracao;
		}
		set
		{
			dataGeracao = value;
		}
	}

	public long Sequencia
	{
		get
		{
			return sequencia;
		}
		set
		{
			sequencia = value;
		}
	}

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public event EventHandler<NotifyEvent> onNotifyEvent;

	public ArquivoCobranca(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
	{
		this.guid = guid;
		parameterUtil = ParameterUtil.GetInstance();
		this.tipoCarteiraCobranca = tipoCarteiraCobranca;
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.SET_NOME_ARQUIVO_REMESSA);
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

	public void Update(NotifyEvent ne)
	{
		if (ne.Type == EnumTipoNotificacao.SET_NOME_ARQUIVO_REMESSA)
		{
			nomeArquivoRemessa = ne.Parameters[0].ToString();
		}
	}

	public Guid GetGuid()
	{
		return guid;
	}
}
