using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumFormatoImagem
{
	[Description("PNG")]
	[AtributoDominio("01", "PNG", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	PNG,
	[Description("BMP")]
	[AtributoDominio("02", "BMP", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	BMP,
	[Description("GIF")]
	[AtributoDominio("03", "GIF", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	GIF,
	[Description("JPG")]
	[AtributoDominio("04", "JPG", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	JPG,
	[Description("TIF")]
	[AtributoDominio("05", "TIF", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.GERAL,
		EnumModoUsoECobranca.COMERCIAL,
		EnumModoUsoECobranca.DEMONSTRACAO
	})]
	TIF
}
