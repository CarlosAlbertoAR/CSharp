using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoEnvioProtesto
{
	[Description("Cartório")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	CARTORIO,
	[Description("Serasa")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	SERASA,
	[Description("Nenhum")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	NENHUM
}
