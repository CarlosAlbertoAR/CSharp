namespace eCobranca.Core.Automacao.Febraban240;

public interface ISegmentoFebraban240
{
	string GerarRegistro();

	void CarregarRegistro(string linhaDados);

	string[] GerarManual();
}
