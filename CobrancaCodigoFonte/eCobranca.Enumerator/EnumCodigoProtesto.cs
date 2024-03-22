using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoProtesto
{
	[Description("Assumir configuração definida no banco")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	ASSUMIR_DEFINICAO_BANCO = 28,
	[Description("Não há instruções")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	NAO_HA_INSTRUCOES = 0,
	[Description("Não protestar")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NAO_PROTESTAR2 = 1,
	[Description("Não protestar")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240
	})]
	NAO_PROTESTAR3 = 2,
	[Description("Protestar dias corridos")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN150,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_DIAS_CORRIDOS = 3,
	[Description("Protestar dias corridos")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	PROTESTAR_DIAS_CORRIDOS4 = 24,
	[Description("Protestar dias corridos")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	PROTESTAR_DIAS_CORRIDOS2 = 4,
	[Description("Protestar dias úteis")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_DIAS_UTEIS2 = 18,
	[Description("Protestar dias úteis")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	PROTESTAR_DIAS_UTEIS = 5,
	[Description("Protestar dias corridos")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_DIAS_CORRIDOS3 = 19,
	[Description("Negaticação de boletos via Serasa")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	NEGATIVACAO_BOLETOS_VIA_SERASA = 25,
	[Description("Devolver (Não protestar)")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	DEVOLVER_NAO_PROTESTAR = 6,
	[Description("Não protestar")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NAO_PROTESTAR = 7,
	[Description("Utilizar perfil cedente")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	UTILIZAR_PERFIL_CEDENTE = 8,
	[Description("Protestar fim falimentar - dias úteis")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240
	})]
	PROTESTAR_FIM_FALIMENTAR_DIAS_UTEIS = 9,
	[Description("Negativar dias corridos")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	NEGATIVAR_DIAS_CORRIDOS2 = 20,
	[Description("Negativar dias úteis")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	NEGATIVAR_DIAS_UTEIS = 21,
	[Description("Protestar fim falimentar - dias corridos")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240
	})]
	PROTESTAR_FIM_FALIMENTAR_DIAS_CORRIDOS = 10,
	[Description("Protesto falimentar")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	PROTESTO_FALIMENTAR = 11,
	[Description("Não negativar")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	NAO_NAGATIVAR = 22,
	[Description("Protesto normal")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN033_CNAB400
	})]
	PROTESTO_NORMAL = 12,
	[Description("Negativar automaticamente")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	NEGATIVAR_AUTOMATICAMENTE2 = 30,
	[Description("Não protestar")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	NAO_PROTESTAR4 = 13,
	[Description("Negativar")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	NEGATIVAR = 23,
	[Description("Negativar dias corridos")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	NEGATIVAR_DIAS_CORRIDOS = 14,
	[Description("Negativação sem protesto")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NEGATIVACAO_SEM_PROTESTO = 15,
	[Description("Não negativar")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	NAO_NEGATIVAR = 16,
	[Description("Negativar automaticamente")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_FEBRABAN240 })]
	NEGATIVAR_AUTOMATICAMENTE = 29,
	[Description("Cancelamento protesto automático")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CANCELAMENTO_PROTESTO_AUTOMATICO = 17,
	[Description("Protestar títulos por dias corridos")]
	[AtributoDominio("P6", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	PROTESTAR_DIAS_CORRIDOS5 = 26,
	[Description("Não protestar")]
	[AtributoDominio("P7", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	NAO_PROTESTAR5 = 27
}
