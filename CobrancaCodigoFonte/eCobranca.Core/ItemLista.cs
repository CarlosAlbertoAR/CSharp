using System;
using System.Runtime.Serialization;

namespace eCobranca.Core;

[Serializable]
public class ItemLista : ISerializable
{
	private string codigo;

	private string descricao;

	private string sigla;

	private string valor;

	private string ajuda;

	public string Codigo => codigo;

	public string Descricao => descricao;

	public string Sigla => sigla;

	public string Ajuda => ajuda;

	public string Valor => valor;

	public ItemLista(string codigo, string descricao, string sigla, string ajuda, string valor)
	{
		this.codigo = codigo;
		this.descricao = descricao;
		this.sigla = sigla;
		this.valor = valor;
		this.ajuda = ajuda;
	}

	public ItemLista(SerializationInfo serobj, StreamingContext scontext)
	{
		codigo = (string)serobj.GetValue("Codigo", typeof(string));
		descricao = (string)serobj.GetValue("Descricao", typeof(string));
		sigla = (string)serobj.GetValue("Sigla", typeof(string));
		valor = (string)serobj.GetValue("Valor", typeof(string));
		ajuda = (string)serobj.GetValue("Ajuda", typeof(string));
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Codigo", codigo);
		info.AddValue("Descricao", descricao);
		info.AddValue("Sigla", sigla);
		info.AddValue("Valor", valor);
		info.AddValue("Ajuda", ajuda);
	}
}
