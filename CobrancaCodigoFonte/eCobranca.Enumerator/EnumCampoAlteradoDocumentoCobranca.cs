using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCampoAlteradoDocumentoCobranca
{
	[Description("Desconto")]
	[AtributoDominio("A", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DESCONTO,
	[Description("Juros por dia")]
	[AtributoDominio("B", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	JUROS_POR_DIA,
	[Description("Desconto por dia de antecipação")]
	[AtributoDominio("C", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DESCONTO_POR_DIA_ANTECIPACAO,
	[Description("Data limite para concessão de desconto")]
	[AtributoDominio("D", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DATA_LIMITE_CONCESSAO_DESCONTO,
	[Description("Cancelamento de protesto automático")]
	[AtributoDominio("E", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	CANCELAMENTO_PROTESTO_AUTOMATICO,
	[Description("Carteira de cobrança")]
	[AtributoDominio("F", new object[] { })]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	CARTEIRA_DE_COBRANCA
}
