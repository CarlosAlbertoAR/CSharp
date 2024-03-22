using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoMovimentoRemessa
{
	[Description("Sem instruções")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	SEM_INSTRUCOES = 117,
	[Description("Entrada de títulos")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ENTRADA_DE_TITULOS = 0,
	[Description("Cobrar juros")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	COBRAR_JUROS = 118,
	[Description("Pedido de baixa")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PEDIDO_DE_BAIXA = 1,
	[Description("Protesto para fins falimentares")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	PROTESTO_PARA_FINS_FALIMENTARES = 2,
	[Description("Pedido de debito em conta")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	PEDIDO_DEBITO_EM_CONTA = 3,
	[Description("Concessão de abatimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	CONCESSAO_ABATIMENTO = 4,
	[Description("Cancelamento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	CANCELAMENTO = 5,
	[Description("Protestar no 3º dia útil após o vencimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_3_DIA_UTIL = 119,
	[Description("Alteração do dados")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	ALTERACAO_DOS_DADOS = 114,
	[Description("Concessão de abatimento")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONCESSAO_DE_ABATIMENTO = 6,
	[Description("Protestar no 4º dia útil após o vencimento")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_4_DIA_UTIL = 120,
	[Description("Cancelamento de abatimento")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CANCELAMENTO_DE_ABATIMENTO = 7,
	[Description("Alteração de vencimento")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_VENCIMENTO = 8,
	[Description("Protestar no 5º dia útil após o vencimento")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_5_DIA_UTIL = 121,
	[Description("Alteração de vencimento")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ALTERACAO_DE_VENCIMENTO = 9,
	[Description("Alteração do uso da empresa")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_USO_DA_EMPRESA = 10,
	[Description("Indica protesto em dias corridos, com prazo de 6 a 29, 35 ou 40 dias corridos")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	INDICACAO_PROTESTO_DIAS_CORRIDOS = 128,
	[Description("Concessão de desconto")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONCESSAO_DE_DESCONTO = 11,
	[Description("Alteração do número de controle do participante")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	ALTERACAO_NUMERO_DE_CONTROLE_DO_PARTICIPANTE = 12,
	[Description("Alteração do prazo de protesto")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_PRAZO_DE_PROTESTO = 13,
	[Description("Não protestar")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	NAO_PROTESTAR2 = 129,
	[Description("Cancelamento de desconto")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CANCELAMENTO_DE_DESCONTO = 14,
	[Description("Alteração do número do título dado pelo cedente")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	ALTERACAO_DO_NUMERO_DO_TITULO_DADO_PELO_CEDENTE = 15,
	[Description("Alteração do prazo de devolução")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_PRAZO_DEVOLUCAO = 16,
	[Description("Protestar")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PROTESTAR = 17,
	[Description("Alteração de outros dados")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_OUTROS_DADOS = 18,
	[Description("Sustar protesto e baixar título")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400
	})]
	SUSTAR_PROTESTO_E_BAIXAR_TITULO = 19,
	[Description("Inibir protesto automático")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	INIBIR_PROTESTO_AUTOMATICO = 20,
	[Description("Alteração de dados com emissão de bloqueto")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_DADOS_COM_EMISSAO_BLOQUETO = 21,
	[Description("Concessão de desconto")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	CONCESSAO_DE_DESCONTO2 = 22,
	[Description("Protestar no 10º dia corrido após o vencimento")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_10_DIA_CORRIDO = 122,
	[Description("Sustar protesto e manter em carteira")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CRESOL_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	SUSTAR_PROTESTO_E_MANTER_EM_CARTEIRA = 23,
	[Description("Instrução para dispensar juros")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	INSTRUCAO_PARA_DISPENSAR_JUROS = 24,
	[Description("Protesto para fins falimentares")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	PROTESTO_FINS_FALIMENTARES = 25,
	[Description("Alteração da opção de protesto para devolução")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_OPCAO_PROTESTO_PARA_DEVOLUCAO = 26,
	[Description("Cancelamento de desconto")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_FEBRABAN240 })]
	CANCELAMENTO_DE_DESCONTO2 = 27,
	[Description("Alteração de juros de mora")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ALTERACAO_DE_JUROS_DE_MORA = 28,
	[Description("Alteração de nome e endereço do sacado")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN756_CNAB400
	})]
	ALTERACAO_DE_NOME_E_ENDERECO_DO_SACADO = 29,
	[Description("Alteração da opção de devolução para protesto")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_OPCAO_DEVOLUCAO_PARA_PROTESTO = 30,
	[Description("Reembolso e transferência para carteira simples de títulos de Desconto e Vendor")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	REEMBOLSO_E_TRANSFERENCIA = 31,
	[Description("Inclusão de ocorrência")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	INCLUSAO_OCORRENCIA = 32,
	[Description("Concessão de desconto")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	CONCESSAO_DESCONTO = 139,
	[Description("Dispensar cobrança de juros de mora")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DISPENSAR_COBRANCA_DE_JUROS_DE_MORA = 33,
	[Description("Reembolso e devolução de títulos das espécies de Desconto e Vendor")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	REEMBOLSO_E_DEVOLUCAO = 34,
	[Description("Exclusão de ocorrência")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	EXCLUSAO_OCORRENCIA = 35,
	[Description("Cancelamento de desconto concedido")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	CANCELAMENTO_DESCONTO_CONCEDIDO = 140,
	[Description("Alteração de valor ou percentual de multa")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERACAO_DE_VALOR_PERCENTUAL_DE_MULTA = 36,
	[Description("Cancelamento condição de desconto fixo")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CANCELAMENTO_CONDICAO_DESCONTO_FIXO = 37,
	[Description("Alteração do valor do desconto")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	ALTERACAO_VALOR_DESCONTO = 141,
	[Description("Dispensar cobrança de multa")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DISPENSAR_COBRANCA_DE_MULTA = 38,
	[Description("Protesto imediato por motivo de falência")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	PROTESTO_IMEDIATO_POR_MOTIVO_FALENCIA = 39,
	[Description("Cancelamento de desconto diário")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CANCELAMENTO_DESCONTO_DIARIO = 40,
	[Description("Protestar no 15º dia corrido após o vencimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_15_DIA_CORRIDO = 123,
	[Description("Alteração do valor ou percentual de multa")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	ALTERACAO_VALOR_OU_PERCENTUAL_MULTA = 142,
	[Description("Alteração de valor ou data de desconto")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ALTERACAO_DE_VALOR_DATA_DE_DESCONTO = 41,
	[Description("Alterar juros de mora")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ALTERAR_JUROS_DE_MORA = 42,
	[Description("Alteração do número de dias para protesto")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_NUMERO_DIAS_PROTESTO = 43,
	[Description("Cobrar juros de mora")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	COBRAR_JUROS_DE_MORA = 129,
	[Description("Dispensar cobrança de multa")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	DISPENSAR_COBRANCA_MULTA = 143,
	[Description("Não conceder desconto")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	NAO_CONCEDER_DESCONTO = 44,
	[Description("Protestar imediatamente para fins de falência")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	PROTESTAR_IMEDIATAMENTE_PARA_FINS_DE_FALENCIA = 45,
	[Description("Alteração de juros de mora")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	ALTERACAO_JUROS_DE_MORA = 144,
	[Description("Alteração de valor de abatimento")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERACAO_DE_VALOR_DE_ABATIMENTO = 46,
	[Description("Sustar protesto")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SUSTAR_PROTESTO = 47,
	[Description("Cancelar protesto e baixar título")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CANCELAR_PROTESTO_E_BAIXAR_TITULO = 48,
	[Description("Alteração do nome do pagador")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_DO_NOME_DO_PAGADOR = 49,
	[Description("Alterar prazo limite de recebimento")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERAR_PRAZO_LIMITE_DE_RECEBIMENTO = 50,
	[Description("Cancelar protesto e manter em carteira")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CANCELAR_PROTESTO_E_MANTER_EM_CARTEIRA = 51,
	[Description("Alteração do endereço do pagador")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_DO_ENDERECO_DO_PAGADOR = 52,
	[Description("Alteração do valor de abatimento")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	ALTERACAO_VALOR_ABATIMENTO = 145,
	[Description("Dispensar prazo limite de recebimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DISPENSAR_PRAZO_LIMITE_DE_RECEBIMENTO = 53,
	[Description("Alteração da cidade do pagador")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_CIDADE_PAGADOR = 54,
	[Description("Protestar no 20º dia corrido após o vencimento")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_20_DIA_CORRIDO = 124,
	[Description("Sustar protesto e baixar título")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	SUSTAR_PROTESTO_E_BAIXAR_TITULO2 = 146,
	[Description("Alterar número do título dado pelo cedente")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERAR_NUMERO_DO_TITULO_DADO_PELO_CEDENTE = 55,
	[Description("Alteração do CEP do pagador")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_CEP_PAGADOR = 56,
	[Description("Alterar número de controle do participante")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERAR_NUMERO_CONTROLE_DO_PARTICIPANTE = 57,
	[Description("Transferência de cessão de crédito id prod. 10")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	TRANSFERENCIA_CESSAO_CREDITO_ID_PROD_10 = 58,
	[Description("Conceder desconto só até a data estipulada")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	CONCEDER_DESCONTO_SO_ATE_DATA_ESTIPULADA = 130,
	[Description("Alterar dados do sacado")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERAR_DADOS_DO_SACADO = 59,
	[Description("Tranferência entre carteiras")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	TRANSFERENCIA_ENTRE_CARTEIRAS = 60,
	[Description("Alterar dados do sacador avalista")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERAR_DADOS_DO_SACADOR_AVALISTA = 61,
	[Description("Devolução de transferência entre carteiras")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	DEVOLUCAO_TRANSFERENCIA_ENTRE_CARTEIRAS = 62,
	[Description("Protestar no 25º dia corrido após o vencimento")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_25_DIA_CORRIDO = 125,
	[Description("Recusa da alegação do sacado")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	RECUSA_DA_ALEGACAO_DO_SACADO = 63,
	[Description("Exclusão de sacador avalista")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	EXCLUSAO_DE_SACADOR_AVALISTA = 64,
	[Description("Protestar no 30º dia corrido após o vencimento")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_30_DIA_CORRIDO = 126,
	[Description("Alteração de outros dados")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ALTERACAO_DE_OUTROS_DADOS = 65,
	[Description("Conceder desconto")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	CONCEDER_DESCONTO = 66,
	[Description("Alteração do valor do título")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ALTERACAO_VALOR_TITULO = 135,
	[Description("Não aplicar desconto")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	NAO_APLICAR_DESCONTO = 67,
	[Description("Pedido de devolução")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	PEDIDO_DEVOLUCAO = 68,
	[Description("Alteração dos dados do rateio de crédito")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240
	})]
	ALTERACAO_DOS_DADOS_DO_RATEIO_DE_CREDITO = 69,
	[Description("Retificar dados da concessão de desconto")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	RETIFICAR_DADOS_DA_CONCESSAO_DE_DESCONTO = 70,
	[Description("Pedido de devolução (entregue ao sacado)")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	PEDIDO_DEVOLUCAO_ENTREGUE_AO_SACADO = 71,
	[Description("Pedido de cancelamento dos dados do rateio de crédito")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	PEDIDO_DE_CANCELAMENTO_DOS_DADOS_DO_RATEIO_DE_CREDITO = 72,
	[Description("Alterar data para concessão de desconto")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ALTERAR_DATA_PARA_CONCESSAO_DE_DESCONTO = 73,
	[Description("Baixa por ter sido pago diretamento ao cedente")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	BAIXA_POR_TER_SIDO_PAGO_DIRETAMENTE_AO_CEDENTE = 74,
	[Description("Pedido de desagendamento do débito automático")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	PEDIDO_DE_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO = 75,
	[Description("Cobrar multa")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	COBRAR_MULTA = 76,
	[Description("Cancelamento de instrução")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CANCELAMENTO_DE_INSTRUCAO = 77,
	[Description("Dispensar multa")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	DISPENSAR_MULTA = 78,
	[Description("Inclusão no banco de sacados")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	INCLUSAO_NO_BANCO_SACADOS = 79,
	[Description("Dispensar indexador")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	DISPENSAR_INDEXADOR = 80,
	[Description("Alteração de vencimento e sustar protesto")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	ALTERACAO_DE_VENCIMENTO_E_SUSTAR_PROTESTO = 81,
	[Description("Alteração no banco de sacados")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	ALTERACAO_NO_BANCO_SACADOS = 82,
	[Description("Beneficiário não concorda com alegação do pagador")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BENEFICIARIO_NAO_CONCORDA_COM_ALEGACAO_DO_PAGADOR = 83,
	[Description("Renunciar prazo limite de recebimento")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	RENUNCIAR_PRAZO_LIMITE_DE_RECEBIMENTO = 84,
	[Description("Alterar prazo limite de recebimento")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ALTERAR_PRAZO_LIMITE_RECEBIMENTO = 85,
	[Description("Exclusão no banco de sacados")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	EXCLUSAO_NO_BANCO_SACADOS = 86,
	[Description("Alterar carteira")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERACAO_DE_CARTEIRA = 87,
	[Description("Alterar modalidade")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ALTERAR_MODALIDADE = 88,
	[Description("Serviços")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	SERVICOS = 89,
	[Description("Cancelar protesto")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CANCELAR_PROTESTO = 90,
	[Description("Exclusão de sacador avalista")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	EXCLUSAO_SACADOR_AVALISTA = 91,
	[Description("Alteração de espécie de título")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_UNICRED_FEBRABAN240
	})]
	ALTERACAO_DE_ESPECIE_DE_TITULO = 92,
	[Description("Transferência de carteira ou modalidade de cobrança")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TRANSFERENCIA_DE_CARTEIRA_MODALIDADE_DE_COBRANCA = 93,
	[Description("Alteração de contrato de cobrança")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	ALTERACAO_DE_CONTRATO_DE_COBRANCA = 94,
	[Description("Negativação sem protesto")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NEGATIVACAO_SEM_PROTESTO = 95,
	[Description("Pedido de negativação")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	PEDIDO_DE_NEGATIVACAO = 149,
	[Description("Protestar no 45º dia corrido após o vencimento")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	PROTESTAR_45_DIA_CORRIDO = 127,
	[Description("Incluir negativação")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	INCLUIR_NEGATIVACAO = 136,
	[Description("Solicitação de baixa de título negativado sem protesto")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	SOLICITACAO_DE_BAIXA_DE_TITULO_NEGATIVADO_SEM_PROTESTO = 96,
	[Description("Excluir negativação com baixa")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	EXCLUIR_NEGATIVACAO_COM_BAIXA = 150,
	[Description("Cedente solicita dispensa de juros")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CEDENTE_SOLICITA_DISPENSA_DE_JUROS = 97,
	[Description("Excluir negativação e manter pendente")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	EXCLUIR_NEGATIVACAO_E_MANTER_PENDENTE = 151,
	[Description("Alteração do valor nominal do título")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	ALTERACAO_VALOR_NOMINAL = 157,
	[Description("Alteração do valor mínimo/percentual")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	ALTERACAO_VALOR_MINIMO = 158,
	[Description("Alteração de dados extras")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	ALTERACAO_DE_DADOS_EXTRAS = 98,
	[Description("Alteração de dias para envio a cartório")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400
	})]
	ALTERACAO_DIAS_ENVIO_PARA_CARTORIO = 99,
	[Description("Alteração do valor máximo/percentual")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	ALTERACAO_VALOR_MAXIMO = 159,
	[Description("Baixa manual")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	BAIXA_MANUAL = 115,
	[Description("Inclusão de sacado no boleto eletrônico")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400
	})]
	INCLUSAO_SACADO_BOLETO_ELETRONICO = 100,
	[Description("Exclusão de sacado do boleto eletrônico")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400
	})]
	EXCLUSAO_SACADO_BOLETO_ELETRONICO = 101,
	[Description("Cancelamento manual")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	CANCELAMENTO_MANUAL = 116,
	[Description("Reemisão")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	REEMISSAO = 102,
	[Description("Entrada de títulos com parcelas faltantes")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	ENTRADA_DE_TITULOS_COM_PARCELAS_FALTANTES = 103,
	[Description("Transferência para desconto")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	TRANSFERENCIA_PARA_DESCONTO = 104,
	[Description("Protesto para fins falimentares")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400
	})]
	PROTESTO_PARA_FINS_FALIMENTARES2 = 105,
	[Description("Entrada em negativação expressa")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	ENTRADA_EM_NEGATIVACAO_EXPRESSA = 106,
	[Description("Não negativar")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	NAO_NEGATIVAR = 107,
	[Description("Excluir negativação expressa")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	EXCLUIR_NEGATIVACAO_EXPRESSA = 108,
	[Description("Acerto nos dados do rateio de crédito")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	ACERTO_NOS_DADOS_DO_RATEIO_DE_CREDITO = 109,
	[Description("Cancelar negativação expressa")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	CANCELAR_NEGATIVACAO_EXPRESSA = 110,
	[Description("Cancelamento do rateio de crédito")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_UNICRED_CNAB400
	})]
	CANCELAMENTO_DO_RATEIO_DE_CREDITO = 111,
	[Description("Excluir negativação e manter em carteira")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	EXCLUIR_NEGATIVACAO_MATER_EM_CARTEIRA = 137,
	[Description("Mensagens para o título")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	MENSAGENS_PARA_O_TITULO = 147,
	[Description("Excluir negativação e baixar título")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	EXCLUIR_NEGATIVACAO_BAIXAR_TITULO = 138,
	[Description("Mensagens para o título")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	MENSAGENS_PARA_O_TITULO2 = 148,
	[Description("Alterar tipo de emissao - Cooperativa/EE")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	ALTERAR_TIPO_EMISSAO = 152,
	[Description("Negativar")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NEGATIVAR = 131,
	[Description("Baixa de negativação")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	BAIXA_DE_NEGATIVACAO = 132,
	[Description("Não negativar automaticamente")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NAO_NEGATIVAR_AUTOMATICAMENTE = 133,
	[Description("Inclusão negativação via Serasa")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	INCLUSAO_NEGATIVACAO_VIA_SERASA = 153,
	[Description("Exclusão negativação via Serasa")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	EXCLUSAO_NEGATIVACAO_VIA_SERASA = 154,
	[Description("Envio de SMS ao pagador")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	ENVIO_SMS_PAGADOR = 155,
	[Description("Cancelamento instrução de SMS")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	CANCELAMENTO_INSTRUCAO_SMS = 156,
	[Description("Não protestar (antes de começar o ciclo de protesto)")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240
	})]
	NAO_PROTESTAR = 112,
	[Description("Pedido dos títulos em aberto")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	PEDIDO_DOS_TITULOS_EM_ABERTO = 113
}
