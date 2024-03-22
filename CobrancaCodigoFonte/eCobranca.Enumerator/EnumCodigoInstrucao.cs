using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoInstrucao
{
	[Description("Sem Instruções – Acata as instruções da Carteira do Cedente")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	SEM_INSTRUCOES,
	[Description("Acatar instruções contidas no título")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ACATAR_INSTRUCOES,
	[Description("Não cobrar encargos monetários")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	NAO_COBRAR_ENCARGOS_MONETARIOS,
	[Description("Não receber após vencimento")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	NAO_RECEBER_APOS_VENCIMENTO,
	[Description("Após vencimento, cobrar comissão de permanência do BANCO DO NORDESTE")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	APOS_VENCIMENTO_COBRAR_COMISSAO_PERMANENCIA
}
