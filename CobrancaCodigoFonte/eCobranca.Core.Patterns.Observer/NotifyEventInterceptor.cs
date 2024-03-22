using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Patterns.Observer;

public class NotifyEventInterceptor : IInterceptor
{
	private IList<IObserver> observers;

	private static NotifyEventInterceptor uniqueInstance;

	private static object syncRoot = new object();

	private IList<NotifyEvent> notificacoesPendentes;

	private NotifyEventInterceptor()
	{
		observers = new List<IObserver>();
		notificacoesPendentes = new List<NotifyEvent>();
	}

	public static NotifyEventInterceptor GetInstance()
	{
		if (uniqueInstance == null)
		{
			lock (syncRoot)
			{
				if (uniqueInstance == null)
				{
					uniqueInstance = new NotifyEventInterceptor();
				}
			}
		}
		return uniqueInstance;
	}

	public void AddObserver(IObserver observer)
	{
		try
		{
			if (observer.ObservableNotifyTypes == null || observer.ObservableNotifyTypes.Count == 0)
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ObservadorNaoAtendeANenhumTipoDeNotificacao(observer.GetType().Name), new StackTrace().GetFrame(1).GetMethod());
			}
			IObserver observer2 = observers.Where((IObserver x) => x.GetType() == observer.GetType()).FirstOrDefault();
			if (observer2 != null && observer2.GetGuid().Equals(observer.GetGuid()))
			{
				RemoveObserver(observer2);
			}
			if (!observers.Contains(observer))
			{
				observers.Add(observer);
				Logger.Debug($"Observador [{observer.GetType().Name}] registrado com sucesso.");
				return;
			}
			IObserver observer3 = observers.ElementAt(observers.IndexOf(observer));
			if (observer3.GetGuid() != observer.GetGuid())
			{
				observers.Remove(observer3);
				observers.Add(observer);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaRegistrandoObservador(observer.GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void RemoveObserver(IObserver observer)
	{
		try
		{
			if (observers.Contains(observer))
			{
				observers.Remove(observer);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaRegistrandoObservador(observer.GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void NotifyObservers(NotifyEvent ne)
	{
		Logger.Debug($"Notificando observadores do evento [{ne.Type.ToString()}]");
		int num = 0;
		for (int i = 0; i < observers.Count; i++)
		{
			if (!observers[i].ObservableNotifyTypes.Contains(ne.Type))
			{
				continue;
			}
			if (ne.Guid.Equals(observers[i].GetGuid()))
			{
				if (ne.Target == null || ne.Target == observers[i])
				{
					Logger.Debug($"Notificando observador [{observers[i].GetType().Name}]");
					observers[i].Update(ne);
					num++;
				}
			}
			else if (ne.Type.Equals(EnumTipoNotificacao.ATUALIZAR_MENSAGEM_ERRO))
			{
				observers[i].Update(ne);
				num++;
			}
			else if (ne.Type.Equals(EnumTipoNotificacao.SET_GUID))
			{
				observers[i].Update(ne);
				num++;
			}
		}
		Logger.Debug($"Foram notificados [{num}] observadores do evento [{ne.Type.ToString()}]");
	}

	public void OnNotifyEvent(object sender, NotifyEvent ne)
	{
		ne.Source = sender;
		Launcher.GetInstance().Executar(delegate
		{
			NotifyObservers(ne);
		});
	}
}
