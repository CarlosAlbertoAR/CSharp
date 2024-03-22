namespace eCobranca.Core.Automacao.Cnab400;

public interface ISegmentoCnab400
{
	string GerarRegistro();

	void CarregarRegistro(string linhaDados);

	string[] GerarManual();
}
