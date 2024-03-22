using System;

namespace eCobranca.Core.Patterns.Observer;

public interface IObservable
{
	event EventHandler<NotifyEvent> onNotifyEvent;

	void TriggerNotifyEvent(object sender, NotifyEvent notifyEvent);

	void RefreshNotifyEventHandler();
}
