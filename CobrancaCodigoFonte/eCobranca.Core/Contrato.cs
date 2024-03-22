namespace eCobranca.Core;

public class Contrato
{
	private string versaoECobranca;

	private string conteudo;

	public string Conteudo => conteudo;

	public string VersaoECobranca => versaoECobranca;

	public Contrato()
	{
		conteudo = "Contrato ainda não elaborado.";
		versaoECobranca = "1.0.0.0";
	}
}
