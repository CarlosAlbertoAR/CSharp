using System;
using System.Collections;

namespace eCobranca.Atributos;

public class AtributoDominio : Attribute
{
	private readonly string _codigo;

	private readonly string _sigla;

	private readonly string _ajuda;

	private string _mascara;

	private readonly string _valorPadrao;

	private readonly ArrayList _valoresDefinidos;

	public string Codigo => _codigo;

	public string Sigla => _sigla;

	public string Ajuda => _ajuda;

	public string Mascara
	{
		get
		{
			return _mascara;
		}
		set
		{
			_mascara = value;
		}
	}

	public string ValorPadrao => _valorPadrao;

	public ArrayList ValoresDefinidos => _valoresDefinidos;

	public AtributoDominio()
	{
	}

	public AtributoDominio(string codigo, object[] valoresPossiveis = null)
	{
		_codigo = codigo;
		_sigla = "";
		_mascara = "";
		_ajuda = "";
		_valoresDefinidos = new ArrayList();
		_valorPadrao = "";
		if (valoresPossiveis != null)
		{
			foreach (object obj in valoresPossiveis)
			{
				_valoresDefinidos.Add(obj.ToString());
			}
		}
	}

	public AtributoDominio(string codigo, string sigla, object[] valoresPossiveis = null)
		: this(codigo, valoresPossiveis)
	{
		_sigla = sigla;
	}

	public AtributoDominio(string codigo, string sigla, string ajuda, string mascara, string valorPadrao, object[] valoresPossiveis = null)
		: this(codigo, sigla, valoresPossiveis)
	{
		_ajuda = ajuda;
		_mascara = mascara;
		_valorPadrao = valorPadrao;
	}
}
