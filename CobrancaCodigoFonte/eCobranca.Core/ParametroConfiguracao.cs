using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Util;

namespace eCobranca.Core;

[Serializable]
public class ParametroConfiguracao : ISerializable
{
	private string codigo;

	private string nome;

	private string sigla;

	private string valor;

	private string ajuda;

	private ArrayList valoresDefinidos;

	private string valorPadrao;

	private bool valorDefinido;

	private string mascara;

	public string Nome
	{
		get
		{
			return nome;
		}
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				nome = value;
			}
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
			Logger.Debug($"Atribuindo valor para parametro adicional de configuração: [{Nome}] ");
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			if (valoresDefinidos.Count > 0)
			{
				if (valoresDefinidos.Contains(value))
				{
					valor = value;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorDeParametroAdicionalInvalido(value, Nome), new StackTrace().GetFrame(1).GetMethod());
				}
			}
			else
			{
				valor = value;
			}
		}
	}

	public string Sigla => sigla;

	public string Ajuda => ajuda;

	public bool ValorDefinido => valorDefinido;

	public ArrayList ValoresDefinidos => valoresDefinidos;

	public string Mascara => mascara;

	public ParametroConfiguracao()
	{
		codigo = "";
		nome = "";
		sigla = "";
		valor = "";
		ajuda = "";
		mascara = "";
		valorPadrao = "";
		valorDefinido = false;
		valoresDefinidos = new ArrayList();
	}

	public ParametroConfiguracao(string codigo, string nome, string sigla, string ajuda, string mascara, string valorPadrao, ArrayList valoresPossiveis)
	{
		this.codigo = codigo;
		this.nome = nome;
		this.sigla = sigla;
		this.ajuda = ajuda;
		this.mascara = mascara;
		if (!string.IsNullOrEmpty(valorPadrao))
		{
			this.valorPadrao = valorPadrao;
			valor = valorPadrao;
		}
		else
		{
			this.valorPadrao = "";
			valor = "";
		}
		valoresDefinidos = new ArrayList();
		valorDefinido = false;
		if (valoresPossiveis != null && valoresPossiveis.Count > 0)
		{
			valorDefinido = true;
			valoresDefinidos = valoresPossiveis;
		}
	}

	public ParametroConfiguracao(Enum enumerado)
		: this()
	{
		codigo = enumerado.Codigo();
		nome = enumerado.Descricao();
		sigla = enumerado.Sigla();
		ajuda = enumerado.Ajuda();
		mascara = enumerado.Mascara();
		valor = enumerado.ValorPadrao();
		valoresDefinidos = enumerado.ValoresDefinidos();
		valorDefinido = enumerado.ValoresDefinidos().Count > 0;
	}

	public ParametroConfiguracao(SerializationInfo serobj, StreamingContext scontext)
	{
		codigo = (string)serobj.GetValue("Codigo", typeof(string));
		nome = (string)serobj.GetValue("Nome", typeof(string));
		sigla = (string)serobj.GetValue("Sigla", typeof(string));
		valor = (string)serobj.GetValue("Valor", typeof(string));
		ajuda = (string)serobj.GetValue("Ajuda", typeof(string));
		valorPadrao = (string)serobj.GetValue("ValorPadrao", typeof(string));
		mascara = (string)serobj.GetValue("Mascara", typeof(string));
		valorDefinido = (bool)serobj.GetValue("ValorDefinido", typeof(bool));
		valoresDefinidos = (ArrayList)serobj.GetValue("ValoresDefinidos", typeof(ArrayList));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Codigo", codigo);
		info.AddValue("Nome", nome);
		info.AddValue("Sigla", sigla);
		info.AddValue("Valor", valor);
		info.AddValue("Ajuda", ajuda);
		info.AddValue("ValorPadrao", valorPadrao);
		info.AddValue("ValorDefinido", valorDefinido);
		info.AddValue("Mascara", mascara);
		info.AddValue("ValoresDefinidos", valoresDefinidos);
	}
}
