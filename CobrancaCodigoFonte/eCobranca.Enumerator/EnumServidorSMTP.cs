using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumServidorSMTP
{
	[Description("Gmail")]
	[AtributoDominio("01", "GMAIL", null)]
	[AtributoSMTP("smtp.gmail.com", 587, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	GMAIL,
	[Description("Hotmail")]
	[AtributoDominio("02", "HOTMAIL", null)]
	[AtributoSMTP("smtp.live.com", 25, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HOTMAIL,
	[Description("Yahoo")]
	[AtributoDominio("03", "YAHOO", null)]
	[AtributoSMTP("smtp.mail.yahoo.com.br", 465, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	YAHOO,
	[Description("Bol")]
	[AtributoDominio("04", "BOL", null)]
	[AtributoSMTP("smtps.bol.com.br", 465, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOL,
	[Description("iBest")]
	[AtributoDominio("05", "IBEST", null)]
	[AtributoSMTP("smtp.ibest.com.br", 465, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	IBEST,
	[Description("IG")]
	[AtributoDominio("06", "IG", null)]
	[AtributoSMTP("smtp.ig.com.br", 465, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	IG,
	[Description("Uol")]
	[AtributoDominio("07", "UOL", null)]
	[AtributoSMTP("smtps.uol.com.br", 465, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	UOL,
	[Description("Outros")]
	[AtributoDominio("08", "OUT", null)]
	[AtributoSMTP("", 0, true, true)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	OUTROS
}
