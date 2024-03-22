using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoBaixaDevolucao
{
	[Description("Não há instruções")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	NAO_HA_INSTRUCOES,
	[Description("Não baixar/devolver")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	NAO_BAIXAR_NAO_DEVOLVER2,
	[Description("Sem instrução")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	SEM_INSTRUCAO,
	[Description("Baixar/devolver")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN150
	})]
	BAIXAR_DEVOLVER,
	[Description("Baixar após n dias")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	BAIXAR_APOS_N_DIAS,
	[Description("Não baixar/devolver")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NAO_BAIXAR_NAO_DEVOLVER,
	[Description("Baixar após 365 dias do vencimento")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	BAIXAR_APOS_365_DIAS,
	[Description("Baixar após 15 dias do vencimento")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	BAIXAR_APOS_15_DIAS_VENCIMENTO,
	[Description("Cancelar prazo para baixa/devolução")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	CANCELAR_PRAZO_PARA_BAIXA_DEVOLUCAO,
	[Description("Utilizar perfil cedente")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	UTILIZAR_PERFIL_CEDENTE,
	[Description("Baixar após 30 dias do vencimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	BAIXAR_APOS_30_DIAS_VENCIMENTO,
	[Description("Baixar/devolver")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DECURSO_DE_PRAZO,
	[Description("Não baixar")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	NAO_BAIXAR
}
