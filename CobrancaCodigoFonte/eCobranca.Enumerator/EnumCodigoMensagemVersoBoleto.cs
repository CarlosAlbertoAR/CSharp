using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoMensagemVersoBoleto
{
	[Description("Não imprime mensagem no verso do boleto")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	NAO_IMPRIME_MENSAGEM_NO_VERSO,
	[Description("Imprime mensagem no verso do boleto")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	IMPRIME_MENSAGEM_NO_VERSO
}
