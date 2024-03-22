using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoDocumentoCobranca
{
	[Description("CCB")]
	[AtributoDominio("AA", "AA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	AA = 0,
	[Description("Cobrança direta")]
	[AtributoDominio("AB", "AB", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	AB = 1,
	[Description("Cobrança escritural")]
	[AtributoDominio("AC", "AC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	AC = 2,
	[Description("Títulos de terceiros")]
	[AtributoDominio("AD", "AD", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	AD = 3,
	[Description("Duplicata mercantil por indicação")]
	[AtributoDominio("A", "DMI", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DMI2 = 4,
	[Description("Duplicata rural")]
	[AtributoDominio("B", "DR", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DR2 = 5,
	[Description("Nota promissória")]
	[AtributoDominio("C", "NP", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	NP3 = 6,
	[Description("Nota promissória rural")]
	[AtributoDominio("D", "NR", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	NR = 7,
	[Description("Nota de seguros")]
	[AtributoDominio("E", "NS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	NS4 = 8,
	[Description("Recibo")]
	[AtributoDominio("G", "RC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	RC3 = 9,
	[Description("Letra de câmbio")]
	[AtributoDominio("H", "LC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	LC6 = 10,
	[Description("Nota de débito")]
	[AtributoDominio("I", "ND", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	ND4 = 11,
	[Description("Duplicata de serviço por indicação")]
	[AtributoDominio("J", "DSI", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	DSI2 = 12,
	[Description("Outros")]
	[AtributoDominio("K", "OS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	OUT2 = 13,
	[Description("Duplicata mercantil")]
	[AtributoDominio("01", "DM", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	DM2 = 14,
	[Description("Duplicata mercantil")]
	[AtributoDominio("02", "DM", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	DM = 15,
	[Description("Cheque")]
	[AtributoDominio("01", "CH", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CH = 16,
	[Description("Nota promissória")]
	[AtributoDominio("02", "NP", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	NP2 = 17,
	[Description("Duplicata mercantil p/ indicação")]
	[AtributoDominio("03", "DMI", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DMI = 18,
	[Description("Nota de seguro")]
	[AtributoDominio("03", "NS", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	NS2 = 19,
	[Description("Duplicata de prestação de serviço")]
	[AtributoDominio("03", "DS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	DS2 = 20,
	[Description("Bilhete de seguro")]
	[AtributoDominio("03", "BSE", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	BSE = 21,
	[Description("Cheque")]
	[AtributoDominio("03", "CH", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	CHQ = 22,
	[Description("Duplicata de Serviço")]
	[AtributoDominio("04", "DS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	DS = 23,
	[Description("Cobrança seriada")]
	[AtributoDominio("04", "CS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400
	})]
	CS = 24,
	[Description("Cobrança direta")]
	[AtributoDominio("04", "CDI", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	CDI = 25,
	[Description("Mensalidade escolar")]
	[AtributoDominio("04", "ME", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	ME = 26,
	[Description("Carnê")]
	[AtributoDominio("04", "CAR", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	CARNE = 27,
	[Description("Duplicata mercantil p/ indicação")]
	[AtributoDominio("04", "DMI", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	DMI3 = 28,
	[Description("Duplicata de serviço p/ indicação")]
	[AtributoDominio("05", "DSI", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DSI = 29,
	[Description("Nota de seguro")]
	[AtributoDominio("05", "NS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	NS3 = 30,
	[Description("Recibo")]
	[AtributoDominio("05", "RC", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	RC2 = 31,
	[Description("Recibo")]
	[AtributoDominio("05", "REC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400
	})]
	RC4 = 32,
	[Description("Duplicata Rural")]
	[AtributoDominio("06", "DR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DR = 33,
	[Description("Contrato")]
	[AtributoDominio("06", "CT", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CT = 34,
	[Description("Letra de câmbio")]
	[AtributoDominio("06", "LC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN104_CNAB400
	})]
	LC2 = 35,
	[Description("Duplicata de serviço")]
	[AtributoDominio("06", "DS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN033_CNAB400
	})]
	LC7 = 36,
	[Description("Cobrança escritural")]
	[AtributoDominio("06", "CES", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	CES = 37,
	[Description("Cosseguros")]
	[AtributoDominio("07", "COS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	COS = 38,
	[Description("Letra de câmbio")]
	[AtributoDominio("07", "LC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	LC = 39,
	[Description("Nota de crédito comercial")]
	[AtributoDominio("08", "NCC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NCC = 40,
	[Description("Letra de câmbio")]
	[AtributoDominio("08", "LC", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400
	})]
	LC3 = 41,
	[Description("Duplicata de serviço")]
	[AtributoDominio("08", "DS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DS3 = 42,
	[Description("CCB com registro")]
	[AtributoDominio("08", "CCB", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	CCB = 43,
	[Description("Nota de crédito a exportação")]
	[AtributoDominio("09", "NCE", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NCE = 44,
	[Description("Letra de câmbio")]
	[AtributoDominio("09", "LC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	LC4 = 45,
	[Description("Outros")]
	[AtributoDominio("09", "OU", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN104_CNAB400
	})]
	OU = 46,
	[Description("Warrant")]
	[AtributoDominio("09", "WAR", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN756_CNAB400 })]
	WAR = 47,
	[Description("Títulos de terceiros")]
	[AtributoDominio("09", "TTE", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TTE = 48,
	[Description("Duplicata de serviços")]
	[AtributoDominio("09", "DDS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DDS = 89,
	[Description("Nota de crédito industrial")]
	[AtributoDominio("10", "NCI", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NCI = 49,
	[Description("Cheque")]
	[AtributoDominio("10", "CH", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	CH2 = 50,
	[Description("Letra de câmbio")]
	[AtributoDominio("10", "LC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400
	})]
	LC5 = 51,
	[Description("Nota de crédito rural")]
	[AtributoDominio("11", "NCR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NCR = 52,
	[Description("Nota de débito")]
	[AtributoDominio("11", "ND", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400
	})]
	ND3 = 53,
	[Description("Nota promissória")]
	[AtributoDominio("12", "NP", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NP = 54,
	[Description("Duplicata de serviço")]
	[AtributoDominio("12", "DS", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	DS4 = 55,
	[Description("Nota promissória rural")]
	[AtributoDominio("13", "NPR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NPR = 56,
	[Description("Nota de débito")]
	[AtributoDominio("13", "ND", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	ND2 = 57,
	[Description("Triplicata mercantil")]
	[AtributoDominio("14", "TM", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TM = 58,
	[Description("Triplicata de serviço")]
	[AtributoDominio("15", "TS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TS = 59,
	[Description("Apólice de seguro")]
	[AtributoDominio("15", "AP", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400
	})]
	AP2 = 60,
	[Description("Documentos de dívida")]
	[AtributoDominio("15", "DD", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DD2 = 61,
	[Description("Nota de seguro")]
	[AtributoDominio("16", "NS", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NS = 62,
	[Description("Encargos condominiais")]
	[AtributoDominio("16", "EC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	EC2 = 63,
	[Description("Recibo")]
	[AtributoDominio("17", "RC", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	RC = 64,
	[Description("Conta de prestação de serviços")]
	[AtributoDominio("17", "CPS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CPS = 65,
	[Description("Fatura")]
	[AtributoDominio("18", "FAT", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	FAT = 66,
	[Description("Nota de débito")]
	[AtributoDominio("19", "ND", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ND = 67,
	[Description("Outros")]
	[AtributoDominio("19", "OU", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	OUTROS = 68,
	[Description("Apólice de seguro")]
	[AtributoDominio("20", "AP", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	AP = 69,
	[Description("Mensalidade escolar")]
	[AtributoDominio("21", "ME", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ME2 = 70,
	[Description("Parcela de consórcio")]
	[AtributoDominio("22", "PC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PC = 71,
	[Description("Nota fiscal")]
	[AtributoDominio("23", "NF", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	NF = 72,
	[Description("Documento de dívida")]
	[AtributoDominio("24", "DD", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DD = 73,
	[Description("Cédula de produto rural")]
	[AtributoDominio("25", "CPR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CPR = 74,
	[Description("Dívida ativa da união")]
	[AtributoDominio("25", "DAU", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400
	})]
	DAU2 = 75,
	[Description("Warrant")]
	[AtributoDominio("26", "WA", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	WA = 76,
	[Description("Dívida ativa de estado")]
	[AtributoDominio("26", "DAE", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400
	})]
	DAE2 = 77,
	[Description("Dívida ativa de estado")]
	[AtributoDominio("27", "DAE", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DAE = 78,
	[Description("Dívida ativa de município")]
	[AtributoDominio("27", "DAM", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN097_CNAB400
	})]
	DAM2 = 79,
	[Description("Dívida ativa de município")]
	[AtributoDominio("28", "DAM", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DAM = 80,
	[Description("Dívida ativa da união")]
	[AtributoDominio("29", "DAU", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DAU = 81,
	[Description("Encargos condominais")]
	[AtributoDominio("30", "EC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EC = 82,
	[Description("Cartão de crédito")]
	[AtributoDominio("30", "CC", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CC = 83,
	[Description("Boleto de Proposta")]
	[AtributoDominio("32", "BDP", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BDP = 88,
	[Description("Cheque")]
	[AtributoDominio("97", "CH", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	CH3 = 84,
	[Description("Nota promissória direta")]
	[AtributoDominio("98", "ND", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	ND5 = 85,
	[Description("Cobrança diretiva")]
	[AtributoDominio("98", "PD", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	PD = 86,
	[Description("Outros")]
	[AtributoDominio("99", "OUT", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	OUT = 87
}
