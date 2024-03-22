using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoDesconto
{
	[Description("Valor fixo")]
	[AtributoDominio("F", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	VALOR_FIXO = 10,
	[Description("Porcentagem")]
	[AtributoDominio("P", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PORCENTAGEM = 11,
	[Description("Isento")]
	[AtributoDominio("I", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	ISENTO = 12,
	[Description("Valor")]
	[AtributoDominio("A", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	VALOR = 0,
	[Description("Percentual")]
	[AtributoDominio("B", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	PERCENTUAL = 1,
	[Description("Sem desconto")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	SEM_DESCONTO = 2,
	[Description("Sem desconto")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	SEM_DESCONTO2 = 13,
	[Description("Valor fixo até a data informada")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN150,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	VALOR_FIXO_ATE_A_DATA_INFORMADA = 3,
	[Description("Valor fixo até a data informada")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	VALOR_FIXO_ATE_A_DATA_INFORMADA2 = 14,
	[Description("Percentual até a data informada")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PERCENTUAL_ATE_A_DATA_INFORMADA = 4,
	[Description("Valor por antecipação dia corrido")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	VALOR_POR_ANTECIPACAO_DIA_CORRIDO = 5,
	[Description("Valor por antecipação dia útil")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	VALOR_POR_ANTECIPACAO_DIA_UTIL = 6,
	[Description("Percentual sobre o valor nominal dia corrido")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	PERCENTUAL_SOBRE_O_VALOR_NOMINAL_DIA_CORRIDO = 7,
	[Description("Percentual sobre o valor nominal dia útil")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	PERCENTUAL_SOBRE_O_VALOR_NOMINAL_DIA_UTIL = 8,
	[Description("Cancelamento de desconto")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CANCELAMENTO_DE_DESCONTO = 9
}
