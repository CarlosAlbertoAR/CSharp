using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumInstrucaoCobranca
{
	[Description("Ausência de instruções")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	AUSENCIA_DE_INSTRUCOES = 0,
	[Description("Protestar 5 dias úteis")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_5_DIAS_UTEIS = 1,
	[Description("Cobrar juros")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	COBRAR_JUROS = 2,
	[Description("Protestar dias corridos")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN104_CNAB400
	})]
	PROTESTAR_DIAS_CORRIDOS = 3,
	[Description("Não receber principal, sem juros de mora")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN422_CNAB400
	})]
	NAO_RECEBER_PRINCIPAL_SEM_JUROS = 108,
	[Description("Devolver após 05 dias do vencimento")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_05_DIAS_DO_VENCIMENTO = 4,
	[Description("Devolver (não protestar)")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN104_CNAB400
	})]
	DEVOLVER_NAO_PROTESTAR = 5,
	[Description("Baixar após quinze dias do vencimento")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	BAIXAR_APOS_QUINZE_DIAS_VENCIMENTO = 6,
	[Description("Protestar 3 dias úteis após vencimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_3_DIAS_UTEIS_APOS_VENCIMENTO = 7,
	[Description("Devolver após 30 dias do vencimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	DEVOLVER_APOS_30_DIAS_DO_VENCIMENTO = 8,
	[Description("Baixar após trinta dias do vencimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN033_CNAB400
	})]
	BAIXAR_APOS_TRINTA_DIAS_VENCIMENTO = 9,
	[Description("Protestar 4 dias úteis após vencimento")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_4_DIAS_UTEIS_APOS_VENCIMENTO = 10,
	[Description("Não baixar")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN033_CNAB400
	})]
	NAO_BAIXAR = 11,
	[Description("Protestar 5 dias úteis após vencimento")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_5_DIAS_UTEIS_APOS_VENCIMENTO = 12,
	[Description("Receber conforme instruções no próprio título")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	RECEBER_CONFORME_INSTRUCOES_NO_PROPRIO_TITULO = 13,
	[Description("Protesto falimentar")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	PROTESTO_FALIMENTAR = 14,
	[Description("Protesto em dias corridos, com prazo de 6 a 29, 35 ou 40 dias corridos")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTO_EM_DIAS_CORRIDOS = 15,
	[Description("Devolver após 10 dias do vencimento")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_10_DIAS_DO_VENCIMENTO = 16,
	[Description("Protestar")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PROTESTAR = 17,
	[Description("Não protestar")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	NAO_PROTESTAR = 18,
	[Description("Devolver após 15 dias do vencimento")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_15_DIAS_DO_VENCIMENTO = 19,
	[Description("Devolver após 20 dias do vencimento")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_20_DIAS_DO_VENCIMENTO = 20,
	[Description("Não cobrar juros de mora")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	NAO_COBRAR_JUROS_DE_MORA = 21,
	[Description("Protestar")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN341_CNAB400
	})]
	PROTESTAR2 = 22,
	[Description("Não receber após vencimento")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	NAO_RECEBER_APOS_VENCIMENTO = 23,
	[Description("Protestar 10 dias corridos após vencimento")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_10_DIAS_CORRIDOS_APOS_VENCIMENTO = 24,
	[Description("Protestar 10 dias úteis após vencimento")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_10_DIAS_UTEIS_APOS_VENCIMENTO = 25,
	[Description("Não protestar")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_PROTESTAR2 = 26,
	[Description("Multas de 10% após o 4º dia do vencimento")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	MULTAS_DE_10_PORCENTO_APOS_4_DIA_VENCIMENTO = 27,
	[Description("Devolver após 25 dias do vencimento")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_25_DIAS_DO_VENCIMENTO = 28,
	[Description("Não receber após o 8º dia do vencimento")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	NAO_RECEBER_APOS_8_DIA_DO_VENCIMENTO = 29,
	[Description("Devolver após 35 dias do vencimento")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_35_DIAS_DO_VENCIMENTO = 30,
	[Description("Cobrar encargos após o 5º dia do vencimento")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	COBRAR_ENCARGOSD_APOS_5_DIA_DO_VENCIMENTO = 31,
	[Description("Devolver após 40 dias do vencimento")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_40_DIAS_DO_VENCIMENTO = 32,
	[Description("Cobrar encargos após 10º dia do vencimento")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	COBRAR_ENCARGOS_APOS_10_DIAS_DO_VENCIMENTO = 33,
	[Description("Devolver após 45 dias do vencimento")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_45_DIAS_DO_VENCIMENTO = 34,
	[Description("Cobrar encargos após 15º dia do vencimento")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	COBRAR_ENCARGOS_APOS_15_DIAS_DO_VENCIMENTO = 35,
	[Description("Protestar 15 dias corridos após vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_15_DIAS_CORRIDOS_APOS_VENCIMENTO = 36,
	[Description("Protestar 15 dias úteis após vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_15_DIAS_UTEIS_APOS_VENCIMENTO = 37,
	[Description("Devolver após 50 dias do vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_50_DIAS_DO_VENCIMENTO = 38,
	[Description("Devolver após NN dias do vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	DEVOLVER_APOS_NN_DIAS = 39,
	[Description("Conceder desconto mesmo se pago após vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	CONCEDER_DESCONTO_MESMO_SE_PAGO_APOS_VENCIMENTO = 40,
	[Description("Devolver após 55 dias do vencimento")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_55_DIAS_DO_VENCIMENTO = 41,
	[Description("Multa")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	MULTA = 109,
	[Description("Devolver após 60 dias do vencimento")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_60_DIAS_DO_VENCIMENTO = 42,
	[Description("Devolver após 90 dias do vencimento")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_90_DIAS_DO_VENCIMENTO = 43,
	[Description("Decurso de prazo")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	DECURSO_DE_PRAZO = 44,
	[Description("Cobrar multa (valor/percentual) após NN dias do vencimento")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	COBRAR_MULTA_APOS_VENCIMENTO = 45,
	[Description("Não receber após 05 dias do vencimento")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_05_DIAS_DO_VENCIMENTO = 46,
	[Description("Protestar 20 dias corridos após vencimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_20_DIAS_CORRIDOS_APOS_VENCIMENTO = 47,
	[Description("Protestar 20 dias úteis após vencimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN756_CNAB400
	})]
	PROTESTAR_20_DIAS_UTEIS_APOS_VENCIMENTO = 48,
	[Description("Não receber após 10 dias do vencimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_10_DIAS_DO_VENCIMENTO = 49,
	[Description("Cobrar multa (valor/percentual) ao mês ou fração após NN dias do vencimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	COBRAR_MULTA_AO_MES_APOS_VENCIMENTO = 50,
	[Description("Não receber após 15 dias do vencimento")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_15_DIAS_DO_VENCIMENTO = 51,
	[Description("Conceder desconto apenas até a data estipulada")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	CONCEDER_DESCONTO_SO_ATE_DATA_ESTIPULADA = 52,
	[Description("Não receber após 20 dias do vencimento")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_20_DIAS_DO_VENCIMENTO = 53,
	[Description("Não receber após 25 dias do vencimento")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_25_DIAS_DO_VENCIMENTO = 54,
	[Description("Não protestar")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	NAO_PROTESTAR3 = 55,
	[Description("Não receber após 30 dias do vencimento")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_30_DIAS_DO_VENCIMENTO = 56,
	[Description("Protestar 25 dias corridos após vencimento")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_25_DIAS_CORRIDOS_APOS_VENCIMENTO = 57,
	[Description("Não receber após 35 dias do vencimento")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_35_DIAS_DO_VENCIMENTO = 58,
	[Description("Não receber após 40 dias do vencimento")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_40_DIAS_DO_VENCIMENTO = 59,
	[Description("Não receber após 45 dias do vencimento")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_45_DIAS_DO_VENCIMENTO = 60,
	[Description("Não receber após 50 dias do vencimento")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_50_DIAS_DO_VENCIMENTO = 61,
	[Description("Não receber após 55 dias do vencimentoo")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_55_DIAS_DO_VENCIMENTO = 62,
	[Description("Protestar 30 dias corridos após vencimento")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_30_DIAS_CORRIDOS_APOS_VENCIMENTO = 63,
	[Description("Importância de desconto por dia")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	IMPORTANCIA_DE_DESCONTO_POR_DIA = 64,
	[Description("Não receber após 60 dias do vencimento")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_60_DIAS_DO_VENCIMENTO = 65,
	[Description("Não receber após 90 dias do vencimento")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_90_DIAS_DO_VENCIMENTO = 66,
	[Description("Conceder abatimento referente à PIS PASEP, COFIN ou CSSL mesmo após vencimento")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CONCEDER_ABATIMENTO_REF_PISPASEP_COFIN_CSSL_MESMO_APOS_VENCIMENTO = 67,
	[Description("Protestar após XX dias corridos do vencimento")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	PROTESTAR_APOS_XX_DIAS_CORRIDOS_DO_VENCIMENTO = 68,
	[Description("Protestar 35 dias corridos após vencimento")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_35_DIAS_CORRIDOS_APOS_VENCIMENTO = 69,
	[Description("Protestar após XX dias úteis do vencimento")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	PROTESTAR_APOS_XX_DIAS_UTEIS_DO_VENCIMENTO = 70,
	[Description("Receber até o último dia do mês de vencimento")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	RECEBER_ATE_O_ULTIMO_DIA_DO_MES_DE_VENCIMENTO = 71,
	[Description("Conceder desconto mesmo após vencimento")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CONCEDER_DESCONTO_MESMO_APOS_VENCIMENTO = 72,
	[Description("Não receber após vencimento")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_O_VENCIMENTO = 73,
	[Description("Conceder desconto conforme note de crédito")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CONCEDER_DESCONTO_CONFORME_NOTA_DE_CREDITO = 74,
	[Description("Protestar 40 dias corridos após vencimento")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_40_DIAS_CORRIDOS_APOS_VENCIMENTO = 75,
	[Description("Devolver")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PEDIDO_DE_BAIXA,
		EnumChaveContexto.BAN001_CBR641
	})]
	DEVOLVER = 76,
	[Description("Devolver após 15 dias vencido")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN756_CNAB400
	})]
	DEVOLVER_APOS_15_DIAS_VENCIDO = 77,
	[Description("Protestar para fins falimentares")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	PROTESTO_PARA_FINS_FALIMENTARES = 78,
	[Description("Sujeito a protesto se não for pago no vencimento")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	SUJEITO_A_PROTESTO_SE_NAO_FOR_PAGO_NO_VENCIMENTO = 79,
	[Description("Devolver após 30 dias vencido")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumChaveContexto.BAN756_CNAB400
	})]
	DEVOLVER_APOS_30_DIAS_VENCIDO = 80,
	[Description("Baixar")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PEDIDO_DE_BAIXA,
		EnumChaveContexto.BAN001_CBR641
	})]
	BAIXAR = 81,
	[Description("Importância por dia de atraso a partir de")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	IMPORTANCIA_POR_DIA_DE_ATRASO_A_PARTIR_DE_DDMMAA = 82,
	[Description("Tem dia da graça")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	TEM_DIA_DA_GRACA = 83,
	[Description("Protestar 45 dias corridos após vencimento")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PROTESTAR,
		EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS,
		EnumChaveContexto.BAN001_CBR641
	})]
	PROTESTAR_45_DIAS_CORRIDOS_APOS_VENCIMENTO = 84,
	[Description("Entregar ao sacado frnaco de pagamento")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRemessa.PEDIDO_DE_BAIXA,
		EnumChaveContexto.BAN001_CBR641
	})]
	ENTREGAR_AO_SACADO_FRANCO_DE_PAGAMENTO = 85,
	[Description("Dispensar juros ou comissão de permanência")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DISPENSAR_JUROS_COMISSAO_DE_PERMANENCIA = 86,
	[Description("Receber somente com a parcela anterior quitada")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	RECEBER_SOMENTE_COM_A_PARCELA_ANTERIOR_QUITADA = 87,
	[Description("Efetuar o pagamento somente através deste boleto e na rede bancária")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	EFETUAR_O_PAGAMENTO_SOMENTE_ATRAVES_DESTE_BOLETO_E_NA_REDE_BANCARIA = 88,
	[Description("Após o vencimento pagável somente no cedente")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	APOS_VENCIMENTO_PAGAVEL_SOMENTE_NA_EMPRESA = 89,
	[Description("Somar o valor do título ao valor do campo mora multa caso exista")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	SOMAR_VALOR_DO_TITULO_AO_VALOR_DO_CAMPO_MORA_MULTA_CASO_EXISTA = 90,
	[Description("Devolver após 365 dias do vencimento")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_365_DIAS_DE_VENCIDO = 91,
	[Description("Cobrança negociada pagável somente por este boleto na rede bancária")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	COBRANCA_NEGOCIADA_PAGAVEL_SOMENTE_POR_ESTE_BOLETO_NA_REDE_BANCARIA = 92,
	[Description("Título entregue em penhor em favor do cedente acima")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	TITULO_ENTREGUE_EM_PENHOR_EM_FAVOR_DO_CEDENTE_ACIMA = 93,
	[Description("Título transferido a favor do cedente")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	TITULO_TRANSFERIDO_A_FAVOR_DO_CEDENTE = 94,
	[Description("Valor da ida engloba multa de 10% pro rata")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	VALOR_DA_IDA_ENGLOBA_MULTA_DE_10_PORCENTO_PRO_RATA = 95,
	[Description("Cobrar juros após 15 dias da emissão")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	COBRAR_JUROS_APOS_15_DIAS_DA_EMISSAO = 96,
	[Description("Pagamento em cheque - somente receber com cheque de emissão do sacado")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	PAGAMENTO_EM_CHEQUE_SOMENTE_RECEBER_COM_CHEQUE_DE_EMISSAO_DO_SACADO = 97,
	[Description("Operação de referência a vendor")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	OPERACAO_REF_A_VENDOR = 98,
	[Description("Após o vencimento consultar a agência do cedente")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	APOS_VENCIMENTO_CONSULTAR_A_AGENCIA_CEDENTE = 99,
	[Description("Antes do vencimento ou após 15 dias - pagável somente em nossa sede")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	ANTES_DO_VENCIMENTO_OU_APOS_15_DIAS_PAGAVEL_SOMENTE_EM_NOSSA_SEDE = 100,
	[Description("Não receber antes do vencimento")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_ANTES_DO_VENCIMENTO = 101,
	[Description("No vencimento pagável em qualquer agência bancária")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NO_VENCIMENTO_PAGAVEL_EM_QUALQUER_AGENCIA_BANCARIA = 102,
	[Description("Não receber após XX dias do vencimento")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	NAO_RECEBER_APOS_XX_DIAS_DO_VENCIMENTO = 103,
	[Description("Devolver após XX dias do vencimento")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DEVOLVER_APOS_XX_DIAS_DO_VENCIMENTO = 104,
	[Description("Mensagens nos boletos com 30 posições")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	MENSAGENS_NOS_BOLETOS_COM_30_POSICOES = 105,
	[Description("Mensagens nos boletos com 40 posições")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	MENSAGENS_NOS_BOLETOS_COM_40_POSIC0ES = 106,
	[Description("Duplicata ou fatura")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DUPLICATA_FATURA = 107
}
