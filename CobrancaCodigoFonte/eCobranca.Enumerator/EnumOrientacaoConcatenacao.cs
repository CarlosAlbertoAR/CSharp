using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumOrientacaoConcatenacao
{
	[Description("Concatenação horizontal")]
	[AtributoDominio("01", "HORIZONTAL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HORIZONTAL,
	[Description("Concatenação vertical")]
	[AtributoDominio("02", "VERTICAL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	VERTICAL
}
