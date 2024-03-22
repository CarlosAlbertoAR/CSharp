using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban422
{
	[Description("Registro detalhe de transação tipo 1 - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TRANSACAO_TIPO_1,
	[Description("Registro detalhe de transação tipo 2 - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TRANSACAO_TIPO_2
}
