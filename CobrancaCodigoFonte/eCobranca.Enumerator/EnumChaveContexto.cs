using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumChaveContexto
{
	[Description("Geral")]
	[AtributoDominio("001", null)]
	GERAL = 0,
	[Description("Contexto banco 001 e CBR641")]
	[AtributoDominio("002", null)]
	BAN001_CBR641 = 1,
	[Description("Contexto banco 001 e CBR643")]
	[AtributoDominio("003", null)]
	BAN001_CBR643 = 2,
	[Description("Contexto banco 001 e FEBRABAN240")]
	[AtributoDominio("004", null)]
	BAN001_FEBRABAN240 = 3,
	[Description("Contexto banco 003 e FEBRABAN150")]
	[AtributoDominio("019", null)]
	BAN003_FEBRABAN150 = 4,
	[Description("Contexto banco 003 e FEBRABAN240")]
	[AtributoDominio("033", null)]
	BAN003_FEBRABAN240 = 33,
	[Description("Contexto banco 003 e CNAB400")]
	[AtributoDominio("034", null)]
	BAN003_CNAB400 = 34,
	[Description("Contexto banco 004 e CNAB400")]
	[AtributoDominio("024", null)]
	BAN004_CNAB400 = 5,
	[Description("Contexto banco 004 e FEBRABAN240")]
	[AtributoDominio("025", null)]
	BAN004_FEBRABAN240 = 6,
	[Description("Contexto banco 021 e CNAB400")]
	[AtributoDominio("037", null)]
	BAN021_CNAB400 = 37,
	[Description("Contexto banco 004 e FEBRABAN240")]
	[AtributoDominio("038", null)]
	BAN021_FEBRABAN240 = 38,
	[Description("Contexto banco 033 e CNAB400")]
	[AtributoDominio("013", null)]
	BAN033_CNAB400 = 7,
	[Description("Contexto banco 033 e FEBRABAN240")]
	[AtributoDominio("014", null)]
	BAN033_FEBRABAN240 = 8,
	[Description("Contexto banco 037 e CNAB400")]
	[AtributoDominio("039", null)]
	BAN037_CNAB400 = 39,
	[Description("Contexto banco 037 e FEBRABAN240")]
	[AtributoDominio("040", null)]
	BAN037_FEBRABAN240 = 40,
	[Description("Contexto banco 041 e FEBRABAN240")]
	[AtributoDominio("017", null)]
	BAN041_FEBRABAN240 = 9,
	[Description("Contexto banco 041 e CNAB400")]
	[AtributoDominio("018", null)]
	BAN041_CNAB400 = 10,
	[Description("Contexto banco 084 e CNAB400")]
	[AtributoDominio("045", null)]
	BAN084_CNAB400 = 45,
	[Description("Contexto banco 084 e FEBRABAN240")]
	[AtributoDominio("046", null)]
	BAN084_FEBRABAN240 = 46,
	[Description("Contexto banco 085 e CNAB400")]
	[AtributoDominio("030", null)]
	BAN085_CNAB400 = 29,
	[Description("Contexto banco 085 e FEBRABAN240")]
	[AtributoDominio("031", null)]
	BAN085_FEBRABAN240 = 30,
	[Description("Contexto banco 097 e CNAB400")]
	[AtributoDominio("026", null)]
	BAN097_CNAB400 = 11,
	[Description("Contexto banco 097 e FEBRABAN240")]
	[AtributoDominio("027", null)]
	BAN097_FEBRABAN240 = 12,
	[Description("Contexto banco 099 e CNAB400")]
	[AtributoDominio("028", null)]
	BAN099_CNAB400 = 13,
	[Description("Contexto banco 099 e FEBRABAN240")]
	[AtributoDominio("029", null)]
	BAN099_FEBRABAN240 = 14,
	[Description("Contexto banco 104 e FEBRABAN240")]
	[AtributoDominio("009", null)]
	BAN104_FEBRABAN240 = 15,
	[Description("Contexto banco 104 e CNAB400")]
	[AtributoDominio("010", null)]
	BAN104_CNAB400 = 16,
	[Description("Contexto banco 133 e CNAB400")]
	[AtributoDominio("043", null)]
	BAN133_CNAB400 = 43,
	[Description("Contexto banco 133 e FEBRABAN240")]
	[AtributoDominio("044", null)]
	BAN133_FEBRABAN240 = 44,
	[Description("Contexto banco 136 e FEBRABAN240")]
	[AtributoDominio("039", null)]
	BAN136_FEBRABAN240 = 41,
	[Description("Contexto banco 136 e CNAB400")]
	[AtributoDominio("040", null)]
	BAN136_CNAB400 = 42,
	[Description("Contexto banco 237 e CNAB400")]
	[AtributoDominio("005", null)]
	BAN237_CNAB400 = 17,
	[Description("Contexto banco 237 e FEBRABAN240")]
	[AtributoDominio("006", null)]
	BAN237_FEBRABAN240 = 18,
	[Description("Contexto banco 237 UNICRED e FEBRABAN240")]
	[AtributoDominio("022", null)]
	BAN237_UNICRED_FEBRABAN240 = 19,
	[Description("Contexto banco 237 UNICRED e CNAB400")]
	[AtributoDominio("023", null)]
	BAN237_UNICRED_CNAB400 = 20,
	[Description("Contexto banco 237 CRESOL e CNAB400")]
	[AtributoDominio("035", null)]
	BAN237_CRESOL_CNAB400 = 35,
	[Description("Contexto banco 237 CRESOL e CNAB400")]
	[AtributoDominio("036", null)]
	BAN237_CRESOL_FEBRABAN240 = 36,
	[Description("Contexto banco 341 e CNAB400")]
	[AtributoDominio("007", null)]
	BAN341_CNAB400 = 21,
	[Description("Contexto banco 341 e FEBRABAN240")]
	[AtributoDominio("008", null)]
	BAN341_FEBRABAN240 = 22,
	[Description("Contexto banco 399 e FEBRABAN240")]
	[AtributoDominio("020", null)]
	BAN399_FEBRABAN240 = 23,
	[Description("Contexto banco 399 e CNAB400")]
	[AtributoDominio("021", null)]
	BAN399_CNAB400 = 24,
	[Description("Contexto banco 422 e FEBRABAN240")]
	[AtributoDominio("032", null)]
	BAN422_FEBRABAN240 = 31,
	[Description("Contexto banco 422 e CNAB400")]
	[AtributoDominio("033", null)]
	BAN422_CNAB400 = 32,
	[Description("Contexto banco 748 e FEBRABAN240")]
	[AtributoDominio("011", null)]
	BAN748_FEBRABAN240 = 25,
	[Description("Contexto banco 748 e CNAB400")]
	[AtributoDominio("012", null)]
	BAN748_CNAB400 = 26,
	[Description("Contexto banco 756 e CNAB400")]
	[AtributoDominio("015", null)]
	BAN756_CNAB400 = 27,
	[Description("Contexto banco 756 e FEBRABAN240")]
	[AtributoDominio("016", null)]
	BAN756_FEBRABAN240 = 28
}
