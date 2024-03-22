namespace eCobranca.Core.Automacao.Cnab400.Estrutura;

public abstract class SegmentoLoteCnab400 : SegmentoCnab400
{
	public SegmentoLoteCnab400(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected abstract override void CarregarCampos();
}
