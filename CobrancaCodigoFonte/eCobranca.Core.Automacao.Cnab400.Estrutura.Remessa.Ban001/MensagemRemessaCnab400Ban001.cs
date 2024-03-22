namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;

public abstract class MensagemRemessaCnab400Ban001 : MensagemRemessaCnab400
{
	public MensagemRemessaCnab400Ban001(long sequenciaSegmento)
		: base(sequenciaSegmento)
	{
	}

	protected abstract override void CarregarCampos();
}
