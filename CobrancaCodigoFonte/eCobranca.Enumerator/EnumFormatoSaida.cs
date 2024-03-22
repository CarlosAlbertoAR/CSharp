using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumFormatoSaida
{
	[Description("Arquivo PDF")]
	[AtributoDominio("01", "PDF", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	PDF,
	[Description("Arquivo HTML")]
	[AtributoDominio("02", "HTML", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	HTML,
	[Description("Arquivo de Imagem")]
	[AtributoDominio("03", "IMAGEM", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	IMAGEM,
	[Description("Arquivo de Imagem rotacionada")]
	[AtributoDominio("04", "IMAGEM", null)]
	IMAGEM_ROTACIONADA
}
