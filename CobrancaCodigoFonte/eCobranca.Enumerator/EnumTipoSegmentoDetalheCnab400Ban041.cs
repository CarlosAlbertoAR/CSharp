using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban041
{
	[Description("Registro detalhe de transação tipo 1 - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TRANSACAO_TIPO_1_DADOS_TITULO,
	[Description("Registro detalhe de transação tipo 1 - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TRANSACAO_TIPO_1_DADOS_SACADOR,
	[Description("Registro detalhe de transação tipo 2 - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TRANSACAO_TIPO_2_MENSAGEM,
	[Description("Registro detalhe de transação tipo 3 - remessa - CNAB400")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TRANSACAO_TIPO_3_RATEIO_CREDITO
}
