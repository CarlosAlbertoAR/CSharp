using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoJuros
{
	[Description("Valor")]
	[AtributoDominio("A", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	VALOR = 0,
	[Description("Valor fixo")]
	[AtributoDominio("F", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	VALOR_FIXO = 15,
	[Description("Porcentagem")]
	[AtributoDominio("P", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PORCENTAGEM2 = 16,
	[Description("Isento")]
	[AtributoDominio("I", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	ISENTO4 = 17,
	[Description("Percentual")]
	[AtributoDominio("B", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	PERCENTUAL = 1,
	[Description("Isento")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_COM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN756_CAUCIONADA_GARANTIDA,
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_SEM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ISENTO2 = 2,
	[Description("Valor diário")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN041_CNAB400
	})]
	VALOR_DIARIO = 3,
	[Description("Valor por dia")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_COM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN756_CAUCIONADA_GARANTIDA,
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_SEM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN150,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_POR_DIA = 4,
	[Description("Taxa mensal")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN097_CNAB400
	})]
	TAXA_MENSAL2 = 5,
	[Description("Isento")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ISENTO3 = 6,
	[Description("Taxa mensal")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_COM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN756_CAUCIONADA_GARANTIDA,
		EnumTipoCarteiraCobranca.BAN756_SIMPLES_SEM_REGISTRO,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400
	})]
	TAXA_MENSAL = 7,
	[Description("Valor")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	VALOR2 = 9,
	[Description("Isento")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ISENTO = 10,
	[Description("Porcentagem")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PORCENTAGEM = 11,
	[Description("Utilizar comissão permanência do banco por dia de atraso")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400
	})]
	COMISSAO_PERMANENCIA_BANCO = 12,
	[Description("Tolerância valor por dia")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	TOLERANCIA_VALOR_POR_DIA = 13,
	[Description("Isento")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN136_CNAB400 })]
	ISENTO5 = 19,
	[Description("Tolerância taxa mensal")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	TOLERANCIA_TAXA_MENSAL = 14,
	[Description("Assumir configuração definida no banco")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	CONFIGURACAO_BANCO = 18
}
