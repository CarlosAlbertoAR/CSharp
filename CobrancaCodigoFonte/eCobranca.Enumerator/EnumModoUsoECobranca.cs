using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumModoUsoECobranca
{
	[Description("Demonstração")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	DEMONSTRACAO,
	[Description("Comercial")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	COMERCIAL
}
