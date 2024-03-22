using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoMovimentoRetorno
{
	[Description("Devolução, liquidado anteriormente")]
	[AtributoDominio("AA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	DEVOLUCAO_LIQUIDADO_ANTERIORMENTE = 0,
	[Description("Cobrança a creditar")]
	[AtributoDominio("AB", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	COBRANCA_A_CREDITAR = 1,
	[Description("Situação do título - Cartório")]
	[AtributoDominio("AC", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	SITUACAO_TITULO_EM_CARTORIO = 2,
	[Description("Ocorrência desconhecida")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN133_CNAB400 })]
	OCORRENCIA_DESCONHECIDA = 312,
	[Description("Solicitação de impressão de títulos confirmada")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	SOLICITACAO_IMPRESSAO_TITULOS_CONFIRMADA = 3,
	[Description("Entrada confirmada")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ENTRADA_CONFIRMADA2 = 4,
	[Description("Inclusão de boleto confirmada")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	INCLUSAO = 5,
	[Description("Título não existe")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_NAO_EXISTE = 6,
	[Description("Entrada confirmada")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
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
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
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
	ENTRADA_CONFIRMADA = 7,
	[Description("Liquidação")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN104_CNAB400
	})]
	LIQUIDACAO3 = 280,
	[Description("Baixa manual confirmada")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	BAIXA_MANUAL_CONFIRMADA = 8,
	[Description("Baixa no banco")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	BAIXA_NO_BANCO = 9,
	[Description("Entrada rejeitada")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
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
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ENTRADA_REJEITADA = 10,
	[Description("Abatimento concedido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ABATIMENTO_CONCEDIDO = 11,
	[Description("Baixa manual")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	BAIXA_MANUAL = 281,
	[Description("Baixa no estabelecimento")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumChaveContexto.BAN097_CNAB400
	})]
	BAIXA_NO_ESTABELECIMENTO = 12,
	[Description("Transferência de carteira - entrada")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TRANSFERENCIA_DE_CARTEIRA_ENTRADA = 13,
	[Description("Abatimento cancelado")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ABATIMENTO_CANCELADO = 14,
	[Description("Baixa de título liquidado por edital")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	BAIXA_DE_TITULO_LIQUIDADO_POR_EDITAL = 15,
	[Description("Alteração")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ALTERACAO = 16,
	[Description("Cancelamento do título")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_CODIGO_18,
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	CANCELAMENTO_DO_TITULO = 17,
	[Description("Transferência de carteira - baixa")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TRANSFERENCIA_DE_CARTEIRA_BAIXA = 18,
	[Description("Liquidação sem registro")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN756_CNAB400
	})]
	LIQUIDACAO_SEM_REGISTRO = 19,
	[Description("Vencimento alterado")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	VENCIMENTO_ALTERADO = 20,
	[Description("Desconto")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN097_CNAB400 })]
	DESCONTO = 21,
	[Description("Boleto descontado na cooperativa")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	BOLETO_DESCONTADO_COOPERATIVA = 282,
	[Description("Liquidação")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
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
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
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
	LIQUIDACAO = 22,
	[Description("Uso da empresa alterado")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	USO_DA_EMPRESA_ALTERADO = 23,
	[Description("Inclusão de boleto rejeitado")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	INCLUSAO_BOLETO_REJEITADO = 283,
	[Description("Confirmação de recebimento de instrução de desconto")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_RECEBIMENTO_DA_INSTRUCAO_DE_DESCONTO = 24,
	[Description("Liquidação por conta ou parcial")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	LIQUIDACAO_PARCIAL = 25,
	[Description("Prazo de protesto alterado")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	PRAZO_DE_PROTESTO_ALTERADO = 26,
	[Description("Pagamento por conta")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	PAGAMENTO_POR_CONTA = 27,
	[Description("Confirmação da alteração")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	CONFIRMACAO_ALTERACAO2 = 284,
	[Description("Confirmação de recebimento do cancelamento do desconto")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_RECEBIMENTO_DO_CANCELAMENTO_DO_DESCONTO = 28,
	[Description("Liquidação por saldo")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400
	})]
	LIQUIDACAO_POR_SALDO = 29,
	[Description("Liquidação em cartório")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	LIQUIDACAO_EM_CARTORIO = 30,
	[Description("Prazo de devolução alterado")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	PRAZO_DE_DEVOLUCAO_ALTERADO = 31,
	[Description("Alteração rejeitada")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_CNAB400
	})]
	ALTERACAO_REJEITADA2 = 285,
	[Description("Baixa")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
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
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
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
	BAIXA = 32,
	[Description("Alteração confirmada")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_CONFIRMADA = 33,
	[Description("Baixado conforme instruções da agência")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA = 34,
	[Description("Baixa por ter sido liquidado")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BAIXA_POR_TER_SIDO_LIQUIDADO = 35,
	[Description("Alteração com reemissão de bloqueto confirmada")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_COM_REEMISSAO_BLOQUETO_CONFIRMADA = 36,
	[Description("Reembolso")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	REEMBOLSO = 37,
	[Description("Devolvido/Protestado")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	DEVOLVIDO_PROTESTADO = 38,
	[Description("Baixa solicitada")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	BAIXA_SOLICITADA = 39,
	[Description("Títulos em carteira (Em ser)")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULOS_EM_CARTEIRA = 40,
	[Description("Alteração da opção de protesto para devolução confirmada")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_OPCAO_PROTESTO_PARA_DEVOLUCAO_CONFIRMADA = 41,
	[Description("Arquivo levantamento")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ARQUIVO_LEVANTAMENTO = 42,
	[Description("Conciliação mensal (Em Ser)")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	CONCILIACAO_MENSAL = 43,
	[Description("Em ser")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	EM_SER2 = 44,
	[Description("Confirmação de recebimento de instrução de abatimento")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_ABATIMENTO = 45,
	[Description("Alteração da opção de devolução para protesto confirmada")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_OPCAO_DEVOLUCAO_PARA_PROTESTO = 46,
	[Description("Confirmação de recebimento de instrução de cancelamento de abatimento")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_CANCELAMENTO_ABATIMENTO = 47,
	[Description("Confirmação de recebimento de instrução de alteração de vencimento")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
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
		EnumChaveContexto.BAN237_CNAB400,
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
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_ALTERACAO_DE_VENCIMENTO = 48,
	[Description("Franco de pagamento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	FRANCO_DE_PAGAMENTO = 49,
	[Description("Confirmação de protesto")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	CONFIRMACAO_DE_PROTESTO = 50,
	[Description("Confirmação de protesto por motivo de falência")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_FEBRABAN240 })]
	CONFIRMACAO_DE_PROTESTO_POR_MOTIVO_DE_FALENCIA = 51,
	[Description("Liquidação em cartório")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_CNAB400
	})]
	LIQUIDACAO_EM_CARTORIO2 = 52,
	[Description("Baixas rejeitadas")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BAIXAS_REJEITADAS = 53,
	[Description("Baixa automática")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	BAIXA_AUTOMATICA = 54,
	[Description("Confirmação de alteração de juros de mora")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	CONFIRMACAO_ALTERACAO_JUROS_DE_MORA = 55,
	[Description("Título pago com cheque - vinculado")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_PAGO_COM_CHEQUE_VINCULADO = 56,
	[Description("Instruções rejeitadas")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCOES_REJEITADAS = 57,
	[Description("Título já baixado/liquidado")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TITULO_JA_BAIXADO_OU_LIQUIDADO = 58,
	[Description("Alteração de dados")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_DE_DADOS2 = 59,
	[Description("Liquidação após baixa ou liquidação de título não registrado")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO = 60,
	[Description("Alteração ou exclusão de dados rejeitada")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA = 61,
	[Description("Liquidado em cartório")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	LIQUIDADO_EM_CARTORIO = 62,
	[Description("Entregue em cartório")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	ENTREGUE_EM_CARTORIO = 63,
	[Description("Acerto de depositária")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ACERTO_DE_DEPOSITARIA = 64,
	[Description("Cobrança contratual ")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	COBRANCA_CONTRATUAL = 65,
	[Description("Alteração de instruções")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_DE_INSTRUCOES = 66,
	[Description("Instrução automática de protesto")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	INSTRUCAO_AUTOMATICA_PROTESTO = 67,
	[Description("Alteração depositária")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ALTERACAO_DEPOSITARIA = 68,
	[Description("Confirmação de recebimento de instrução de protesto")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
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
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_PROTESTO = 69,
	[Description("Confirmação de recebimento de instrução de cancelamento de protesto")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN021_CNAB400,
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
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_CANCELAMENTO_DE_PROTESTO = 70,
	[Description("Débito em conta")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DEBITO_EM_CONTA = 71,
	[Description("Em ser")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	EM_SER = 72,
	[Description("Alteração do nome do sacado")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERACAO_NOME_DO_SACADO = 73,
	[Description("Acerto do controle participante")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ACERTO_DO_CONTROLE_PARTICIPANTE = 74,
	[Description("Confirmação de recebimento de instrução de não protestar")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_PROTESTAR = 75,
	[Description("Liquidação")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	LIQUIDACAO2 = 76,
	[Description("Título enviado a cartório")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_ENVIADO_A_CARTORIO = 77,
	[Description("Aguardando autorização para protesto por edital")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	AGUARDANDO_CONFIRMACAO_PARA_PROTESTO_POR_EDITAL = 78,
	[Description("Instrução de alteração de mora")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	INSTRUCAO_ALTERACAO_DE_MORA = 79,
	[Description("Alteração de informações de controle da empresa")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ALTERACAO_INFORMACOES_CONTROLE_EMPRESA = 80,
	[Description("Transferência de beneficiário")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TRANSFERENCIA_BENEFICIARIO = 298,
	[Description("Solicitação de segunda via de instrumento de protesto")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	SEGUNDA_VIA_INSTRUMENTO_PROTESTO = 309,
	[Description("Alteração do endereço do sacado")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERACAO_ENDERECO_SACADO = 81,
	[Description("Título com pagamento cancelado")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_COM_PAGAMENTO_CANCELADO = 82,
	[Description("Liquidação em cartório")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	LIQUIDACAO_EM_CARTORIO3 = 83,
	[Description("Título retirado de cartório")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_RETIRADO_DE_CARTORIO = 84,
	[Description("Protesto sustado por alteração de vencimento e prazo de cartório")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	PROTESTO_SUSTADO_ALTERACAO_VENCIMENTO = 85,
	[Description("Instrução de protesto/serasa processada/re-emitida")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	INSTRUCAO_PROTESTO_SERASA = 86,
	[Description("Alteração do seu número")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ALTERACAO_SEU_NUMERO = 87,
	[Description("Segunda via de instrumento de protesto emitida pelo cartório")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	SEGUNDA_VIA_INSTRUMENTO_EMITIDA = 310,
	[Description("Remessa a cartório")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
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
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	REMESSA_A_CARTORIO = 88,
	[Description("Baixa por devolução")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	BAIXA_POR_DEVOLUCAO = 89,
	[Description("Cancelamento de protesto/serasa processado")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CANCELAMENTO_PROTESTO_SERASA_PROCESSADO = 90,
	[Description("Retirada de cartório e manutenção em carteira")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	RETIRADA_DE_CARTORIO_E_MANUTENCAO_EM_CARTEIRA = 91,
	[Description("Sustar protesto")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	SUSTAR_PROTESTO = 92,
	[Description("Entrada rejeitada por CEP irregular")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ENTRADA_REJEITADA_POR_CEP_IRREGULAR = 93,
	[Description("Instrução de protesto sustada")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_DE_PROTESTO_SUSTADA = 94,
	[Description("Custas de cartório")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	CUSTAS_DE_CARTORIO = 95,
	[Description("Protestado e baixado")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	PROTESTADO_E_BAIXADO = 96,
	[Description("Dispensar juros de mora")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DISPENSAR_JUROS_DE_MORA = 97,
	[Description("Confirmação de recebimento de instrução de protesto falimentar")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CONFIRMACAO_DE_RECEBIMENTO_DE_INSTRUCAO_DE_PROTESTO_FALIMENTAR = 98,
	[Description("Alegações do pagador")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALEGACOES_DO_PAGADOR = 99,
	[Description("Baixa por protesto")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	BAIXA_POR_PROTESTO = 100,
	[Description("Protestar título")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	PROTESTAR_TITULO = 101,
	[Description("Devolução, liquidado anteriormente")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	DEVOLUCAO_LIQUIDADO_ANTERIORMENTE2 = 102,
	[Description("Instrução rejeitada")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	INSTRUCAO_REJEITADA = 103,
	[Description("Alteração do número do título dado pelo cedente")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERACAO_NUMERO_TITULO_DADO_PELO_CEDENTE = 104,
	[Description("Tarifa de aviso de cobrança")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_AVISO_DE_COBRANCA = 105,
	[Description("Título enviado para cartório")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	TITULO_ENVIADO_PARA_CARTORIO = 106,
	[Description("Sustar protesto")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	SUSTAR_PROTESTO2 = 107,
	[Description("Devolvido pelo cartório - erro de informação")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	DEVOLVIDO_PELO_CARTORIO = 108,
	[Description("Confirmação do pedido de alteração de outros dados")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS = 109,
	[Description("Baixa rejeitada")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	BAIXA_REJEITADA = 110,
	[Description("Tarifa de extrato posição B40X")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_EXTRATO_POSICAO_B40X = 111,
	[Description("Sustação de protesto")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	SUSTACAO_DE_PROTESTO = 112,
	[Description("Número do cedente ou controle do participante alterado")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	NUMERO_CEDENTE_CONTROLE_PARTICIPANTE_ALTERADO = 113,
	[Description("Débito de tarifas e custas")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DEBITO_DE_TARIFA_CUSTAS = 114,
	[Description("Manutenção de título vencido")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	MANUTENCAO_DE_TITULO_VENCIDO = 115,
	[Description("Tarifa de relação das liquidações")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_RELACAO_DE_LIQUIDACOES = 116,
	[Description("Estorno de protesto")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ESTORNO_DE_PROTESTO = 117,
	[Description("Ocorrências do sacado")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	OCORRENCIAS_DO_SACADO = 118,
	[Description("Tarifa de manutenção de títulos vencidos")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_MANUTENCAO_DE_TITULOS_VENCIDOS = 119,
	[Description("Estorno de sustação de protesto")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ESTORNO_DE_SUSTACAO_DE_PROTESTO = 120,
	[Description("Alteração de dados rejeitada")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ALTERACAO_DE_DADOS_REJEITADA = 121,
	[Description("Débito mensal de tarifas")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_DE_TARIFAS = 122,
	[Description("Alteração de título")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ALTERACAO_DE_TITULO = 123,
	[Description("Cobrança a creditar (liquidação em trânsito)")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	COBRANCA_A_CREDITAR2 = 124,
	[Description("Conceder desconto")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	CONCEDER_DESCONTO = 125,
	[Description("Tarifa sobre título vencido")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	TARIFA_SOBRE_TITULO_VENCIDO = 126,
	[Description("Título em trânsito pago em cartório")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	TITULO_EM_TRANSITO_PAGO_EM_CARTORIO = 127,
	[Description("Transferência de carteira rejeitada")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	TRANSFERENCIA_CARTEIRA_REJEITADA = 128,
	[Description("Liquidação normal em cheque/compensação/banco correspondente")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_NORMAL_EM_CHEQUE_COMPENSACAO_BANCO_CORRESPONDENTE = 129,
	[Description("Instrução rejeitada")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	INSTRUCAO_REJEITADA2 = 131,
	[Description("Baixa por ter sido protestado")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BAIXA_POR_TER_SIDO_PROTESTADO = 132,
	[Description("Outras tarifas de alteração")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	OUTRAS_TARIFAS_DE_ALTERACAO = 133,
	[Description("Reembolso e transferência Desconto e Vendor ou carteira em garantia")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	REEMBOLSO_E_TRANSFERENCIA_DESCONTO_VENDOR = 134,
	[Description("Liquidação em cartório em cheque")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_EM_CARTORIO_EM_CHEQUE = 135,
	[Description("Confirmação da alteração dos dados do rateio de crédito")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_ALTERACAO_DOS_DADOS_DO_RATEIO_DE_CREDITO = 136,
	[Description("Retificar desconto")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	RETIFICAR_DESCONTO = 137,
	[Description("Confirmação de pedido de alteração de outros dados")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS = 138,
	[Description("Custas de protesto")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_PROTESTO = 139,
	[Description("Estorno de baixa/liquidação")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ESTORNO_DE_BAIXA_LIQUIDACAO = 140,
	[Description("Reembolso e devolução Desconto e Vendor")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	REEMBOLSO_DEVOLUCAO_DESCONTO_VENDOR = 141,
	[Description("Liquidação por conta em cheque")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_POR_CONTA_EM_CHEQUE = 142,
	[Description("Confirmação do cancelamento doa dados do rateio de crédito")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_CANCELAMENTO_DOS_DADOS_DO_RATEIO_DE_CREDITO = 143,
	[Description("Alterar data para desconto")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERAR_DATA_PARA_DESCONTO = 144,
	[Description("Retirado de cartório e manutenção em carteira")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	RETIRADO_DE_CARTORIO_E_MANUTENCAO_EM_CARTEIRA = 145,
	[Description("Custas de sustação")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_SUSTACAO = 146,
	[Description("Tarifas diversas")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	TARIFAS_DIVERSAS = 147,
	[Description("Reembolso não efetuado por falta de saldo")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	REEMBOLSO_NAO_EFETUADO_POR_FALTA_DE_SALDO = 148,
	[Description("Confirmação do desagendamento do débito automático")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO = 149,
	[Description("Cobrar multa")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	COBRAR_MULTA = 150,
	[Description("Custas de cartório distribuidor")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_CARTORIO_DISTRIBUIDOR = 151,
	[Description("Confirmação de inclusão no banco de sacado")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	CONFIRMACAO_INCLUSAO_BANCO_SACADO = 152,
	[Description("Aceite do pagador")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_CNAB400 })]
	ACEITE_DO_PAGADOR = 153,
	[Description("Título DDA reconhecido pelo pagador")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_DDA_RECONHECIDO_PELO_PAGADOR = 154,
	[Description("Confirmação de exclusão no banco de sacado")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	CONFIRMACAO_EXCLUSAO_BANCO_SACADO = 155,
	[Description("Confirmação de envio de email ou sms")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS = 156,
	[Description("Dispensar multa")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DISPENSAR_MULTA = 157,
	[Description("Custas de edital")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_EDITAL = 158,
	[Description("Confirmação de alteração no banco de sacado")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	CONFIRMACAO_ALTERACAO_BANCO_SACADO = 159,
	[Description("Baixa rejeitada")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN748_FEBRABAN240 })]
	BAIXA_REJEITADA2 = 160,
	[Description("Título DDA não reconhecido pelo pagador")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_DDA_NAO_RECONHECIDO_PELO_PAGADOR = 161,
	[Description("Liquidação - baixado/devolvido em data anterior com cheque")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_BAIXADO_DEVOLVIDO_DATA_ANTERIOR_COM_CHEQUE = 162,
	[Description("Envio de email ou sms rejeitado")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ENVIO_DE_EMAIL_SMS_REJEITADO = 163,
	[Description("Dispensar indexador")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DISPENSAR_INDEXADOR = 164,
	[Description("Tarifa de emissão de boleto/Tarifa de envio de duplicata")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_EMISSAO_DE_BOLETO = 165,
	[Description("Título DDA recusado pela CIP")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	TITULO_DDA_RECUSADO_PELA_CIP = 166,
	[Description("Baixa de título protestado")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	BAIXA_TITULO_PROTESTADO = 167,
	[Description("Confirmação de alteração do prazo limite de recebimento")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_ALTERACAO_DO_PRAZO_LIMITE_DE_RECEBIMENTO = 168,
	[Description("Dispensar prazo limite para recebimento")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DISPENSAR_PRAZO_LIMITE_PARA_RECEBIMENTO = 169,
	[Description("Tarifa de instrução")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_INSTRUCAO = 170,
	[Description("Emissão de bloquetos de banco de sacado")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	EMISSAO_BLOQUETOS_BANCO_SACADO = 171,
	[Description("Recebimento da instrução não protestar")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	RECEBIMENTO_DA_INSTRUCAO_NAO_PROTESTAR = 172,
	[Description("Liquidação de título não registrado em dinheiro")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_TITULO_NAO_REGISTRADO_EM_DINHEIRO = 173,
	[Description("Confirmação de dispensa de prazo limite de recebimento")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_DISPENSA_DE_PRAZO_LIMITE_DE_RECEBIMENTO = 174,
	[Description("Alterar prazo limite para recebimento")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERAR_PRAZO_LIMITE_PARA_RECEBIMENTO = 175,
	[Description("Tarifa de ocorrências")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_DE_OCORRENCIAS = 176,
	[Description("Manutenção de sacado rejeitada")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	MANUTENCAO_SACADO_REJEITADA = 177,
	[Description("Liquidação de título não registrado em cheque")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	LIQUIDACAO_TITULO_NAO_REGISTRADO_EM_CHEQUE = 178,
	[Description("Confirmação da alteração do número do título dado pelo cedente")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_ALTERACAO_DO_NUMERO_DO_TITULO_DADO_PELO_CEDENTE = 179,
	[Description("Estorno de pagamento")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ESTORNO_DE_PAGAMENTO = 180,
	[Description("Tarifa mensal de emissão de boleto")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_DE_EMISSAO_DE_BOLETO = 181,
	[Description("Entrada de título via banco de sacado rejeitada")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	ENTRADA_TITULO_VIA_BANCO_SACAD0_REJEITADA = 182,
	[Description("Baixa de títulos protestados")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN422_CNAB400
	})]
	BAIXA_TITULOS_PROTESTADOS = 183,
	[Description("Confirmação da alteração do número de controle do participante")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_ALTERACAO_DO_NUMERO_CONTROLE_DO_PARTICIPANTE = 184,
	[Description("Débito mensal de tarifas - extrato de posição B4EP/B4OX")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFAS_EXTRATO_POSICAO_B4EP_B4OX = 185,
	[Description("Manutenção de banco de sacado rejeitada")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	MANUTENCAO_BANCO_SACADO_REJEITADA = 186,
	[Description("Despesa de aponte")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	DESPESA_DE_APONTE = 187,
	[Description("Confirmação da alteração dos dados do sacado")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_ALTERACAO_DOS_DADOS_DO_SACADO = 188,
	[Description("Débito mensal de tarifas - outras instruções")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEMITO_MENSAL_TARIFAS_OUTRAS_INSTRUCOES = 189,
	[Description("Alteração de título")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	ALTERACAO_TITULO = 190,
	[Description("Título retirado do cartório")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_RETIRADO_CARTORIO = 299,
	[Description("Confirmação da alteração dos dados do sacador avalista")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_ALTERACAO_DOS_DADOS_DO_SACADOR_AVALISTA = 191,
	[Description("Débito mensal de tarifas - manutenção de títulos vencidos")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFAS_MANUTENCAO_DE_TITULOS_VENCIDOS = 192,
	[Description("Relação de títulos")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	RELACAO_DE_TITULOS = 193,
	[Description("Título pago com cheque devolvido")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_PAGO_COM_CHEQUE_DEVOLVIDO = 194,
	[Description("Débito mensal de tarifas - outras ocorrências")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFAS_OUTRAS_OCORRENCIAS = 195,
	[Description("Estorno de baixa/liquidação")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	ESTORNO_BAIXA_LIQUIDACAO = 196,
	[Description("Manutenção mensal")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	MANUTENCAO_MENSAL = 197,
	[Description("Aceite do título DDA pelo pagador")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ACEITE_TITULO_DDA = 300,
	[Description("Título pago com cheque compensado")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_PAGO_COM_CHEQUE_COMPENSADO = 198,
	[Description("Débito mensal de tarifas - protesto")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFAS_PROTESTO = 199,
	[Description("Aletração de dados")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	ALTERACAO_DE_DADOS = 200,
	[Description("Sustação de cartório e envio de título a cartório")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	SUSTACAO_CARTORIO_E_ENVIO_TITULO_CARTORIO = 201,
	[Description("Não aceite do título DDA pelo pagador")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NAO_ACEITE_TITULO_DDA = 301,
	[Description("Instrução para cancelar protesto confirmada")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	INSTRUCAO_PARA_CANCELAR_PROTESTO_CONFIRMADA = 202,
	[Description("Título pago com cheque aguardando compensação")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO = 203,
	[Description("Débito mensal de tarifas - sustação de protesto")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFAS_SUSTACAO_PROTESTO = 204,
	[Description("Fornecimento de formulário pré-impresso")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	FORNECIMENTO_DE_FORMULARIO_PRE_IMPRESSO = 205,
	[Description("Instrução para protesto para fins falimentares confirmada")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	INSTRUCAO_PARA_PROTESTO_PARA_FINS_FALIMENTARES_CONFIRMADA = 206,
	[Description("Baixa com transferência para desconto")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BAIXA_COM_TRANSFERENCIA_PARA_DESCONTO = 207,
	[Description("Confirmação de entrada - Pagador DDA")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN041_CNAB400 })]
	CONFIRMACAO_DE_ENTRADA_PAGADOR_DDA = 208,
	[Description("Confirmação de instrução de transferência de carteira de cobrança")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_INSTRUCAO_DE_TRANSFERENCIA_DE_CARTEIRA_DE_COBRANCA = 209,
	[Description("Custas de sustação judicial")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_SUSTACAO_JUDICIAL = 210,
	[Description("Alteração de contrato de cobrança")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	ALTERACAO_DE_CONTRATO_DE_COBRANCA = 211,
	[Description("Vencimento alterado")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	VENCIMENTO_ALTERADO2 = 212,
	[Description("Título pago com cheque pendente de liquidação")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_PAGO_COM_CHEQUE_PENDENTE_DE_LIQUIDACAO = 213,
	[Description("Título DDA reconhecido pelo sacado")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_DDA_RECONHECIDO_PELO_SACADO = 214,
	[Description("Tarifa mensal referente a entrada de bancos correspondentes na carteira")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_ENTRADA_BANCOS_CORRESPONDENTES_NA_CARTEIRA = 215,
	[Description("Entrada rejeitada")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN004_CNAB400 })]
	ENTRADA_REJEITADA2 = 216,
	[Description("Valor do título alterado")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_TITULO_ALTERADO = 302,
	[Description("Título DDA não reconhecido pelo sacado")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_DDA_NAO_RECONHECIDO_PELO_SACADO = 217,
	[Description("Tarifa mensal baixas na carteira")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_BAIXAS_NA_CARTEIRA = 218,
	[Description("Acerto de data de emissão")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ACERTO_DATA_EMISSAO = 303,
	[Description("Título DDA recusado pelo CIP")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	TITULO_DDA_RECUSADO_PELO_CIP = 219,
	[Description("Tarifa mensal baixas em bancos correspondentes na carteira")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_BAIXAS_EM_BANCOS_CORRESPONDENTES_NA_CARTEIRA = 220,
	[Description("Acerto de código espécie documento")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ACERTO_ESPECIE_DOCUMENTO = 304,
	[Description("Confirmação da instrução de baixa de título negativado sem protesto")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DA_INSTRUCAO_DE_BAIXA_DE_TITULO_NEGATIVADO_SEM_PROTESTO = 221,
	[Description("Tarifa mensal de liquidações em carteira")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_DE_LIQUIDACOES_EM_CARTEIRA = 222,
	[Description("Alteração do seu número")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ALTERACAO_SEU_NUMERO2 = 305,
	[Description("Confirmação de pedido de dispensa de multa")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DE_PEDIDO_DE_DISPENSA_DE_MULTA = 223,
	[Description("Sustado judicial")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	SUSTADO_JUDICIAL = 224,
	[Description("Tarifa mensal de liquidações em bancos correspondentes na carteira")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_MENSAL_DE_LIQUIDACOES_EM_BANCOS_CORRESPONDENTES_NA_CARTEIRA = 225,
	[Description("Confirmação do pedido de cobrança de multa")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_COBRANCA_DE_MULTA = 226,
	[Description("Custas de irregularidade")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CUSTAS_DE_IRREGULARIDADE = 227,
	[Description("Instrução de negativação aceita")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_NEGATIVACAO_ACEITA = 306,
	[Description("Confirmação do pedido de alteração de cobrança de juros")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_ALTERACAO_DE_COBRANCA_DE_JUROS = 228,
	[Description("Instru;áo de baixa de negativa;áo aceita")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_BAIXA_E_NEGATIVACAO_ACEITA = 307,
	[Description("Instrução cancelada")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_CANCELADA = 229,
	[Description("Confirmação do pedido de alteração do valor ou data de desconto")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_ALTERACAO_DO_VALOR_DATA_DE_DESCONTO = 230,
	[Description("Instrução não negativar aceita")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_NAO_NEGATIVAR_ACEITA = 308,
	[Description("Confirmação do pedido de alteração do cedente do título")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_ALTERACAO_DO_CEDENTE_DO_TITULO = 231,
	[Description("Baixa por crédito em conta corrente através do SISPAG")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	BAIXA_POR_CREDITO_EM_CONTA_CORRENTE_ATRAVES_SISPAG = 232,
	[Description("Confirmação do pedido de dispensa de juros e mora")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CONFIRMACAO_DO_PEDIDO_DE_DISPENSA_DE_JUROS_DE_MORA = 233,
	[Description("Entrada rejeitada carnê")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ENTRADA_REJEITADA_CARNE = 234,
	[Description("Tarifa emissão aviso de movimentação de títulos")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TARIFA_EMISSAO_AVISO_MOVIMENTACAO_DE_TITULOS = 235,
	[Description("Confirmação de alteração do valor nominal do título")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	CONFIRMACAO_ALTERACAO_VALOR_NOMINAL = 295,
	[Description("Débito mensal de tarifa - aviso de movimentação de títulos")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEBITO_MENSAL_TARIFA_AVISO_MOVIMENTACAO_TITULOS = 236,
	[Description("Título sustado judicialmente")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TITULO_SUSTADO_JUDICIALMENTE = 237,
	[Description("Entrada confirmada com rateio de crédito")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	ENTRADA_CONFIRMADA_COM_RATEIO_DE_CREDITO = 238,
	[Description("Confirmação da alteração")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	CONFIRMACAO_ALTERACAO = 276,
	[Description("Confirmação da alteração do valor mínimo/percentual")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	CONFIRMACAO_ALTERACAO_VALOR_MINIMO = 296,
	[Description("Cancelamento de SMS")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	CANCELAMENTO_DE_SMS = 288,
	[Description("Boleto descontado na cooperativa")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	BOLETO_DESCONTADO_NA_COOPERATIVA = 277,
	[Description("Confirmação da alteração do valor máximo/percentual")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	CONFIRMACAO_ALTERACAO_VALOR_MAXIMO = 297,
	[Description("Cancelamento")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	CANCELAMENTO = 278,
	[Description("Alteração rejeitada")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	ALTERACAO_REJEITADA = 279,
	[Description("Acerto dos dados de rateio de crédito")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ACERTO_DOS_DADOS_RATEIO_CREDITO = 239,
	[Description("Cancelamento dos dados de rateio")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CANCELAMENTO_DOS_DADOS_DE_RATEIO = 240,
	[Description("Cheque devolvido")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CHEQUE_DEVOLVIDO = 241,
	[Description("Despesas/custas de cartório")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	DESPESAS_CUSTAS_DE_CARTORIO = 242,
	[Description("Ressarcimento sobre títulos")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	RESSARCIMENTO_SOBRE_TITULOS = 243,
	[Description("Entrada registrada, aguardando avaliação")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	ENTRADA_REGISTRADA_AGUARDANDO_AVALIACAO = 244,
	[Description("Instrução não permitida para título em garantia de operação")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	INSTRUCAO_NAO_PERMITIDA_PARA_TITULO_GARANTIA_OPERACAO = 245,
	[Description("Alteração de tipo de cobrança")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	ALTERACAO_DO_TIPO_DE_COBRANCA = 246,
	[Description("Baixa por crédito em conta corrente através do SISPAG sem título correspondente")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	BAIXA_POR_CREDITO_EM_CC_ATRAVES_SISPAG_SEM_TITULO_CORRESPONDENTE = 247,
	[Description("Concessão de desconto aceito")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CONCESSAO_DESCONTO_ACEITO = 248,
	[Description("Confirmação de instrução de parâmetro de pagamento parcial")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	CONFIRMACAO_DE_INSTRUCAO_DE_PARAMETRO_DE_PAGAMENTO_PARCIAL = 249,
	[Description("Confirmação de entrada na cobrança simples - entrada não aceita na cobrança contratual")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CONFIRMACAO_ENTRADA_COBRANCA_SIMPLES = 250,
	[Description("Cancelamento de condição de desconto fixo aceito")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CANCELAMENTO_CONDICAO_DESCONTO_FIXO_ACEITO = 251,
	[Description("Confirmação Recebimento de pedido de negativação")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	CONFIRMACAO_RECEBIMENTO_PEDIDO_NEGATIVACAO = 286,
	[Description("Instrução de negativação expressa rejeitada")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	INSTRUCAO_DE_NEGATIVACAO_EXPRESSA_REJEITADA = 252,
	[Description("Cancelamento de desconto diário aceito")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_CNAB400 })]
	CANCELAMENTO_DESCONTO_DIARIO_ACEITO = 253,
	[Description("Confirmação do pedido de exclusão de negativação")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	CONFIRMACAO_PEDIDO_EXCLUSAO_NEGATIVACAO = 287,
	[Description("Confirma o recebimento de instrução de entrada em negativação expressa")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_ENTRADA_NEGATIVACAO_EXPRESSA = 254,
	[Description("Cheque compensado")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	CHEQUE_COMPENSADO = 255,
	[Description("Liquidação de boleto cooperativa emite e expede")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	LIQUIDACAO_DE_BOLETO_COOPERATIVA_EMITE_E_EXPEDE = 289,
	[Description("Confirma o recebimento de instrução de exclusão de entrada em negativação expressa")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_EXCLUSAO_ENTRADA_NEGATIVACAO_EXPRESSA = 256,
	[Description("Liquidação de boleto após baixa ou não registrado cooperativa emite e expede")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	LIQUIDACAO_DE_BOLETO_APOS_BAIXA_OU_NAO_REGISTRADO = 290,
	[Description("Confirma o recebimento de instrução de cancelamento de negativação expressa")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_CANCELAMENTO_NEGATIVACAO_EXPRESSA = 257,
	[Description("Negativação expressa informal")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	NEGATIVACAO_EXPRESSA_INFORMAL = 258,
	[Description("Tarifa - Confirmação de entrada em negativação expressa")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_CONFIRMACAO_ENTRADA_NEGATIVACAO_EXPRESSA = 259,
	[Description("Tarifa -  Confirmação o cancelamento de negativação expressa")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_CONFIRMACAO_CANCELAMENTO_NEGATIVACAO_EXPRESSA = 260,
	[Description("Tarifa - confirmação da exclusão/cancelamento da negativação expressa por liquidação")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_CONFIRMACAO_EXCLUSAO_NEGATIVACAO_EXPRESSA_POR_LIQUIDACAO = 261,
	[Description("Tarifa por boleto (até 3 envios) cobrança ativa eletrônica")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_POR_BOLETO_COBRANCA_ATIVA_ELETRONICA = 262,
	[Description("Tarifa email cobrança ativa eletrônica")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_EMAIL_COBRANCA_ATIVA_ELETRONICA = 263,
	[Description("Tarifa SMS cobrança ativa eletrônica")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_SMS_COBRANCA_ATIVA_ELETRONICA = 264,
	[Description("Tarifa mensal por boleto (até 3 envios) cobrança ativa eletrônica")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_POR_BOLETO_COBRANCA_ATIVA_ELETRONICA = 265,
	[Description("Tarifa mensal email cobrança ativa eletrônica")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_EMAIL_COBRANCA_ATIVA_ELETRONICA = 266,
	[Description("Tarifa mensal SMS cobranaça ativa eletrônica")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_SMS_COBRANCA_ATIVA_ELETRONICA = 267,
	[Description("Tarifa mensal de exclusão de entrada em negativação  expressa")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_EXCLUSAO_ENTRADA_EM_NEGATIVACAO_EXPRESSA = 268,
	[Description("Título em aberto não enviado ao pagador")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR = 291,
	[Description("Tarifa mensal de cancelamento de negativação expressa")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_DE_CANCELAMENTO_DE_NEGATIVACAO_EXPRESSA = 269,
	[Description("Inconsistência negativação Serasa")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	INCONSISTENCIA_NEGATIVACAO_SERASA = 292,
	[Description("Tarifa mensal de exclusão/cancelamento de negativação expressa por liquidação")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	TARIFA_MENSAL_EXCLUSAO_DE_NEGATIVACAO_EXPRESSA_POR_LIQUIDACAO = 270,
	[Description("Inclusão negativação via Serasa")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	INCLUSAO_NEGATIVACAO_VIA_SERASA = 293,
	[Description("Confirma recebimento de instrução de não negativar")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_FEBRABAN240 })]
	CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR = 271,
	[Description("Exclusão negativação via Serasa")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	EXCLUSAO_NEGATIVACAO_VIA_SERASA = 294,
	[Description("Despesas de protesto")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DESPESAS_DE_PROTESTO = 272,
	[Description("Despesas de sustação de protesto")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DESPESAS_DE_SUSTACAO_DE_PROTESTO = 273,
	[Description("Débito de custas antecipadas")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR643 })]
	DEBITO_DE_CUSTAS_ANTECIPADAS = 274,
	[Description("Instrução de protesto processada")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN021_CNAB400 })]
	INSTRUCAO_PROTESTO_PROCESSADA = 311,
	[Description("Rejeição do título")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN104_CNAB400
	})]
	REJEICAO_DO_TITULO = 275
}
