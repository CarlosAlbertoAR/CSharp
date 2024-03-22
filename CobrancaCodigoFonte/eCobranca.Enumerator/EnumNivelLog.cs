using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumNivelLog
{
	[Description("Fatal")]
	[AtributoDominio("01", null)]
	FATAL,
	[Description("Error")]
	[AtributoDominio("02", null)]
	ERROR,
	[Description("Warning")]
	[AtributoDominio("03", null)]
	WARNING,
	[Description("Info")]
	[AtributoDominio("04", null)]
	INFO,
	[Description("Debug")]
	[AtributoDominio("05", null)]
	DEBUG
}
