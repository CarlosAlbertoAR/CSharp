using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumLayoutArquivoRemessa
{
	[Description("FEBRABAN240")]
	[AtributoDominio("01", "FEBRABAN240", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	FEBRABAN240,
	[Description("CNAB400")]
	[AtributoDominio("02", "CNAB400", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	CNAB400,
	[Description("CBR641")]
	[AtributoDominio("03", "CBR641", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	CBR641,
	[Description("FEBRABAN150")]
	[AtributoDominio("04", "FEBRABAN150", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN003_FEBRABAN150 })]
	FEBRABAN150
}
