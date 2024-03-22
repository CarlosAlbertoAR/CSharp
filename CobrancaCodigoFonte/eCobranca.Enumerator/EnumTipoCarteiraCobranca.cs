using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoCarteiraCobranca
{
	[Description("Carteira 11 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_11_CONVENIO_4 = 0,
	[Description("Carteira 11 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_11_CONVENIO_6 = 1,
	[Description("Carteira 11 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_11_CONVENIO_7 = 2,
	[Description("Carteira 12 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_12_CONVENIO_4 = 3,
	[Description("Carteira 12 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_12_CONVENIO_6 = 4,
	[Description("Carteira 12 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_12_CONVENIO_7 = 5,
	[Description("Carteira 15 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_15_CONVENIO_4 = 6,
	[Description("Carteira 15 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_15_CONVENIO_6 = 7,
	[Description("Carteira 15 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_15_CONVENIO_7 = 8,
	[Description("Carteira 16 Convênio 4 dígitos: cobrança sem registro")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_16_CONVENIO_4 = 9,
	[Description("Carteira 16 Convênio 6 dígitos: cobrança sem registro")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_16_CONVENIO_6 = 10,
	[Description("Carteira 16 Convênio 7 dígitos: cobrança sem registro")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_16_CONVENIO_7 = 11,
	[Description("Carteira 16 Convênio 6 dígitos com nosso número livre de 17 posições: cobrança com registro")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_16_CONVENIO_6_NOSSO_NUMERO_LIVRE_17 = 12,
	[Description("Carteira 17 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_17_CONVENIO_4 = 13,
	[Description("Carteira 17 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_17_CONVENIO_6 = 14,
	[Description("Carteira 17 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_17_CONVENIO_7 = 15,
	[Description("Carteira 18 Convênio 4 dígitos: cobrança sem registro")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_18_CONVENIO_4 = 16,
	[Description("Carteira 18 Convênio 6 dígitos: cobrança sem registro")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_18_CONVENIO_6 = 17,
	[Description("Carteira 18 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_18_CONVENIO_7 = 18,
	[Description("Carteira 18 Convênio 6 dígitos com nosso número livre de 17 posições: cobrança com registro")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_18_CONVENIO_6_NOSSO_NUMERO_LIVRE_17 = 19,
	[Description("Carteira 31 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_31_CONVENIO_4 = 20,
	[Description("Carteira 31 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_31_CONVENIO_6 = 21,
	[Description("Carteira 31 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_31_CONVENIO_7 = 22,
	[Description("Carteira 51 Convênio 4 dígitos: cobrança com registro")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_51_CONVENIO_4 = 23,
	[Description("Carteira 51 Convênio 6 dígitos: cobrança com registro")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_51_CONVENIO_6 = 24,
	[Description("Carteira 51 Convênio 7 dígitos: cobrança com registro")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	BAN001_COD_51_CONVENIO_7 = 25,
	[Description("Carteira CNR - Cobrança não registrada simples")]
	[AtributoDominio("CNR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN150,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN003_CNR = 26,
	[Description("Carteira 1 - Cobrança simples com registro")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN003_CODIGO_1 = 133,
	[Description("Cobrança simples escritural - Boleto emitido pelo banco")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN004_COD_121 = 27,
	[Description("Cobrança vinculada - Boleto emitido pelo banco")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN004_COD_241 = 28,
	[Description("Cobrança simples - Boleto emitido pelo cliente")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN004_COD_421 = 29,
	[Description("Cobrança vinculada - Boleto emitido pelo cliente")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN004_COD_541 = 30,
	[Description("Cobrança simplificada (Sem registro)")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumCodigoBanco.BANCO_DA_AMAZONIA
	})]
	BAN004_COD_I51 = 31,
	[Description("Carteira 01 - Desconto com registro")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO
	})]
	BAN021_COD_01 = 136,
	[Description("Carteira 11 - Simples com registro")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO
	})]
	BAN021_COD_11 = 137,
	[Description("Carteira 13 - Caucionada")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO
	})]
	BAN021_COD_13 = 138,
	[Description("ECR 400 - Cobrança eletrônica com registro")]
	[AtributoDominio("101", "ECR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_ECR_400 = 32,
	[Description("ECR NOVA 240 - Cobrança nova eletrônica com registro - Layout de 240 posições")]
	[AtributoDominio("101", "ECR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_ECR_NOVA_240 = 33,
	[Description("RCR NOVA 240 - Cobrança nova eletrônica com registro - Layout de 240 posições")]
	[AtributoDominio("101", "RCR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_RCR_NOVA_240 = 127,
	[Description("ECR NOVA 400 - Cobrança nova eletrônica com registro - Layout de 400 posições")]
	[AtributoDominio("101", "ECR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_ECR_NOVA_400 = 34,
	[Description("RCR NOVA 400 - Cobrança nova eletrônica com registro - Layout de 400 posições")]
	[AtributoDominio("101", "RCR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_RCR_NOVA_400 = 128,
	[Description("CSR - Cobrança simples sem registro")]
	[AtributoDominio("102", "CSR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN033_CNAB400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_CSR = 35,
	[Description("CSR NOVA - Cobrança simples sem registro")]
	[AtributoDominio("102", "CSR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN033_CNAB400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	BAN033_CSR_NOVA = 36,
	[Description("CR - Cobrança eletrônica com registro")]
	[AtributoDominio("CR", "CR", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA
	})]
	BAN037_CR_240 = 139,
	[Description("Cobrança simples (8050.76)")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	BAN041_COBRANCA_SIMPLES = 37,
	[Description("Cobrança CSB (8258.67)")]
	[AtributoDominio("D", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	BAN041_COBRANCA_CSB = 38,
	[Description("Cobrança descontada (6030.15)")]
	[AtributoDominio("R", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	BAN041_COBRANCA_DESCONTADA = 39,
	[Description("Cobrança vendor eletrônica (6032.79)")]
	[AtributoDominio("S", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	BAN041_COBRANCA_VENDOR = 40,
	[Description("Carteira 09 - Com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN084_FEBRABAN240,
		EnumCodigoBanco.UNIPRIME_NORTE_PARANA
	})]
	BAN084_COD_09 = 142,
	[Description("Cobrança simples registrada - Boleto emissão própria")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN085_CNAB400,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS
	})]
	BAN085_CODIGO_01 = 131,
	[Description("Cobrança simples registrada - Boleto emissão própria")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN097_CNAB400,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	BAN097_CODIGO_18 = 41,
	[Description("Cobrança simples registrada - Boleto emissão própria")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	BAN097_SIMPLES = 129,
	[Description("Carteira 09 - Com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN099_FEBRABAN240,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED
	})]
	BAN099_COD_09 = 42,
	[Description("Carteira SIGCB11 - Com registro - Emissão pelo banco")]
	[AtributoDominio("11", "SIG11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL
	})]
	BAN104_SIG11 = 43,
	[Description("Carteira SIGCB14 - Com registro - Emissão pelo cedente")]
	[AtributoDominio("14", "SIG14", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL
	})]
	BAN104_SIG14 = 44,
	[Description("Carteira SIGCB21 - Sem registro - Emissão pelo banco")]
	[AtributoDominio("21", "SIG21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL
	})]
	BAN104_SIG21 = 45,
	[Description("Carteira SIGCB24 - Sem registro - Emissão pelo cedente")]
	[AtributoDominio("24", "SIG24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL
	})]
	BAN104_SIG24 = 46,
	[Description("Carteira 09 - Simples com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN133_CNAB400,
		EnumCodigoBanco.CRESOL
	})]
	BAN133_CODIGO_09 = 141,
	[Description("Carteira 21 - Simples com registro")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN136_CNAB400,
		EnumCodigoBanco.UNICRED
	})]
	BAN136_COD_21 = 140,
	[Description("Carteira 02")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_02 = 47,
	[Description("Carteira 03")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_03 = 48,
	[Description("Carteira 04")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_04 = 49,
	[Description("Carteira 06 - Sem registro")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_06 = 50,
	[Description("Carteira 07")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_07 = 51,
	[Description("Carteira 09 - Com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_09 = 52,
	[Description("Carteira 09 Unicred - Com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_09_UNICRED = 53,
	[Description("Carteira 09 Cresol - Com registro")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_09_CRESOL = 134,
	[Description("Carteira 12")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_12 = 54,
	[Description("Carteira 16 - Sem registro com protesto")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_16 = 55,
	[Description("Carteira 17")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_17 = 56,
	[Description("Carteira 19")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_19 = 57,
	[Description("Carteira 21 - Com registro pagável somente no Bradesco")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_21 = 58,
	[Description("Carteira 22 - Sem registro pagável somente no Bradesco")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_22 = 59,
	[Description("Carteira 27 - Descontada")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	BAN237_COD_27 = 60,
	[Description("Carteira 102 - Sem Registro Com Emissão Integral - Carnê")]
	[AtributoDominio("102", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_102 = 61,
	[Description("Carteira 103 - Sem Registro Com Emissão/Entrega - Carnê")]
	[AtributoDominio("103", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_103 = 62,
	[Description("Carteira 104 - Escritural Eletrônica - Carnê")]
	[AtributoDominio("104", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_104 = 63,
	[Description("Carteira 105 - Escritural Eletrônica - Dólar - Carnê")]
	[AtributoDominio("105", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_105 = 64,
	[Description("Carteira 106 - S/Registro C/Emissão/Entrega-15 dígitos-Carnê")]
	[AtributoDominio("106", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_106 = 65,
	[Description("Carteira 107 - S/Registro C/Emissão Integral-15 Posições-Carnê")]
	[AtributoDominio("107", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_107 = 66,
	[Description("Carteira 108 - Direta Eletrônica Emissão Integral - Carnê")]
	[AtributoDominio("108", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_108 = 67,
	[Description("Carteira 109 - Direta Eletrônica Sem Emissão - Simples")]
	[AtributoDominio("109", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_109 = 68,
	[Description("Carteira 110 - Direta Eletrônica Sem Emissão - Simples")]
	[AtributoDominio("110", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_110 = 69,
	[Description("Carteira 111 - Direta Eletrônica Sem Emissão - Simples")]
	[AtributoDominio("111", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_111 = 70,
	[Description("Carteira 112 - Escritural Eletrônica - simples / contratual")]
	[AtributoDominio("112", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_112 = 71,
	[Description("Carteira 113 - Escritural Eletrônica - TR - Carnê")]
	[AtributoDominio("113", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_113 = 72,
	[Description("Carteira 114 - Escritural Eletrônica - Seguros")]
	[AtributoDominio("114", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_114 = 73,
	[Description("Carteira 115 - Carteira 115")]
	[AtributoDominio("115", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_115 = 74,
	[Description("Carteira 120 - S/Registro Emissão Integral C/IOF 2% - Carnê")]
	[AtributoDominio("120", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_120 = 75,
	[Description("Carteira 121 - Direta Eletrônica Emissão Parcial - Simples/Contra")]
	[AtributoDominio("121", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_121 = 76,
	[Description("Carteira 122 - S/Registro S/Emissão 15 Dígitos C/IOF 2%")]
	[AtributoDominio("122", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_122 = 77,
	[Description("Carteira 126 - Direta Eletrônica Sem Emissão - Seguros")]
	[AtributoDominio("126", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_126 = 78,
	[Description("Carteira 129 - S/Registro Emissão Parcial Seguros C/IOF 2%")]
	[AtributoDominio("129", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_129 = 79,
	[Description("Carteira 131 - Direta Eletrônica c/ Valor em Aberto")]
	[AtributoDominio("131", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_131 = 80,
	[Description("Carteira 138 - Escritural Eletrônica - Mensagem Colorida")]
	[AtributoDominio("138", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_138 = 81,
	[Description("Carteira 139 - S/Registro Emissão Parcial Seguros C/IOF 4%")]
	[AtributoDominio("139", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_139 = 82,
	[Description("Carteira 140 - S/Registro Emissão Integral C/IOF 4% - Carnê")]
	[AtributoDominio("140", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_140 = 83,
	[Description("Carteira 141 - S/Registro Emissão Integral C/IOF 7% - Carnê")]
	[AtributoDominio("141", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_141 = 84,
	[Description("Carteira 142 - S/Registro S/Emissão 15 DÍGITOS C/IOF 4%")]
	[AtributoDominio("142", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_142 = 85,
	[Description("Carteira 143 - S/Registro S/Emissão 15 DÍGITOS C/IOF 7%")]
	[AtributoDominio("143", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_143 = 86,
	[Description("Carteira 146 - Descrição Não Disponível")]
	[AtributoDominio("146", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_146 = 87,
	[Description("Carteira 147 - Escritural Eletrônica - Dólar")]
	[AtributoDominio("147", "E", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_147 = 88,
	[Description("Carteira 150 - Direta Eletrônica Sem Emissão - Dólar")]
	[AtributoDominio("150", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_150 = 89,
	[Description("Carteira 166 - Escritural Eletrônica - TR")]
	[AtributoDominio("166", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_166 = 90,
	[Description("Carteira 168 - Direta Eletrônica Sem Emissão - TR")]
	[AtributoDominio("168", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_168 = 91,
	[Description("Carteira 169 - S/Registro Emissão Parcial Seguros C/IOF 7%")]
	[AtributoDominio("169", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_169 = 92,
	[Description("Carteira 172 - Sem Registro Com Emissão Integral")]
	[AtributoDominio("172", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_172 = 93,
	[Description("Carteira 173 - Sem Registro Com Emissão/Entrega")]
	[AtributoDominio("173", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_173 = 94,
	[Description("Carteira 174 - Sem Registro Emissão Parcial Com Protesto Borderô")]
	[AtributoDominio("174", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_174 = 95,
	[Description("Carteira 175 - Sem Registro Sem Emissão")]
	[AtributoDominio("175", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_175 = 96,
	[Description("Carteira 177 - S/Registro Emissão Parcial C/Protesto Eletrônico")]
	[AtributoDominio("177", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_177 = 97,
	[Description("Carteira 178 - Carteira 178")]
	[AtributoDominio("178", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_178 = 98,
	[Description("Carteira 179 - Sem Registro Sem Emissão Com  Protesto Eletrônico")]
	[AtributoDominio("179", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_179 = 99,
	[Description("Carteira 180 - Direta Eletrônica Emissão Integral Simples/Contrat")]
	[AtributoDominio("180", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_180 = 100,
	[Description("Carteira 195 - S/Registro C/Emissão Integral-15 Posições")]
	[AtributoDominio("195", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_195 = 101,
	[Description("Carteira 196 - S/Registro C/Emissão/Entrega-15 Posições")]
	[AtributoDominio("196", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_196 = 102,
	[Description("Carteira 198 - Sem Registro Sem Emissão 15 Dígitos")]
	[AtributoDominio("198", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_198 = 103,
	[Description("Carteira 210 - Direta Eletrônica Sem Emissão - Contratual")]
	[AtributoDominio("210", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_210 = 104,
	[Description("Carteira 212 - Escritural Eletrônica - simples / contratual")]
	[AtributoDominio("212", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_212 = 105,
	[Description("Carteira 221 - Direta Eletrônica Emissão Parcial - Simples/Contra")]
	[AtributoDominio("221", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_221 = 106,
	[Description("Carteira 280 - Direta Eletrônica Emissão Integral Simples/Contrat")]
	[AtributoDominio("280", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_280 = 107,
	[Description("Carteira 305 - Títulos Descontados (também retorno carteira 191)")]
	[AtributoDominio("305", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_305 = 108,
	[Description("Carteira 352 - Desconto de Duplicata Escritural - Agência")]
	[AtributoDominio("352", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_352 = 109,
	[Description("Carteira 354 - Desconto de Duplicata Escritural - Dicom")]
	[AtributoDominio("354", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_354 = 110,
	[Description("Carteira 358 - Desconto de Duplicata Escritural - Corp")]
	[AtributoDominio("358", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_358 = 111,
	[Description("Carteira 359 - Desconto de Duplicata Escritural Aval Corp")]
	[AtributoDominio("359", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_359 = 112,
	[Description("Carteira 364 - Desconto de Duplicata Escritural Aval Agência")]
	[AtributoDominio("364", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_364 = 113,
	[Description("Carteira 365 - Desconto de Duplicata Escritural Aval Dicom")]
	[AtributoDominio("365", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_365 = 114,
	[Description("Carteira 458 - Desc dp Escritural - Emp Um")]
	[AtributoDominio("458", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_458 = 115,
	[Description("Carteira 459 - Desc dp Escritural a - Emp Um")]
	[AtributoDominio("459", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_459 = 116,
	[Description("Carteira 880 - Carteira 880")]
	[AtributoDominio("880", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_880 = 117,
	[Description("Carteira 986 - Carteira 986")]
	[AtributoDominio("986", "I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumCodigoBanco.BANCO_ITAU
	})]
	BAN341_986 = 118,
	[Description("Carteira CSB - Cobrança diretiva com registro")]
	[AtributoDominio("CSB", "1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumCodigoBanco.HSBC_BANK_BRASIL
	})]
	BAN399_CSB_COBRANCA_DIRETIVA = 119,
	[Description("Carteira CNR - Cobrança sem registro")]
	[AtributoDominio("CNR", "1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumCodigoBanco.HSBC_BANK_BRASIL
	})]
	BAN399_CNR_COBRANCA_SEM_REGISTRO = 120,
	[Description("Carteira 1 - Cobrança simples registrada")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumCodigoBanco.BANCO_SAFRA
	})]
	BAN422_CODIGO_1 = 132,
	[Description("Carteira 2 - Cobrança vinculada registrada")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumCodigoBanco.BANCO_SAFRA
	})]
	BAN422_CODIGO_2 = 135,
	[Description("Carteira A - Cobrança com registro")]
	[AtributoDominio("1", "A", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	BAN748_A = 121,
	[Description("Carteira C - Cobrança sem registro")]
	[AtributoDominio("3", "C", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	BAN748_C = 122,
	[Description("Carteira 01 - Cobrança simples com registro")]
	[AtributoDominio("01", "1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	BAN756_SIMPLES_COM_REGISTRO = 123,
	[Description("Carteira 02 - Cobrança simples sem registro")]
	[AtributoDominio("02", "1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	BAN756_SIMPLES_SEM_REGISTRO = 124,
	[Description("Carteira 03 - Cobrança caucionada garantida")]
	[AtributoDominio("03", "3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	BAN756_CAUCIONADA_GARANTIDA = 125,
	[Description("Carteira 17 - Cobrança registrada correspondente Banco do Brasil")]
	[AtributoDominio("17", "1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL = 126,
	CARTEIRA_NAO_INFORMADA = 130
}
