using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Patterns.Observer;

public class NotifyEvent : EventArgs
{
	private EnumTipoNotificacao type;

	private object source;

	private object target;

	private Guid guid;

	private object[] parameters;

	public Guid Guid => guid;

	public EnumTipoNotificacao Type => type;

	public object Source
	{
		get
		{
			return source;
		}
		set
		{
			source = value;
		}
	}

	public object Target
	{
		get
		{
			return target;
		}
		set
		{
			target = value;
		}
	}

	public object[] Parameters => parameters;

	public NotifyEvent(EnumTipoNotificacao tipoNotificacao, params object[] param)
	{
		type = tipoNotificacao;
		parameters = param;
		guid = default(Guid);
	}

	public NotifyEvent(Guid guid, EnumTipoNotificacao tipoNotificacao, params object[] param)
		: this(tipoNotificacao, param)
	{
		this.guid = guid;
		type = tipoNotificacao;
		parameters = param;
	}
}
