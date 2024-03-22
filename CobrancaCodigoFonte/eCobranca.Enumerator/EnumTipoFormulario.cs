using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoFormulario
{
	[Description("Auto-copiativo")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	AUTO_COPIATIVO,
	[Description("Auto-envelopável")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	AUTO_ENVELOPAVEL,
	[Description("A4 sem envelopamento")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	A4_SEM_ENVELOPAMENTO,
	[Description("A4 sem envelopamento 3 vias")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	A4_SEM_ENVELOPAMENTO_3_VIAS
}
