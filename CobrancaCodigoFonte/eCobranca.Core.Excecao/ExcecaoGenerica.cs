using System;
using eCobranca.Enumerator;

namespace eCobranca.Core.Excecao;

public class ExcecaoGenerica : ExcecaoECobranca
{
	private EnumTipoExcecaoECobranca tipo;

	private string mensagemOriginal;

	private EnumCategoriaExcecao categoria;

	public EnumTipoExcecaoECobranca Tipo
	{
		get
		{
			return tipo;
		}
		set
		{
			tipo = value;
		}
	}

	public string MensagemOriginal => mensagemOriginal;

	public EnumCategoriaExcecao Categoria => categoria;

	public ExcecaoGenerica(int codigo, string mensagem, Exception innerException, EnumCategoriaExcecao categoria, EnumTipoExcecaoECobranca tipo)
		: base(codigo, mensagem, innerException)
	{
		this.tipo = tipo;
		if (innerException != null)
		{
			mensagemOriginal = innerException.Message;
			this.categoria = categoria;
		}
		else
		{
			mensagemOriginal = "";
			this.categoria = EnumCategoriaExcecao.GERAL;
		}
	}
}
