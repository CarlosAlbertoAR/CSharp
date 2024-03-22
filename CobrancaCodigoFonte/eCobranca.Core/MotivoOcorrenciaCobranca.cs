namespace eCobranca.Core;

public class MotivoOcorrenciaCobranca
{
	private string codigo;

	private string descricao;

	public string Codigo
	{
		get
		{
			return codigo;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				codigo = value;
			}
		}
	}

	public string Descricao
	{
		get
		{
			return descricao;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				descricao = value;
			}
		}
	}

	public MotivoOcorrenciaCobranca()
	{
		codigo = "";
		descricao = "";
	}

	public MotivoOcorrenciaCobranca(string codigo, string descricao)
	{
		this.codigo = codigo;
		this.descricao = descricao;
	}
}
