using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumModalidadeCarteiraCobranca
{
	[Description("Simples - Cobrança normal")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumTipoCarteiraCobranca.BAN021_COD_01,
		EnumTipoCarteiraCobranca.BAN021_COD_11,
		EnumTipoCarteiraCobranca.BAN136_COD_21,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL,
		EnumCodigoBanco.BANCO_DA_AMAZONIA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.HSBC_BANK_BRASIL,
		EnumCodigoBanco.BANCO_SAFRA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO,
		EnumChaveContexto.GERAL
	})]
	COBRANCA_SIMPLES = 0,
	[Description("Eletrônica sem registro")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_400,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_ELETRONICA_SEM_REGISTRO = 1,
	[Description("Cobrança simples (sem registro e eletrônica com registro)")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_CSR,
		EnumTipoCarteiraCobranca.BAN033_CSR_NOVA,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_SIMPLES2 = 2,
	[Description("Registrada - Cobrança normal")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.UNIPRIME_NORTE_PARANA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED,
		EnumCodigoBanco.UNICRED,
		EnumCodigoBanco.CRESOL,
		EnumTipoCarteiraCobranca.BAN237_COD_09_UNICRED,
		EnumTipoCarteiraCobranca.BAN237_COD_09_CRESOL,
		EnumTipoCarteiraCobranca.BAN099_COD_09,
		EnumTipoCarteiraCobranca.BAN133_CODIGO_09
	})]
	COBRANCA_REGISTRADA = 3,
	[Description("Caucionada - Cobrança caucionada")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL })]
	COBRANCA_CAUCIONADA = 4,
	[Description("Cobrança vinculada")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoBanco.BANCO_DA_AMAZONIA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_SAFRA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS
	})]
	COBRANCA_VINCULADA = 5,
	[Description("Eletrônica com registro")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_400,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	ELETRONICA_COM_REGISTRO = 6,
	[Description("Descontada - Cobrança descontada")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL })]
	COBRANCA_DESCONTADA = 7,
	[Description("Cobrança caucionada (Eletrônica com registro e convencional com registro)")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_CAUCIONADA2 = 8,
	[Description("Caucionada eletrônica")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_400,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_CAUCIONADA_ELETRONICA = 9,
	[Description("Cobrança caucionada")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN021_COD_13,
		EnumCodigoBanco.BANCO_DA_AMAZONIA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_SAFRA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO
	})]
	COBRANCA_CAUCIONADA3 = 10,
	[Description("Cobrança descontada")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_DA_AMAZONIA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA,
		EnumCodigoBanco.BANCO_SANTANDER,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_SAFRA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS
	})]
	COBRANCA_DESCONTADA2 = 11,
	[Description("Cobrança rápida simples (Rápida com registro)")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_SIMPLES_RAPIDA = 12,
	[Description("Rápida com registro")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_400,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_RAPIDA_COM_REGISTRO = 13,
	[Description("Cobrança vendor")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA,
		EnumCodigoBanco.BANCO_SAFRA
	})]
	COBRANCA_VENDOR2 = 30,
	[Description("Cobrança caucionada (Rápida com registro)")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_CAUCIONADA4 = 14,
	[Description("Caucionada rápida")]
	[AtributoDominio("6", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_400,
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_400,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_400,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_CAUCIONADA_RAPIDA = 15,
	[Description("Transferência de titularidade sem Devolução (cobrança simples - Eletrônica com registro e rápida com registro)")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_TRANSFERENCIA_TITULARIDADE_SEM_DEVOLUCAO = 16,
	[Description("Cobrança cessão (Eletrônica com registro)")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_CESSAO = 17,
	[Description("Transferência de titularidade com devolução (Cobrança simples - Eletrônica com registro e rápida com registro)")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN033_ECR_NOVA_240,
		EnumTipoCarteiraCobranca.BAN033_RCR_NOVA_240,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	COBRANCA_TRANSFERENCIA_TITULARIDADE_COM_DEVOLUCAO = 18,
	[Description("Simples - Cobrança normal")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_SIMPLES,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	SIMPLES = 19,
	[Description("Vinculada - Títulos utilizados como garantia de alguma operação de crédito")]
	[AtributoDominio("02", "02VIN", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_SIMPLES,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	VINCULADA = 20,
	[Description("Caucionada - Títulos utilizados como garantia de alguma operação de crédito")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_CSB,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	CAUCIONADA = 21,
	[Description("Descontada - Antecipação no recebimento dos títulos")]
	[AtributoDominio("04", "04DSC", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_DESCONTADA,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	DESCONTADA = 22,
	[Description("Vendor - Programa de financiamento junto a fornecedores")]
	[AtributoDominio("05", "08VDR", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL,
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_VENDOR,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	VENDOR = 23,
	[Description("Cobrança simples")]
	[AtributoDominio("21", "", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN004_COD_121,
		EnumTipoCarteiraCobranca.BAN004_COD_421,
		EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL
	})]
	COBRANCA_SIMPLES3 = 24,
	[Description("Cobrança vinculada")]
	[AtributoDominio("41", "", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN004_COD_241,
		EnumTipoCarteiraCobranca.BAN004_COD_541,
		EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL
	})]
	COBRANCA_VINCULADA2 = 25,
	[Description("Cobrança simplificada")]
	[AtributoDominio("51", "", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN004_COD_I51,
		EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL
	})]
	COBRANCA_SIMPLIFICADA = 26,
	[Description("Cobrança CSB")]
	[AtributoDominio("D", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_CSB,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL,
		EnumChaveContexto.GERAL
	})]
	COBRANCA_CSB = 27,
	[Description("Desconto de duplicata")]
	[AtributoDominio("R", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_DESCONTADA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL,
		EnumChaveContexto.GERAL
	})]
	COBRANCA_DESCONTADA3 = 28,
	[Description("Vendor eletrônico")]
	[AtributoDominio("S", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN041_COBRANCA_VENDOR,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL,
		EnumChaveContexto.GERAL
	})]
	COBRANCA_VENDOR = 29
}
