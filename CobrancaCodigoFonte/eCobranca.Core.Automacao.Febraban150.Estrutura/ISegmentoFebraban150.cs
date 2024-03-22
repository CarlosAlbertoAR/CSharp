namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public interface ISegmentoFebraban150
{
	string GerarRegistro();

	void CarregarRegistro(string linhaDados);

	string[] GerarManual();
}
