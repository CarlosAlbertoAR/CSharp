using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban237
{
	[Description("Registro detalhe de transação tipo 1 - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	TRANSACAO_TIPO_1,
	[Description("Registro detalhe de transação tipo 2 - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	TRANSACAO_TIPO_2,
	[Description("Registro detalhe de transação tipo 3 - remessa - CNAB400")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	TRANSACAO_TIPO_3,
	[Description("Registro detalhe de transação tipo 7 - remessa - CNAB400")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	TRANSACAO_TIPO_7
}
