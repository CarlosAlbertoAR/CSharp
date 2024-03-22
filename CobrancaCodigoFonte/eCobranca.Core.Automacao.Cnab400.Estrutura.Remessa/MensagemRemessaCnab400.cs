namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;

public abstract class MensagemRemessaCnab400 : SegmentoLoteCnab400
{
	public MensagemRemessaCnab400(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected abstract override void CarregarCampos();
}
