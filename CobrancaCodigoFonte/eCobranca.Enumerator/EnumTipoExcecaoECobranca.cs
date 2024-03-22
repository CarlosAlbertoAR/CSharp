using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoExcecaoECobranca
{
	[Description("Warning")]
	[AtributoDominio("01", "W", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	WARNING,
	[Description("Error")]
	[AtributoDominio("02", "E", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	ERROR,
	[Description("Fatal")]
	[AtributoDominio("03", "F", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	FATAL
}
