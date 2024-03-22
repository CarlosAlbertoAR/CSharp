using System;
using System.Diagnostics;
using System.Reflection;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class Launcher : IObservable
{
	private static Launcher uniqueInstance;

	private bool throwExceptions;

	private static object syncRoot = new object();

	public bool ThrowExceptions
	{
		get
		{
			return throwExceptions;
		}
		set
		{
			throwExceptions = value;
		}
	}

	public event EventHandler<NotifyEvent> onNotifyEvent;

	private Launcher()
	{
		throwExceptions = false;
	}

	public static Launcher GetInstance()
	{
		if (uniqueInstance == null)
		{
			lock (syncRoot)
			{
				if (uniqueInstance == null)
				{
					uniqueInstance = new Launcher();
				}
			}
		}
		return uniqueInstance;
	}

	public bool Executar(Action method)
	{
		try
		{
			method();
			return true;
		}
		catch (Exception e)
		{
			LancarExcecao(e, method.Method);
			return false;
		}
	}

	public void LancarExcecao(Exception e, MethodBase method)
	{
		string text = "";
		string text2 = "";
		Exception ex = null;
		if (method == null)
		{
			StackTrace stackTrace = new StackTrace();
			text = stackTrace.GetFrame(1).GetMethod().DeclaringType.Name + "." + stackTrace.GetFrame(1).GetMethod().Name;
		}
		else
		{
			text = method.DeclaringType.Name + "." + method.Name;
		}
		for (ex = e.InnerException; ex != null; ex = ex.InnerException)
		{
			text2 = text2 + ex.GetType().Name + " : " + ex.Message + Environment.NewLine;
		}
		if (!(e is ExcecaoECobranca))
		{
			e = ExcecaoECobranca.Infra.FalhaGenericaDetectada(e);
		}
		switch ((e as ExcecaoGenerica).Tipo)
		{
		case EnumTipoExcecaoECobranca.WARNING:
			Logger.Warn(e.Message + Environment.NewLine + text2, text);
			break;
		case EnumTipoExcecaoECobranca.ERROR:
			Logger.Error(e, text);
			break;
		case EnumTipoExcecaoECobranca.FATAL:
			Logger.Error(e, text);
			break;
		}
		TriggerNotifyEvent(this, new NotifyEvent(EnumTipoNotificacao.ATUALIZAR_MENSAGEM_ERRO, e));
		if (throwExceptions)
		{
			throw e;
		}
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
