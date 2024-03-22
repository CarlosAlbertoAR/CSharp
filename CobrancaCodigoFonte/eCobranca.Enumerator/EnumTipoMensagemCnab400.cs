using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoMensagemCnab400
{
	[Description("Mensagem de multa")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	MENSAGEM_MULTA,
	[Description("Mensagem de juros")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	MENSAGEM_JUROS,
	[Description("Mensagem de desconto")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	MENSAGEM_DESCONTO,
	[Description("Mensagem de protesto")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	MENSAGEM_PROTESTO
}
