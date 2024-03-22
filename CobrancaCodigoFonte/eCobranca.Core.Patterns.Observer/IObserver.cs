using System;
using System.Collections.Generic;
using eCobranca.Enumerator;

namespace eCobranca.Core.Patterns.Observer;

public interface IObserver
{
	IList<EnumTipoNotificacao> ObservableNotifyTypes { get; }

	void Update(NotifyEvent ne);

	Guid GetGuid();
}
