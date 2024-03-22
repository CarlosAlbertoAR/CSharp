using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoMoeda
{
	[Description("Real")]
	[AtributoDominio("A", "R$", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	REAL3,
	[Description("Real")]
	[AtributoDominio("0", "R$", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN004_CNAB400
	})]
	REAL6,
	[Description("Real")]
	[AtributoDominio("1", "R$", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	REAL2,
	[Description("Real")]
	[AtributoDominio("09", "R$", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN150
	})]
	REAL,
	[Description("Real")]
	[AtributoDominio("9", "R$", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	REAL4,
	[Description("Real")]
	[AtributoDominio("00", "R$", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400
	})]
	REAL5,
	[Description("Dólar americano comercial venda")]
	[AtributoDominio("02", "US$", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DOLAR_AMERICANO_COMERCIAL_VENDA,
	[Description("Dólar americano turismo venda")]
	[AtributoDominio("03", "US$", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	DOLAR_AMERICANO_TURISMO_VENDA,
	[Description("ITRD")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	ITRD,
	[Description("IDTR")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	IDTR,
	[Description("Ufir diária")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	UFIR_DIARIA,
	[Description("Ufir mensal")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	UFIR_MENSAL,
	[Description("FAJ TR")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	FAJ_TR,
	[Description("TR")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	TR,
	[Description("IGPM")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	IGPM,
	[Description("CDI")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	CDI,
	[Description("Percentual do CDI")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	PERCENTUAL_DO_CDI,
	[Description("Euro")]
	[AtributoDominio("14", "€", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	EURO
}
