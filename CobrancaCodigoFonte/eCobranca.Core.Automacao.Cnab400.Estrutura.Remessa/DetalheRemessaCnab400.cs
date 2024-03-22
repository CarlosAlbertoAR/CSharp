namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;

public abstract class DetalheRemessaCnab400 : SegmentoLoteCnab400
{
	public DetalheRemessaCnab400(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected abstract override void CarregarCampos();
}
