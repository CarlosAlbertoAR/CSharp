namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;

public abstract class HeaderRemessaCnab400 : SegmentoCnab400
{
	public HeaderRemessaCnab400(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected abstract override void CarregarCampos();
}
