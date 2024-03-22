using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban001
{
	[Description("Registro detalhe - remessa - CNAB400")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	DETALHE,
	[Description("Registro detalhe opcional para envio de boleto por email - remessa - CNAB400")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	MENSAGEM_EMAIL,
	[Description("Registro detalhe opcional para envio multa - remessa - CNAB400")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	MENSAGEM_MULTA,
	[Description("Registro detalhe opcional para envio número do cedente - remessa - CNAB400")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	MENSAGEM_NUMERO_CEDENTE
}
