using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoCarencia
{
	[Description("Dias úteis")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	DIAS_UTEIS,
	[Description("Dias corridos")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	DIAS_CORRIDOS
}
