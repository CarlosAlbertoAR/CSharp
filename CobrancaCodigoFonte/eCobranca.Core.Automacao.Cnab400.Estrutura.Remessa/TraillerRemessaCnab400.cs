using System;
using System.Collections.Generic;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;

public abstract class TraillerRemessaCnab400 : SegmentoCnab400, IObserver
{
	protected IList<EnumTipoNotificacao> observableNotifyTypes;

	public IList<EnumTipoNotificacao> ObservableNotifyTypes => observableNotifyTypes;

	public TraillerRemessaCnab400(long sequenciaSegmento, Guid guid)
		: base(sequenciaSegmento)
	{
		base.guid = guid;
		observableNotifyTypes = new List<EnumTipoNotificacao>();
		observableNotifyTypes.Add(EnumTipoNotificacao.ATUALIZAR_SEQUENCIA_TRAILLER_CNAB400);
		NotifyEventInterceptor.GetInstance().AddObserver(this);
	}

	protected abstract override void CarregarCampos();

	public void Update(NotifyEvent ne)
	{
		if (ne.Type == EnumTipoNotificacao.ATUALIZAR_SEQUENCIA_TRAILLER_CNAB400 && int.TryParse(ne.Parameters[0].ToString(), out var result))
		{
			base.Sequencia = result;
		}
	}

	public Guid GetGuid()
	{
		return guid;
	}
}
