namespace eCobranca.Core;

public class ArquivoEnvioEmail
{
	private string nome;

	private string email;

	public string Nome
	{
		get
		{
			return nome;
		}
		set
		{
			nome = value;
		}
	}

	public string Email
	{
		get
		{
			return email;
		}
		set
		{
			email = value;
		}
	}

	public ArquivoEnvioEmail(string arquivo, string email)
	{
		nome = arquivo;
		this.email = email;
	}
}
