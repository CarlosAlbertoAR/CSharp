using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban748
{
	[Description("Registro detalhe - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	REGISTRO_TIPO_1,
	[Description("Registro mensagem - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	REGISTRO_TIPO_2,
	[Description("Registro sacador/avalista - remessa - CNAB400")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	REGISTRO_TIPO_6,
	[Description("Registro de descontos - remessa - CNAB400")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	REGISTRO_TIPO_7
}
