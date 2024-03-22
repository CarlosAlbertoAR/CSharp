namespace eCobranca.Core;

public class InstrucaoCobranca
{
	private string codigo;

	private string valor;

	public string Codigo
	{
		get
		{
			return codigo;
		}
		set
		{
			codigo = value;
		}
	}

	public string Valor
	{
		get
		{
			return valor;
		}
		set
		{
			valor = value;
		}
	}

	public InstrucaoCobranca()
	{
		codigo = "";
		valor = "";
	}
}
