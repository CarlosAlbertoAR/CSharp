using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumMotivoOcorrencia
{
	[Description("Baixa por pagamento")]
	[AtributoDominio("AA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	BAIXA_POR_PAGAMENTO = 0,
	[Description("Tarifa de formulário pré-impresso")]
	[AtributoDominio("AA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TARIFA_DE_FORMULARIO_PRE_IMPRESSO = 1,
	[Description("Pagador DDA")]
	[AtributoDominio("A4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	PAGADOR_DDA = 2,
	[Description("Registro rejeitado - título já liquidado")]
	[AtributoDominio("A5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	TITULO_JA_LIQUIDADO2 = 1124,
	[Description("Título já se encontra na situação pretendida")]
	[AtributoDominio("A7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	TITULO_JA_ESTA_SITUACAO_PRETENDIDA = 1125,
	[Description("Saldo insuficiente para o envio do SMS")]
	[AtributoDominio("B2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SALDO_INSUFICIENTE_ENVIO_SMS = 1127,
	[Description("Pacote de SMS não renovado")]
	[AtributoDominio("B3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	PACOTE_DE_SMS_RENOVADO = 1128,
	[Description("SMS não entregue ao destinatário")]
	[AtributoDominio("B4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SMS_NAO_ENTREGUE_DESTINATARIO = 1129,
	[Description("Horário limite excedido para o envio de SMS")]
	[AtributoDominio("B5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	HORARIO_LIMITE_EXCEDIDO_PARA_ENVIO_SMS = 1130,
	[Description("Instrução rejeitada para envio de SMS com linha numérica")]
	[AtributoDominio("B6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	INSTRUCAO_REJEITADA_PARA_ENVIO_SMS = 1131,
	[Description("Número do celular do pagador não informado")]
	[AtributoDominio("B7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	NUMERO_CELULAR_PAGADOR_NAO_INFORMADO = 1132,
	[Description("Enviado cooperativa emite e expede")]
	[AtributoDominio("P1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	ENVIADO_COOPERATIVA_EMITE_EXPEDE = 1126,
	[Description("Serviço de SMS cancelado no sistema")]
	[AtributoDominio("S1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SERVICO_SMS_CANCELADO_SISTEMA = 1133,
	[Description("Sempre que a solicitação (inclusão ou exclusão) for efetuada com sucesso")]
	[AtributoDominio("S1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INCLUSAO_NEGATIVACAO_VIA_SERASA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SEMPRE_QUE_SOLICITACAO_EFETUADA_SUCESSO = 1143,
	[Description("Sempre que a solicitação for integrada na Serasa com sucesso")]
	[AtributoDominio("S2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INCLUSAO_NEGATIVACAO_VIA_SERASA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SEMPRE_QUE_SOLICITACAO_INTEGRADA_SERASA = 1144,
	[Description("Sempre que vier retorno do Serasa por decurso de prazo")]
	[AtributoDominio("S3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INCLUSAO_NEGATIVACAO_VIA_SERASA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SEMPRE_QUE_RETORNO_SERASA_DECURSO_PRAZO = 1145,
	[Description("Sempre que o documento for integrado no Serasa com sucesso, quando UF for de São Paulo")]
	[AtributoDominio("S4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INCLUSAO_NEGATIVACAO_VIA_SERASA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SEMPRE_QUE_DOCUMENTO_INTEGRADO_SERASA_SP = 1146,
	[Description("Sempre quando houver ação judicial, restringindo a negativação do boleto")]
	[AtributoDominio("S5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INCLUSAO_NEGATIVACAO_VIA_SERASA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_NAO_NEGATIVAR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	SEMPRE_QUE_HOUVER_ACAO_JUDICIAL = 1147,
	[Description("Ocorrência aceita")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	OCORRENCIA_ACEITA = 3,
	[Description("Título pago com dinheiro")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_PAGO_COM_DINHEIRO = 4,
	[Description("Baixado conforme instruções da agência")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	BAIXADO_CONFORME_INSTRUCOES_AGENCIA = 5,
	[Description("Por meio magnético")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_MEIO_MAGNETICO = 6,
	[Description("Solicitada pelo cliente")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumChaveContexto.BAN001_CBR643
	})]
	SOLICITADA_PELO_CLIENTE = 7,
	[Description("Transferência de título de cobrança simples para descontada ou vice-versa")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_DO_TIPO_DE_COBRANCA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TRANSFERENCIA_TITULO_COBRANCA_SIMPLES_PARA_DESCONTADA = 8,
	[Description("Remessa para rateio aceita, título aguardando rateio")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	REMESSA_PARA_RATEIO_ACEITA = 9,
	[Description("Remessa em duplicidade")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	REMESSA_EM_DUPLICIDADE = 1153,
	[Description("Código do banco inválido")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
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
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_BANCO_INVALIDO = 10,
	[Description("Valor do desconto não informado ou inválido")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_DESCONTO_NAO_INFORMADO_OU_INVALIDO = 11,
	[Description("Tarifa de extrato de posição")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_EXTRATO_DE_POSICAO = 12,
	[Description("Por saldo")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	POR_SALDO = 13,
	[Description("Instrução ou ocorrência não existe")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_OCORRENCIA_NAO_EXISTE = 14,
	[Description("Liquidação normal")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_NORMAL = 15,
	[Description("Identificação inválida")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	IDENTIFICACAO_INVALIDA = 16,
	[Description("Código da carteira não numérico")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CODIGO_CARTEIRA_NAO_NUMERICO = 17,
	[Description("Movimento sem beneficiário correspondente")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_SEM_BENEFICIARIO_CORRESPONDENTE = 18,
	[Description("Alteração de carteira")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ALTERACAO_CARTEIRA = 19,
	[Description("Código de cedente do beneficiário inválido")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CODIGO_CEDENTE_BENEFICIARIO_INVALIDO = 20,
	[Description("Falta valor do IOC")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VALOR_IOC = 21,
	[Description("Pagador mudou-se")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	PAGADOR_MUDOU_SE = 1134,
	[Description("Erro na sequência do registro")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ERRO_NA_SEQUENCIA_REGISTRO = 1154,
	[Description("Código do registro de detalhe inválido")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
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
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_REGISTRO_DETALHE_INVALIDO = 22,
	[Description("Inexistência da agência do HSBC na praça do sacado")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	INEXISTENCIA_AGENCIA_PRACA_SACADO = 23,
	[Description("Tarifa de permanência de título cadastrado")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_PERMANENCIA_TITULO_CADASTRADO = 24,
	[Description("Por conta")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	POR_CONTA = 25,
	[Description("Liquidação parcial")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_PARCIAL = 26,
	[Description("Agência cobradora inválida ou com o mesmo conteúdo")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_COBRADORA_INVALIDA = 27,
	[Description("Variação da carteira inválida")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VARIACAO_CARTEIRA_INVALIDA = 28,
	[Description("Agência/Conta/Número de controle - inválido cobrança partilhada")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN041_CNAB400
	})]
	INVALIDO_COBRANCA_PARTILHADA = 29,
	[Description("Casa lotérica")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CASA_LOTERICA = 30,
	[Description("Movimento sem título correspondente")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_SEM_TITULO_CORRESPONDENTE = 31,
	[Description("Remessa de rateio rejeitada, posição 105 difere de R e acompanha tipo 3")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	REMESSA_RATEIO_REJEITADA = 32,
	[Description("Não permite desconto ou abatimento")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	NAO_PERMITE_DESCONTO_ABATIMENTO = 33,
	[Description("Endereço insuficiente")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	ENDERECO_INSUFICIENTE = 1135,
	[Description("Unidade lotérica")]
	[AtributoDominio("002", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	UNIDADE_LOTERICA = 34,
	[Description("Código de ocorrência inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_OCORRENCIA_INVALIDO = 35,
	[Description("Código do banco inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CODIGO_BANCO_INVALIDO2 = 1155,
	[Description("Tarifa de sustação")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_SUSTACAO = 36,
	[Description("Tarifa de sustação/Exclusão de negativação")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_SUSTACAO_OU_EXCLUSAO_NEGATIVACAO = 1118,
	[Description("Liquidação no guichê de caixa em dinheiro")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	LIQUIDACAO_GUICHE_CAIXA_DINHEIRO = 37,
	[Description("Código do segmento inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_SEGMENTO_INVALIDO = 38,
	[Description("Cep do sacado incorreto ou inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CEP_SACADO_INCORRETO_OU_INVALIDO = 39,
	[Description("Não foi possível atribuir a agência pelo CEP ou CEP inválido ")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ERRO_CAMPO_AGENCIA_COBRADORA = 40,
	[Description("Conta não tem permissão para protestar")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CONTA_NAO_TEM_PERMISSAO_PARA_PROTESTAR = 41,
	[Description("Liquidação por saldo")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_POR_SALDO = 42,
	[Description("Valor dos juros por dia inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_JUROS_DIA_INVALIDO = 43,
	[Description("Agências CAIXA")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	AGENCIAS_CAIXA = 44,
	[Description("Não existe número indicado")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	NAO_EXISTE_NUMERO_INDICADO = 1136,
	[Description("Agências CAIXA")]
	[AtributoDominio("003", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	AGENCIAS_CAIXA2 = 45,
	[Description("Remessa para rateio rejeitada, posição 105 igual a R e não acompanha tipo 3")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	REMESSA_RATEIO_REJEITADA2 = 46,
	[Description("Código do serviço inválido")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	CODIGO_SERVICO_INVALIDO = 47,
	[Description("Beneficiário não cadastrado ")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	BENEFICIARIO_NAO_CADASTRADO = 1156,
	[Description("Código do movimento não permitido para a carteira")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_MOVIMENTO_NAO_PERMITIDO_PARA_CARTEIRA = 48,
	[Description("Tarifa de protesto")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_PROTESTO = 49,
	[Description("Tarifa de protesto/Inclusão negativação")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_PROTESTO_OU_EXCLUSAO_NEGATIVACAO = 1119,
	[Description("Compensação eletrônica")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	COMPENSACAO_ELETRONICA = 50,
	[Description("Sigla do estado inválida")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ERRO_CAMPO_ESTADO = 51,
	[Description("Nosso número em duplicidade num mesmo movimento")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	NOSSO_NUMERO_EM_DUPLICIDADE_MESMO_MOVIMENTO = 52,
	[Description("Liquidação com cheque a compensar")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_COM_CHEQUE_COMPENSAR = 53,
	[Description("Valor do desconto inválido")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_DESCONTO_INVALIDO = 54,
	[Description("Cadastro do cedente não aceita banco correspondente")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CADASTRO_CEDENTE_NAO_ACEITA_BANCO_CORRESPONDENTE = 55,
	[Description("Remessa de rateio rejeitada, posição 105 difere de R ou branco")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	REMESSA_RATEIO_REJEITADA3 = 56,
	[Description("Novo vencimento igual ou menor que o da entrada")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA = 57,
	[Description("Desconhecido")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	DESCONHECIDO = 1137,
	[Description("Compensação eletrônica")]
	[AtributoDominio("004", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	COMPENSACAO_ELETRONICA2 = 58,
	[Description("Registro não é Header")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	REGISTRO_NAO_E_HEADER = 1157,
	[Description("Prazo da operação menor que o prazo mínimo ou maior que o máximo")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ERRO_CAMPO_DATA_VENCIMENTO = 59,
	[Description("Código da ocorrência não numérico")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_OCORRENCIA_NAO_NUMERICO = 60,
	[Description("Tipo de moeda inválido")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TIPO_MOEDA_INVALIDO3 = 61,
	[Description("Tarifa de outras instruções")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_OUTRAS_INSTRUCOES = 62,
	[Description("Código de movimento inválido")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_MOVIMENTO_INVALIDO = 63,
	[Description("Compensação convencional")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	COMPENSACAO_CONVENCIONAL = 64,
	[Description("Data de vencimento inválida ou com o mesmo conteúdo")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA2 = 65,
	[Description("Solicitação de baixa para título já baixado ou liquidado")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SOLICITACAO_BAIXA_TITULO_BAIXADO_LIQUIDADO = 66,
	[Description("Liquidação de título sem registro")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_TITULO_SEM_REGISTRO = 67,
	[Description("Espécie de título inválida para carteira ou variação")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ESPECIE_TITULO_INVALIDA_PARA_CARTEIRA_VARIACAO = 68,
	[Description("Beneficiário principal inativo para rateio")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIO_PRINCIPAL_INATIVO_RATEIO = 69,
	[Description("Novo vencimento igual ao do Título")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA3 = 70,
	[Description("Recusado")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	RECUSADO = 1138,
	[Description("Arquivo não é remessa")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ARQUIVO_NAO_E_REMESSA = 1158,
	[Description("Tarifa de outras ocorrências")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_OUTRAS_OCORRENCIAS = 71,
	[Description("Tipo ou número de inscrição do cedente inválidos")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TIPO_OU_NUMERO_INSCRICAO_CEDENTE_INVALIDOS = 72,
	[Description("Prazo de protesto inválido")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	PRAZO_PROTESTO_INVALIDO2 = 73,
	[Description("Por meio eletrônico")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	POR_MEIO_ELETRONICO = 74,
	[Description("Valor do título com outra alteração simultânea")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_TITULO_OUTRA_ALTERACAO_SIMULTANEA = 75,
	[Description("Nosso número igual a zeros")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	NOSSO_NUMERO_IGUAL_ZEROS = 76,
	[Description("Solicitação de baixa para título não registrado no sistema")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SOLICITACAO_BAIXA_TITULO_NAO_REGISTRADO = 77,
	[Description("Espécie de valor invariável inválido")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ESPECIE_VALOR_INVARIAVEL_INVALIDO = 78,
	[Description("Internet Banking")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	INTERNET_BANKING = 79,
	[Description("Beneficiário inativo para rateio")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIO_INATIVO_RATEIO = 80,
	[Description("Espécie de documento inválida")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	ESPECIE_DOCUMENTO_INVALIDA = 81,
	[Description("Não procurado")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	NAO_PROCURADO = 1139,
	[Description("Internet banking")]
	[AtributoDominio("006", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	INTERNET_BANKING2 = 82,
	[Description("Serviço não é cobrança")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	SERVICO_NAO_E_COBRANCA = 1159,
	[Description("Agência, conta ou dígito inválidos")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	AGENCIA_CONTA_DIGITO_INVALIDOS = 83,
	[Description("Data de vencimento inválida")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA5 = 84,
	[Description("Tarifa de envio de duplicata ao sacado")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TARIFA_ENVIO_DUPLICATA_AO_SACADO = 85,
	[Description("Após feriado local")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	APOS_FERIADO_LOCAL = 86,
	[Description("Cobrança prazo curto - solicitação de baixa para título não registrado no sistema")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	COBRANCA_PRAZO_CURTO_SOLICITACAO_BAIXA_TITULO_NAO_REGISTRADO = 87,
	[Description("Liquidação na apresentação")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_NA_APRESENTACAO = 88,
	[Description("Prefixo da agência usuária inválido")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	PREFIXO_AGENCIA_USUARIA_INVALIDO = 89,
	[Description("Valor do título maior que 10.000.000,00")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_DO_TITULO_MAIOR_QUE_PERMITIDO = 90,
	[Description("Correspondente bancário")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CORRESPONDENTE_BANCARIO = 91,
	[Description("Espécie de documento inexistente")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	ESPECIE_DOCUMENTO_INEXISTENTE = 92,
	[Description("Correspondente CAIXAaqui")]
	[AtributoDominio("007", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	CORRESPONDENTE_CAIXA_AQUI = 93,
	[Description("Ausente")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	AUSENTE = 1140,
	[Description("Conta corrente diferente do registro Heade")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CONTA_CORRENTE_DIFERENTE_REGISTRO_HEADER = 1160,
	[Description("Nosso número inválido")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOSSO_NUMERO_INVALIDO = 94,
	[Description("Custas de protesto")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CUSTAS_PROTESTO = 95,
	[Description("Em cartório")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.COBRANCA_A_CREDITAR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	EM_CARTORIO = 96,
	[Description("Nome do pagador não informado ou deslocado")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_NOME_PAGADOR = 97,
	[Description("Nome do pagador com o mesmo conteúdo")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	NOME_PAGADOR_COM_MESMO_CONTEUDO = 98,
	[Description("Solicitação de baixa para título em floating")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SOLICITACAO_BAIXA_TITULO_FLOATING = 99,
	[Description("Valor do título ou apólice inválido")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_TITULO_APOLICE_INVALIDO = 100,
	[Description("Em cartório")]
	[AtributoDominio("008", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO3,
		EnumChaveContexto.BAN104_CNAB400
	})]
	EM_CARTORIO2 = 101,
	[Description("Movimento para título já com movimentação no dia")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_PARA_TITULO_JA_COM_MOVIMENTACAO_NO_DIA = 102,
	[Description("Código de cálculo de rateio diferente de 1 ou 2")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CODIGO_CALCULO_RATEIO_DIFERENTE_DE_1_OU_2 = 103,
	[Description("Tipo de operação inválida")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TIPO_OPERACAO_INVALIDA = 104,
	[Description("Falecido")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	FALECIDO = 1141,
	[Description("Código de ocorrência inválido")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CODIGO_OCORRENCIA_INVALIDO3 = 1161,
	[Description("Nosso número duplicado")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOSSO_NUMERO_DUPLICADO = 105,
	[Description("Taxa mensal de juros de mora acima do permitido (170%)")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TAXA_MENSAL_JUROS_ACIMA_PERMITIDO = 106,
	[Description("Custas de sustação de protesto")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CUSTAS_SUSTACAO_PROTESTO = 107,
	[Description("Comandada banco")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	COMANDADA_BANCO = 108,
	[Description("Agência encerrada")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_AGENCIA_CONTA = 109,
	[Description("Agência ou conta incorreta")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_CONTA_INCORRETA = 110,
	[Description("CNPJ ou CPF do sacador avalista inválido")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CNPJ_CPF_SACADOR_AVALISTA_INVALIDO = 111,
	[Description("Data vencimento inválida")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DATA_VENCIMENTO_INVALIDA4 = 112,
	[Description("Liquidação em cartório")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_EM_CARTORIO = 113,
	[Description("Nosso número não pertence ao beneficiário")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	NOSSO_NUMERO_NAO_PERTENCE_AO_BENEFICIARIO = 114,
	[Description("Tipo operação inexistente")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TIPO_OPERACAO_INEXISTENTE = 115,
	[Description("Outros")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN085_FEBRABAN240
	})]
	OUTROS = 1142,
	[Description("Comandada banco")]
	[AtributoDominio("009", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA_MANUAL_CONFIRMADA,
		EnumCodigoMovimentoRetorno.BAIXA_POR_DEVOLUCAO,
		EnumCodigoMovimentoRetorno.BAIXA_POR_PROTESTO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	COMANDADA_BANCO2 = 116,
	[Description("Erro na sequência do lote")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ERRO_SEQUENCIA_LOTE = 1162,
	[Description("Carteira inválida")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CARTEIRA_INVALIDA = 117,
	[Description("Taxa de multa acima do permitido (10% mês)")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TAXA_MULTA_ACIMA_PERMITIDO = 118,
	[Description("Baixa comandada pelo cedente")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	BAIXA_COMANDADA_PELO_CLIENTE = 119,
	[Description("Custas de cartório distribuidor")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CUSTAS_CARTORIO_DISTRIBUIDOR = 120,
	[Description("Comandada cliente arquivo")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	COMANDADA_CLIENTE_ARQUIVO = 121,
	[Description("Endereço não informado ou deslocado")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_LOGRADOURO = 122,
	[Description("Valor do abatimento igual ou maior que o valor do título")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_ABATIMENTO_IGUAL_MAIOR_VALOR_TITULO = 123,
	[Description("Valor do título faz parte de garantia de empréstimo")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_TITULO_FAZ_PARTE_GARANTIA_EMPRESTIMO = 124,
	[Description("Liquidação parcial com cheque a compensar")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_PARCIAL_COM_CHEQUE_COMPENSAR = 125,
	[Description("Fora do prazo - admissível apenas na carteira")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	FORA_PRAZO_ADMISSIVEL_APENAS_NA_CARTEIRA = 126,
	[Description("Comandada cliente via arquivo")]
	[AtributoDominio("010", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA_MANUAL_CONFIRMADA,
		EnumCodigoMovimentoRetorno.BAIXA_POR_DEVOLUCAO,
		EnumCodigoMovimentoRetorno.BAIXA_POR_PROTESTO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	COMANDADA_CLIENTE_VIA_ARQUIVO = 127,
	[Description("Inclusão de título já existente na base")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	INCLUSAO_DE_TITULO_JA_EXISTENTE_NA_BASE = 128,
	[Description("Contrato proibido para esta carteira")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	CONTRATO_PROIBIDO_PARA_CARTEIRA = 129,
	[Description("Número do lote do registro Detalhes difere do registro Header")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	NUMERO_LOTE_DETALHES_DIFERE_DO_HEADER = 1163,
	[Description("Forma de cadastramento do título inválida")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	FORMA_CADASTRAMENTO_TITULO_INVALIDA = 130,
	[Description("Data limite de desconto inválida")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_LIMITE_DESCONTO_INVALIDA = 131,
	[Description("Data de geração inválida")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_GERACAO_INVALIDA = 132,
	[Description("Custas de edital")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CUSTAS_EDITAL = 133,
	[Description("Comandada cliente on-line")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	COMANDADA_CLIENTE_ON_LINE = 134,
	[Description("CEP não numérico")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CEP = 135,
	[Description("Liquidação por saldo com cheque a compensar")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_SEM_REGISTRO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_PARCIAL,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_POR_SALDO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.TITULO_PAGO_COM_CHEQUE_AGUARDANDO_COMPENSACAO,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDACAO_POR_SALDO_COM_CHEQUE_COMPENSAR = 136,
	[Description("Por via convencional")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_VIA_CONVENCIONAL = 137,
	[Description("Inexistência de margem para desconto")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	INEXISTENCIA_MARGEM_PARA_DESCONTO = 138,
	[Description("Segunda instrução ou ocorrência não existe")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SEGUNDA_INSTRUCAO_OCORRENCIA_NAO_EXISTE = 139,
	[Description("Pago através do SISPAG por crédito em conta corrente e não baixado")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SEGUNDA_INSTRUCAO_OCORRENCIA_NAO_EXISTE2 = 140,
	[Description("Valor do rateio informado não é numérico")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	VALOR_RATEIO_NAO_NUMERICO = 141,
	[Description("Falta número contrato")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_NUMERO_CONTRATO = 142,
	[Description("Comandada cliente on line")]
	[AtributoDominio("011", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA_MANUAL_CONFIRMADA,
		EnumCodigoMovimentoRetorno.BAIXA_POR_DEVOLUCAO,
		EnumCodigoMovimentoRetorno.BAIXA_POR_PROTESTO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	COMANDADA_CLIENTE_ONLINE = 143,
	[Description("Falta registro de Trailler do arquivo")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	FALTA_REGISTRO_TRAILLER = 1164,
	[Description("Tipo de documento inválido")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TIPO_DOCUMENTO_INVALIDO = 144,
	[Description("Cep inválido ou inexistência de agência")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CEP_INVALIDO2 = 145,
	[Description("Tarifa sobre devolução de título vencido")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_DEVOLUCAO_TITULO_VENCIDO = 146,
	[Description("Decurso de prazo - cliente")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DECURSO_PRAZO_CLIENTE = 147,
	[Description("Nome do sacador avalista não informado ou deslocado")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_SACADOR_AVALISTA = 148,
	[Description("Número de inscrição do sacador avalista inválido")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	NUMERO_INSCRICAO_SACADOR_AVALISTA_INVALIDO = 149,
	[Description("O banco não possui agência na praça do sacado")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	BANCO_NAO_POSSUI_AGENCIA_PRACA_DO_SACADO = 150,
	[Description("Redisponibilização de arquivo de retorno eletrônico")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	REDISPONIBILIZACAO_ARQUIVO_ELETRONICO = 151,
	[Description("Movimento duplicado")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_DUPLICADO = 152,
	[Description("Percentual do rateio informado não é numérico")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	PERCENTUAL_RATEIO_NAO_NUMERICO = 153,
	[Description("Proibido informar tipo de conta")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_INFORMAR_TIPO_CONTA = 154,
	[Description("Número do lote do registro Trailler difere do registro de Header")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	NUMERO_LOTE_TRAILLER_DIFERE_DO_HEADER = 1165,
	[Description("Identificação da emissão do bloqueto inválida")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	IDENTIFICACAO_DA_EMISSAO_DO_BLOQUETO_INVALIDA = 155,
	[Description("Valor/taxa de multa inválida")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_TAXA_MULTA_INVALIDA = 156,
	[Description("Tarifa de título pago no Bradesco")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_NO_BRADESCO = 157,
	[Description("Tarifa sobre registro cobrada na baixa ou liquidação")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_REGISTRO_COBRADA_NA_BAIXA_OU_LIQUIDACAO = 158,
	[Description("Decurso prazo - banco")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
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
	DECURSO_PRAZO_BANCO = 159,
	[Description("CEP incompatível com a sigla do estado")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_ESTADO_CEP = 160,
	[Description("Seu número com o mesmo conteúdo")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SEU_NUMERO_COM_MESMO_CONTEUDO = 161,
	[Description("Razões cadastrais")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	RAZOES_CADASTRAIS = 162,
	[Description("Entrada inválida para cobrança caucionada")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	ENTRADA_INVALIDA_PARA_COBRANCA_CAUCIONADA2 = 163,
	[Description("Tipo de valor informado diferente de 1 ou 2")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	TIPO_VALOR_INFORMADO_DIFERENTE_1_OU_2 = 164,
	[Description("Tipo de conta do contrato inexistente")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TIPO_CONTA_CONTRATO_INEXISTENTE = 165,
	[Description("Título protestado")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[] { EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA })]
	TITULO_PROTESTADO = 166,
	[Description("Tarifa de título pago na compensação")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_COMPENSACAO = 167,
	[Description("Erro na quantidade de registro lote")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ERRO_QUANTIDADE_REGISTRO_LOTE = 1166,
	[Description("Identificação da distribuição do bloqueto inválida")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	IDENTIFICACAO_DISTRIBUICAO_BLOQUETO_INVALIDA = 168,
	[Description("Valor diário de multa não informado")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_DIARIO_MULTA_NAO_INFORMADO = 169,
	[Description("Tarifa sobre reapresentação automática")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_REAPRESENTACAO_AUTOMATICA = 170,
	[Description("Protestado")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PROTESTADO = 171,
	[Description("Nosso número já registrado no cadastro do banco ou fora da faixa")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_NOSSO_NUMERO = 172,
	[Description("Registro em duplicidade")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	REGISTRO_EM_DUPLICIDADE = 173,
	[Description("Sacado interligado com sacador")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	SACADO_INTERLIGADO_SACADOR = 174,
	[Description("Dígito de contrato não confere")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_CONTRATO_NAO_CONFERE = 175,
	[Description("Número do lote do registro Trailler inválido")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	NUMERO_LOTE_REGISTRO_TRAILLER_INVALIDO = 1167,
	[Description("Características de cobrança incompatíveis")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CARACTERISTICAS_DE_COBRANCA_INCOMPATIVEIS = 176,
	[Description("Quantidade de dias após vencimento para incidência de multa não informado")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DIAS_MULTA_APOS_VENCIMENTO_NAO_INFORMADO = 177,
	[Description("Título pago com cheque")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_PAGO_COM_CHEQUE = 178,
	[Description("Título excluído")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TITULO_EXCLUIDO = 179,
	[Description("Carteira, agência, conta ou nosso número inválidos")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CARTEIRA_AGENCIA_CONTA_NOSSO_NUMERO_INVALIDOS = 180,
	[Description("Tarifa de título baixado ou não pago")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_NAO_PAGO = 181,
	[Description("Tarifa sobre rateio de crédito")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_RATEIO_CREDITO = 182,
	[Description("Nosso número em duplicidade no mesmo movimento")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_NOSSO_NUMERO2 = 183,
	[Description("CNPJ ou CPF informado sem nome do sacador avalista")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CNPJ_CPF_INFORMADO_SEM_NOME_SACADOR_AVALISTA = 184,
	[Description("Protestado")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumChaveContexto.BAN001_CBR643
	})]
	PROTESTADO2 = 185,
	[Description("Título sacado contra órgão do poder público")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_SACADO_CONTRA_ORGAO_PODER_PULICO = 186,
	[Description("Banco de sacados")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	BANCO_SACADOS = 187,
	[Description("Contrato inexistente")]
	[AtributoDominio("15", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	CONTRATO_INEXISTENTE = 188,
	[Description("Erro na quantidade de lotes do arquivo")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ERRO_QUANTIDADE_LOTES_ARQUIVO = 1168,
	[Description("Data de vencimento inválida")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA6 = 189,
	[Description("Outras irregularidades")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	OUTRAS_IRREGULARIDADES = 190,
	[Description("Título baixado pelo banco por decurso de prazo")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[] { EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA })]
	TITULO_BAIXADO_PELO_BANCO_POR_DECURSO_PRAZO = 191,
	[Description("Tarifa de alteração de vencimento")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_ALTERACAO_VENCIMENTO = 192,
	[Description("Tarifa sobre informações via fax")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_INFORMACOES_VIA_FAX = 193,
	[Description("Abatimento ou alteração de valor do título ou solicitação de baixa bloqueados")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.COBRANCA_CONTRATUAL,
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ABATIMENTO_ALTERACAO_VALOR_TITULO = 194,
	[Description("Por alteração do código cedente")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_ALTERACAO_CODIGO_CEDENTE = 195,
	[Description("Título preenchido de forma irregular")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_PREENCHIDO_FORMA_IRREGULAR = 196,
	[Description("Data de emissão inválida")]
	[AtributoDominio("16", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_EMISSAO_INVALIDA = 197,
	[Description("Código do segmento fora de ordem")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CODIGO_SEGMENTO_FORA_ORDEM = 1169,
	[Description("Data de vencimento anterior a data de emissão")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_VENCIMENTO_ANTERIOR_DATA_EMISSAO = 198,
	[Description("Data de início de multa inválida")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_INICIO_MULTA_INVALIDA = 199,
	[Description("Título baixado ou transferido da carteira")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_BAIXADO_TRANSFERIDO_CARTEIRA = 200,
	[Description("Tarifa de concessão de abatimento")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_CONCESSAO_ABATIMENTO = 201,
	[Description("Tarifa sobre prorrogação de vencimento")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_PRORROGACAO_VENCIMENTO = 202,
	[Description("Por alteração da variação")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_ALTERACAO_VARIACAO = 203,
	[Description("Entrega de aviso de disponibilidade de bloqueto via e-mail ao sacado")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ENTREGA_AVISO_DISPONIBILIDADE_BOLETO = 204,
	[Description("Falta valor do título")]
	[AtributoDominio("17", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VALOR_TITULO = 205,
	[Description("Título rasurado")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_RASURADO = 206,
	[Description("Código do registro fora de ordem")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CODIGO_REGISTRO_FORA_DE_ORDEM = 1170,
	[Description("Vencimento fora do prazo de operação")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VENCIMENTO_FORA_DO_PRAZO_DE_OPERACAO = 207,
	[Description("Nosso número já existe para outro título")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NOSSO_NUMERO_JA_EXISTE2 = 208,
	[Description("Tarifa de cancelamento de abatimento")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_CANCELAMENTO_ABATIMENTO = 209,
	[Description("Tarifa sobre alteração de abatimento ou desconto")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_ALETRACAO_ABATIMENTO_DESCONTO = 210,
	[Description("Data de entrada inválida para operar com esta carteira")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DATA_ENTRADA = 211,
	[Description("Por alteração da carteira")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_ALTERACAO_CARTEIRA = 212,
	[Description("Endereço do sacado não localizado ou incompleto")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ENDERECO_SACADO_NAO_LOCALIZADO_OU_INCOMPLETO = 213,
	[Description("Emissão de bloqueto pré-impresso CAIXA matricial")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_BLOQUETO_PRE_IMPRESSO_CAIXA_MATRICIAL = 214,
	[Description("Vencimento inválido")]
	[AtributoDominio("18", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	VENCIMENTO_INVALIDO = 215,
	[Description("Código do registro inválido")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	CODIGO_REGISTRO_INVALIDO = 1171,
	[Description("Título a cargo de bancos correspondentes com vencimento inferior a XX dias")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TITULO_CARGO_BANCOS_CORRESPONDENTES_VENCIMENTO_INFERIOR_XX_DIAS = 216,
	[Description("Valor do título inválido")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_TITULO_INVALIDO2 = 217,
	[Description("Tarifa sobre arquivo mensal")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TARIFA_SOBRE_ARQUIVO_MENSAL = 218,
	[Description("Ocorrência inválida")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_OCORRENCIA = 219,
	[Description("Valor do abatimento maior que 90% do valor do título")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_ABATIMENTO_MAIOR_90_PORCENTO_VALOR_TITULO = 220,
	[Description("Débito automático")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DEBITO_AUTOMATICO = 221,
	[Description("Código do cedente inválido")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CODIGO_CEDENTE_INVALIDO = 222,
	[Description("Emissão de bloqueto pré-impresso CAIXA A4")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_BLOQUETO_PRE_IMPRESSO_CAIXA_A4 = 223,
	[Description("Data de vencimento anterior a emissão")]
	[AtributoDominio("19", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_VENCIMENTO_ANTERIOR_EMISSAO = 224,
	[Description("Valor do título inválido")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VALOR_TITULO_INVALIDO = 225,
	[Description("Ausência Cep ou endereço ou CNPJ do sacador avalista")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	AUSENCIA_CEP_ENDERECO_CNPJ_SACADOR_AVALISTA = 226,
	[Description("Título baixado - transferido para desconto")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_BAIXADO_TRANSFERIDO_PARA_DESCONTO = 227,
	[Description("Tarifa de cancelamento de desconto")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_CANCELAMENTO_DESCONTO = 228,
	[Description("Tarifa sobre emissão de bloqueto pré-emitido pelo banco")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TARIFA_SOBRE_BLOQUETO_PRE_EMITIDO_PELO_BANCO = 229,
	[Description("Existe sustação de protesto pendente para título")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	EXISTE_SUSTACAO_PROTESTO_PENDENTE_PARA_TITULO = 230,
	[Description("Espécie inválida")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ESPECIE_INVALIDA = 231,
	[Description("Nome ou endereço do cliente não informado")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOME_OU_ENDERECO_CLIENTE_NAO_INFORMADO = 232,
	[Description("Emissão de bloqueto padrão CAIXA")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_BLOQUETO_PADRAO_CAIXA = 233,
	[Description("CEP do pagador não encontrado")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	CEP_DO_PAGADOR_NAO_ENCONTRADO = 234,
	[Description("Nome do beneficiário não informado")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	NOME_BENEFICIARIO_NAO_INFORMADO = 235,
	[Description("Falta vencimento desconto")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VENCIMENTO_DESCONTO = 236,
	[Description("Espécie de título inválida")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ESPECIE_TITULO_INVALIDA = 237,
	[Description("Título sem borderô")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TITULO_SEM_BORDERO = 238,
	[Description("Tarifa de título pago CICS")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_CICS = 239,
	[Description("Carteira não aceita depositária correspondente ou estado da agência diferente do estado do pagador ou agência cobradora não consta no cadastro ou encerrado")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_AGENCIA_COBRADORA2 = 240,
	[Description("Agência cobradora não consta no cadastro de depositária ou em encerramento")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_COBRADORA_NAO_CONSTA_CADASTRO = 241,
	[Description("Título não registrado no sistema")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TITULO_NAO_REGISTRADO_SISTEMA = 242,
	[Description("Carteira inválida")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CARTEIRA_INVALIDA2 = 243,
	[Description("Emissão de bloqueto/carnê")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_BLOQUETO_CARNE = 244,
	[Description("Agência cobradora não encontrada")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	AGENCIA_COBRADORA_NAO_ENCONTRADA2 = 245,
	[Description("Quantidade de beneficiários excedeu 90")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	QUANTIDADE_BENEFICIARIOS_EXCEDIDA = 246,
	[Description("Data desconto inválida")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_DESCONTO_INVALIDA = 247,
	[Description("Tarifa de emissão de boletos")]
	[AtributoDominio("21", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	TARIFA_EMISSAO_BOLETOS = 1111,
	[Description("Tarifa liquidação interna")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	TARIFA_LIQUIDACAO_INTERNA = 1112,
	[Description("Espécie não permitida para a carteira")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
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
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ESPECIE_NAO_PERMITIDA_PARA_CARTEIRA = 248,
	[Description("Número da conta do cedente não cadastrado")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NUMERO_CONTA_CEDENTE_NAO_CADASTRADO = 249,
	[Description("Tarifa de título pago pela internet")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_INTERNET = 250,
	[Description("Carteira não permitida")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CARTEIRA = 251,
	[Description("Título baixado ou liquidado")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TITULO_BAIXADO_LIQUIDADO = 252,
	[Description("Quantidade de valor variável inválida")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	QUANTIDADE_DE_VALOR_VARIAVEL_INVALIDA = 253,
	[Description("Agência do beneficiário não encontrada")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	AGENCIA_BENEFICIARIO_NAO_ENCONTRADA = 254,
	[Description("Data de desconto posterior ao vencimento")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_DESCONTO_POSTERIOR_DATA_VENCIMENTO = 255,
	[Description("Tarifa liquidação externa")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	TARIFA_LIQUIDACAO_EXTERNA = 1113,
	[Description("Tarifa de título pago em terminal gerencial de serviços")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_TERMINAL_GERENCIAL_SERVICOS = 256,
	[Description("Aceite inválido")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ACEITE_INVALIDO = 257,
	[Description("Instrução não permitida para título em garantia de operação")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	INSTRUCAO_NAO_PERMITIDA_TITULO_GARANTIA_OPERACAO = 258,
	[Description("Instrução não aceita")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_NAO_ACEITA = 259,
	[Description("Faixa nosso número excedida")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	FAIXA_NOSSO_NUMERO_EXCEDIDA = 260,
	[Description("Data de emissão do título inválida ou com o mesmo conteúdo")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DATA_EMISSAO_TITULO_INVALIDA_OU_COM_MESMO_CONTEUDO = 261,
	[Description("Falta valor desconto")]
	[AtributoDominio("23", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VALOR_DESCONTO = 262,
	[Description("Tarifa baixa manual")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	TARIFA_BAIXA_MANUAL = 1114,
	[Description("Data de emissão inválida")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_EMISSAO_INVALIDA2 = 263,
	[Description("Condição de desconto não permitida para título em garantia de operação")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CONDICAO_DESCONTO_NAO_PERMITIDA_TITULO_GARANTIA_OPERACAO = 264,
	[Description("Tarifa de título pago pelo Pag Contas")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_PAG_CONTAS = 265,
	[Description("Instrução incompatível - existe instrução de protesto para título")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_INCOMPATIVEL_PROTESTO_EXISTENTE = 266,
	[Description("Valor do abatimento inválido")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_ABATIMENTO_INVALIDO = 267,
	[Description("Código de cálculo 1 e beneficiário não informado em percentual")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CODIGO_CALCULO_1_BENEFICIARIO_NAO_INFORMADO_EM_PERCENTUAL = 268,
	[Description("Falta mora dia")]
	[AtributoDominio("24", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_MORA_DIA = 269,
	[Description("Tarifa de cancelamento")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumTipoCarteiraCobranca.BAN097_SIMPLES,
		EnumCodigoMovimentoRetorno.CANCELAMENTO,
		EnumChaveContexto.BAN097_FEBRABAN240
	})]
	TARIFA_CANCELAMENTO = 1115,
	[Description("Tarifa de título pago pelo Fone Fácil")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_FONE_FACIL = 270,
	[Description("Data da emissão posterior a data de entrada")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DATA_EMISSAO_POSTERIOR_DATA_ENTRADA = 271,
	[Description("Utilizada mais de uma instrução de multa")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	UTILIZADA_MAIS_DE_UMA_INSTRUCAO_MULTA = 272,
	[Description("Instrução incompatível - não existe instrução de protesto para título")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_INCOMPATIVEL_NAO_EXISTE_PROTESTO = 273,
	[Description("Novo número do título dado pelo cedente inválido")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOVOA_NUMERO_TITULO_DADO_PELO_CEDENTE_INVALIDO = 274,
	[Description("Beneficiários com códigos de cálculo de rateios diferentes")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIO_COM_CODIGOS_CALCULO_RATEIO_DIFERENTES = 275,
	[Description("banco ou agência cobrador inexistente")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	BANCO_AGENCIA_COBRADOR_INEXISTENTE = 276,
	[Description("Tarifa de título débito postagem")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_DEBITO_POSTAGEM = 277,
	[Description("Código de juros de mora inválido")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_DE_JUROS_DE_MORA_INVALIDO = 278,
	[Description("Ausência do endereço do sacado")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	AUSENCIA_ENDERECO_SACADO = 279,
	[Description("Instrução não aceita por já ter sido emitida a ordem de protesto em cartório")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_NAO_ACEITA_ORDEM_PROTESTO_EMITIDA = 280,
	[Description("Valor do IOF de seguro inválido")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_IOF_SEGURO_INVALIDO = 281,
	[Description("Agência ou conta não liberada para operar com cobrança")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_CONTA_NAO_LIBERADA_COBRANCA = 282,
	[Description("Beneficiários informados em percentual e outros em valor")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIOS_INFORMADOS_EM_VALOR_E_OUTROS_EM_PERCENTUAL = 283,
	[Description("BCO/AGE cobrador não cadastrado")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	BCO_AGE_NAO_CADASTRADO = 284,
	[Description("Valor da taxa de juros inválido")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	VALOR_TAXA_JUROS_INVALIDO = 285,
	[Description("Cep inválido do sacado")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CEP_INVALIDO_SACADO = 286,
	[Description("Tarifa de impressão de títulos pendentes")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_IMPRESSAO_TITULOS_PENDENTES = 287,
	[Description("CNPJ do beneficiário inapto ou devolução de título em garantia")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CNPJ_INAPTO = 288,
	[Description("Instrução não aceita por não ter sido emitida a ordem de protesto ao cartório")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_NAO_ACEITA_ORDEM_PROTESTO_NAO_EMITIDA = 289,
	[Description("Nome do sacado ou cedente invdálido")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOME_SACADO_CEDENTE_INVALIDO = 290,
	[Description("Somatório dos valores dos beneficiários excedeu valor do título")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	SOMATORIO_VALORES_BENEFICIARIOS_EXCEDEU_VALOR_TITULO = 291,
	[Description("Código pessoa inválido")]
	[AtributoDominio("27", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	CODIGO_PESSOA_INVALIDO = 292,
	[Description("Código do desconto inválido")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_DESCONTO_INVALIDO = 293,
	[Description("Ausência do CPF/CNPJ do sacado em título com instrução de protesto")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	AUSENCIA_CPF_CNPJ_SACADO_TITULO_INSTRUCAO_PROTESTO = 294,
	[Description("Tarifa de título pago BDN")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_BDN = 295,
	[Description("Já existe um mesma instrução cadastrada anteriormente para o título")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	JA_EXISTE_MESMA_INSTRUCAO_CADASTRADA_PARA_TITULO = 296,
	[Description("Data do novo venvimento inválida")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DATA_NOVO_VENCIMENTO_INVALIDA = 297,
	[Description("Somatório dos percentuais dos beneficiários excedeu 100%")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	SOMATORIO_PERCENTUAIS_BENEFICIARIOS_EXCEDEU_1OO_PORCENTO = 298,
	[Description("Falta CEP, banco e agência cobrador")]
	[AtributoDominio("28", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_CEP_BANCO_AGENCIA_COBRADOR = 299,
	[Description("Tarifa de título pago em terminal multi função")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_TERMINAL_MULTI_FUNCAO = 300,
	[Description("Valor do desconto maior ou igual ao valor do título")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VALOR_DO_DESCONTO_MAIOR_IGUAL_AO_VALOR_DO_TITULO = 301,
	[Description("Agência do cedente informada inválida")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	AGENCIA_CEDENTE_INFORMADA_INVALIDO = 302,
	[Description("Categoria da conta inválida")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CODIGO_EMPRESA = 303,
	[Description("Valor líquido + valor do abatimento diferente do valor do título registrado")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_LIQUIDO_MAIS_ABATIMENTO_DIFERENTE_VALOR_REGISTRADO = 304,
	[Description("Endereço não informado")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ENDERECO_NAO_INFORMADO = 305,
	[Description("Falta nome do sacado")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_NOME_SACADO = 306,
	[Description("Efetuado acerto no rateio")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	EFETUADO_ACERTO_NO_RATEIO = 307,
	[Description("Alteração de dados rejeitada")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN041_CNAB400
	})]
	ALTERACAO_DE_DADOS_REJEITADA = 1153,
	[Description("Impressão de títulos baixados")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	IMPRESSAO_TITULOS_BAIXADOS = 308,
	[Description("Desconto a conceder não confere")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DESCONTO_A_CONCEDER_NAO_CONFERE = 309,
	[Description("Número da conta do cedente inválido")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NUMERO_CONTA_CEDENTE_INVALIDO = 310,
	[Description("Liquidação no guichê de caixa em cheque")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	LIQUIDACAO_GUICHE_CAIXA_CHEQUE = 311,
	[Description("Existe uma instrução de não protestar ativa para o título")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	EXISTE_INSTRUCAO_DE_NAO_PROTESTAR_ATIVA = 312,
	[Description("Registro do título já liquidado")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	REGISTRO_TITULO_JA_LIQUIDADO = 313,
	[Description("Entradas bloqueadas, conta suspensa em cobrança")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ENTRADAS_BLOQUEADAS = 314,
	[Description("Falta endereço")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_ENDERECO = 315,
	[Description("Impressão de títulos pagos")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	IMPRESSAO_TITULOS_PAGOS = 316,
	[Description("Concessão de desconto já existe")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONCESSAO_DE_DESCONTO_JA_EXISTENTE = 317,
	[Description("Contrato garantia não cadastrado")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CONTRATO_GARANTIA_NAO_CADASTRADO = 318,
	[Description("Liquidação em banco correspondente")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	LIQUIDACAO_EM_BANCO_CORRESPONDENTE = 319,
	[Description("Conta não tem permissão para protestar")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_AGENCIA_CONTA2 = 320,
	[Description("Existe ocorrência do pagador que bloqueia a instrução")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	EXISTE_OCORRENCIA_PAGADOR_QUE_BLOQUEIA_INSTRUCAO = 321,
	[Description("Liquidado anteriormente")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	LIQUIDADO_ANTERIORMENTE = 322,
	[Description("Número do borderô inválido")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NUMERO_BORDERO_INVALIDO = 323,
	[Description("Emissão de aviso de vencido")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_AVISO_DE_VENCIDO = 324,
	[Description("Acerto no rateio rejeitado, beneficiário não participante")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	ACERTO_RATEIO_REJEITADO = 325,
	[Description("Acerto no rateio rejeitado, beneficiário principal não participante")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	ACERTO_RATEIO_REJEITADO2 = 326,
	[Description("Falta cidade")]
	[AtributoDominio("31", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_CIDADE = 327,
	[Description("Tarifa de título pago pelo PagFor")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_PAGFOR = 328,
	[Description("Valor do IOF inválido")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	VALOR_DO_IOF_INVALIDO = 329,
	[Description("Tipo de carteira inválido")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TIPO_CARTEIRA_INVALIDO = 330,
	[Description("Liquidação em terminal de auto-atendimento")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDACAO_TERMINAL_AUTO_ATENDIMENTO = 331,
	[Description("Depositária do título = 9999 ou não aceita protesto")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DEPOSITARIA_TITULO_9999 = 332,
	[Description("Habilitado em processo")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	HABILITADO_EM_PROCESSO = 333,
	[Description("Nome da pessoa autorizada inválido")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOME_PESSOA_AUTORIZADA_INVALIDO = 334,
	[Description("Beneficiário bloqueado para rateio")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIO_BLOQUEADO_PARA_RATEIO = 335,
	[Description("Falta estado")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_ESTADO = 336,
	[Description("Valor do abatimento inválido")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VALOR_DO_ABATIMENTO_INVALIDO = 337,
	[Description("Conta corrente do cedente incompatível")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CONTA_CORRENTE_CEDENTE_INCOMPATIVEL = 338,
	[Description("Liquidação na internet")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDACAO_NA_INTERNET = 339,
	[Description("Alteração de vencimento igual à registrada no sistema ou que torna o título vencido")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_VENCIMENTO_IGUAL_REGISTRADA_SISTEMA = 340,
	[Description("Incobrável por nosso intermédio")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	INCOBRAVEL_POR_NOSSO_INTERMEDIO = 341,
	[Description("Nosso número já existe")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOSSO_NUMERO_JA_EXISTE = 342,
	[Description("Beneficiário principal bloqueado para rateio")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	BENEFICIARIO_PRINCIPAL_BLOQUEADO_PARA_RATEIO = 343,
	[Description("Estado inválido")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	ESTADO_INVALIDO = 344,
	[Description("Tarifa de título pago na retaguarda")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_RETAGUARDA = 345,
	[Description("Valor do abatimento maior ou igual ao valor do título")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VALOR_DO_ABATIMENTO_MAIOR_IGUAL_AO_VALOR_DO_TITULO = 346,
	[Description("Faixa de aplicação não cadastrada")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	FAIXA_APLICACAO_NAO_CADASTRADA = 347,
	[Description("Número sequencial inválido")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	NUMERO_SEQUENCIAL_INVALIDO = 348,
	[Description("Liquidado office banking")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDADO_OFFICE_BANKING = 349,
	[Description("Instrução de emissão de aviso de cobrança para título vencido antes do vencimento")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_EMISSAO_AVISO_COBRANCA_TITULO_VENCIDO = 350,
	[Description("Transferido para créditos em liquidação")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TRANSFERIDO_PARA_CREDITOS_LIQUIDACAO = 351,
	[Description("Número da prestação do contrato inválido")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NUMERO_PRESTACAO_CONTRATO_INVALIDO = 352,
	[Description("Acerto de rateio rejeitado, título não registrado na cobrança")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	ACERTO_RATEIO_REJEITADO3 = 353,
	[Description("Falta número de inscrição do pagador")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_NUMERO_INSCRICAO_PAGADOR = 354,
	[Description("Tarifa de título pago no subcentro")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_SUBCENTRO = 355,
	[Description("Valor a conceder não confere")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	VALOR_A_CONCEDER_NAO_CONFERE = 356,
	[Description("Nosso número inválido")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NOSSO_NUMERO_INVALIDO3 = 357,
	[Description("Liquidado banco correspondente em dinheiro")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDADO_BANCO_CORRESPONDENTE_DINHEIRO = 358,
	[Description("IOF maior que 5%")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_VALOR_IOF = 359,
	[Description("Solicitação de cancelamento de instrução inexistente")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SOLICITACAO_CANCELAMENTO_INSTRUCAO_INEXISTENTE = 360,
	[Description("Percentual de desconto inválido")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	PERCENTUAL_DESCONTO_INVALIDO = 361,
	[Description("Título não cadastrado para rateio")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	TITULO_NAO_CADASTRADO_PARA_RATEIO = 362,
	[Description("Falta numeração - Bloquete emitido")]
	[AtributoDominio("35", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_NUMERACAO = 363,
	[Description("Tarifa de título pago com cartão de crédito")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_CARTAO_DE_CREDITO = 364,
	[Description("Concessão de abatimento já existe - abatimento anterior")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
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
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONCESSAO_ABATIMENTO_JA_EXISTE_ABATIMENTO_ANTERIOR = 365,
	[Description("Data de emissão do título inválida")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_EMISSAO_TITULO_INVALIDA2 = 366,
	[Description("Liquidado banco correspondente em cheque")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDADO_BANCO_CORRESPONDENTE_CHEQUE = 367,
	[Description("Quantidade de moeda incompatível com o valor do título")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_QUANTIDADE_MOEDA = 368,
	[Description("Título sofrendo alteração de controle")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TITULO_SOFRENDO_ALTERACAO_CONTROLE = 369,
	[Description("Dias para fichamento de protesto inválido")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DIAS_PARA_FICHAMENTO_PROTESTO_INVALIDO = 370,
	[Description("Cancelamento de rateio efetuado")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CANCELAMENTO_RATEIO_EFETUADO = 371,
	[Description("Título pré-numerado já existente")]
	[AtributoDominio("36", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TITULO_PRE_NUMERADO_JA_EXISTENTE = 372,
	[Description("Tarifa de título pago compensação eletrônica")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_COMP_ELETRONICA = 373,
	[Description("Código para protesto inválido")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_PROTESTO_INVALIDO = 374,
	[Description("Valor do título acima de R$ 5.000.000,00")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	VALOR_TITULO_ACIMA_VALOR_5_MILHOES = 375,
	[Description("Liquidado por meio de central de atendimento")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIQUIDADO_VIA_CENTRAL_ATENDIMENTO = 376,
	[Description("CNPJ/CPF do pagador não numérico ou igual a zeros")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CNPJ_CPF_PAGADOR = 377,
	[Description("Instrução não permitida para carteira")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_NAO_PERMITIDA_PARA_CARTEIRA = 378,
	[Description("Data de emissão do título inválida")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DATA_EMISSAO_DO_TITULO_INVALIDA = 379,
	[Description("Cancelamento de rateio por motivo de baixa comandada")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CANCELAMENTO_RATEIO_MOTIVO_BAIXA_COMANDADA = 380,
	[Description("Dígito do título não confere")]
	[AtributoDominio("37", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_TITULO_NAO_CONFERE = 381,
	[Description("Prazo para protesto inválido")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PRAZO_PROTESTO_INVALIDO = 382,
	[Description("Data de desconto menor que data da emissão")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_DESCONTO_MENOR_DATA_EMISSAO = 383,
	[Description("Tarifa de título baixado - pago em cartório")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_PAGO_CARTORIO = 384,
	[Description("Data do vencimento anterior à data da emissão do título")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DATA_VENCIMENTO_ANTERIOR_DATA_EMISSAO_TITULO = 385,
	[Description("Instrução não permitidapara título com rateio de crédito")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_NAO_PERMITIDA_TITULO_RATEIO_CREDITO = 386,
	[Description("Rateio efetuado, beneficiário aguardando crédito")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumChaveContexto.BAN041_CNAB400
	})]
	RATEIO_EFETUADO_BENEFICIARIO_AGUARDANDO_CREDITO = 387,
	[Description("Proibido protestar")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_PROTESTAR = 388,
	[Description("Prazo para protesto/ Negativação inválido")]
	[AtributoDominio("38", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PRAZO_PROTESTO_OU_NEGATIVACAO_INVALIDO = 1116,
	[Description("Pedido para protesto não permitido para título")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PEDIDO_PARA_PROTESTO_NAO_PERMITIDO_PARA_TITULO = 389,
	[Description("Espécie inválida")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	ESPECIE_INVALIDA2 = 390,
	[Description("Tarifa de título baixado - acerto banco")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_ACERTO_BCO = 391,
	[Description("Comando de alteração indevido para a carteira")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	COMANDO_ALTERACAO_INDEVIDO_PARA_CARTEIRA = 392,
	[Description("Rateio efetuado, beneficiário já creditado")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumChaveContexto.BAN041_CNAB400
	})]
	RATEIO_EFETUADO_BENEFICIARIO_JA_CREDITADO = 393,
	[Description("Proibido título pré-numerado para correspondente")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_TITULO_PRE_NUMERADO_CORRESPONDENTE = 394,
	[Description("Pedido para protesto/ Negativação não permitido para o título")]
	[AtributoDominio("39", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PEDIDO_PARA_PROTESTO_OU_NEGATIVACAO_NAO_PERMITIDO_PARA_O_TITULO = 1117,
	[Description("Título com ordem de protesto emitida")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
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
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_COM_ORDEM_DE_PROTESTO_EMITIDO = 395,
	[Description("Ausência no nome do sacador avalista")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	AUSENCIA_NOME_SACADOR_AVALISTA = 396,
	[Description("Baixa - registro em duplicidade")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	BAIXA_REGISTRO_EM_DUPLICIDADE = 397,
	[Description("Instrução incompatível - não existe instrução de negativação expressa para o título")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_INCOMPATIVEL_NAO_EXISTE_INSTRUCAO_NEGATIVACAO_EXPRESSA = 398,
	[Description("Não aprovada devido ao impacto na elegibilidade de garantias")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.COBRANCA_CONTRATUAL,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	NAO_APROVADA_DEVIDO_IMPACTO_ELEGIBILIDADE_DE_GARANTIAS = 399,
	[Description("Tipo de moeda inválido")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TIPO_MOEDA_INVALIDO = 400,
	[Description("Rateio não efetuado, conta de débito principal do beneficiário bloqueada")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumChaveContexto.BAN041_CNAB400
	})]
	RATEIO_NAO_EFETUADO_CONTA_BENEFICIARIO_BLOQUEADA = 401,
	[Description("Dígito cliente ou contrato com erro")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_CLIENTE_CONTRATO_ERRO = 402,
	[Description("Título com ordem/pedido de protesto/Negativação emitido")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_COM_ORDEM_PROTESTO_NEGATIVACAO_EMITIDO = 1122,
	[Description("Tarifa de título baixado por decurso de prazo")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_DECURSO_PRAZO = 403,
	[Description("Pedido de cancelamento de sustação para título sem instrução de protesto")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PEDIDO_CANCELAMENTO_SUSTACAO_PARA_TITULO_SEM_INSTRUCAO_DE_PROTESTO = 404,
	[Description("Data de início de multa menor que data de emissão")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	DATA_INICIO_MULTA_MENOR_DATA_EMISSAO = 405,
	[Description("Instrução não permitida - título já enviado para negativação expressa")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_NAO_PERMITIDA_TITULO_ENVIADO_NEGATIVACAO_EXPRESSA = 406,
	[Description("Automaticamente rejeitada")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.COBRANCA_CONTRATUAL,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	AUTOMATICAMENTE_REJEITADA = 407,
	[Description("Abatimento não permitido")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ABATIMENTO_NAO_PERMITIDO = 408,
	[Description("Campo aceite inválido ou com o mesmo conteúdo")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ACEITE_INVALIDO_OU_COM_MESMO_CONTEUDO = 409,
	[Description("Rateio não efetuado, conta beneficiário encerrada")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumChaveContexto.BAN041_CNAB400
	})]
	RATEIO_NAO_EFETUADO_CONTA_BENEFICIARIO_ECERRADA = 410,
	[Description("Dígito do nosso número com erro")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_NOSSO_NUMERO_ERRO = 411,
	[Description("Rateio não efetuado")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	RATEIO_NAO_EFETUADO = 412,
	[Description("Código para baixa ou devolução inválido")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	CODIGO_PARA_BAIXA_DEVOLUCAO_VIA_TELE_BRADESCO_INVALIDO = 413,
	[Description("Quantidade de moeda variável inválida")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	QUANTIDADE_MOEDA_VARIAVEL_INVALIDA = 414,
	[Description("Tarifa de título baixado judicialmente")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_JUDICIALMENTE = 415,
	[Description("Nosso número fora da faixa")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_NOSSO_NUMERO3 = 416,
	[Description("Alteração inválida para título vencido")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_INVALIDA_PARA_TITULO_VENCIDO = 417,
	[Description("Instrução não permitida - título com negativação expressa concluída")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_NAO_PERMITIDA_NEGATIVACAO_EXPRESSA_CONCLUIDA = 418,
	[Description("Confirma recebimento de instrução pendente de análise")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXAS_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CONFIRMA_RECEBIMENTO_INSTRUCAO_PENDENTE_ANALISE = 419,
	[Description("CEP ou UF inválido - não compatíveis")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CEP_UF_INVALIDO_NAO_COMPATIVEL = 420,
	[Description("Alteração cadastral de dados do título - sem emissão de aviso")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ALTERACAO_CADASTRAL_DADOS_TITULO_SEM_EMISSAO_AVISO = 421,
	[Description("Rateio não efetuado, código cálculo 2 e valor pago a menor")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumChaveContexto.BAN041_CNAB400
	})]
	RATEIO_NAO_EFETUADO_VALOR_PAGO_A_MENOR = 422,
	[Description("Título inexistente")]
	[AtributoDominio("42", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TITULO_INEXISTENTE = 423,
	[Description("Prazo para baixa ou devolução inválido")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	PRAZO_PARA_BAIXA_DEVOLUCAO_INVALIDO = 424,
	[Description("Controle do participante inválido")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	CONTROLE_PARTICIPANTE_INVALIDO = 425,
	[Description("Taria de título baixado via remessa")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_VIA_REMESSA = 426,
	[Description("Alteração bloqueada - vencimento já alterado")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_BLOQUEADA_VENCIMENTO_JA_ALTERADO = 427,
	[Description("Prazo inválido para negativação - mínimo 2 dias corridos após vencimento")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PRAZO_INVALIDO_NEGATIVACAO = 428,
	[Description("Código da unidade variável incompatível com a data de emissão do título")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CODIGO_UNIDADE_VARIAVEL_INCOMPATIVEL = 429,
	[Description("Ocorrência não possui rateio")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO_EM_CARTORIO2,
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXADO_CONFORME_INSTRUCOES_DA_AGENCIA,
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_CNAB400
	})]
	OCORRENCIA_NAO_POSSUI_RATEIO = 430,
	[Description("Título liquidado")]
	[AtributoDominio("43", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TITULO_LIQUIDADO = 431,
	[Description("Agência do beneficiário não prevista")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN748_CNAB400
	})]
	AGENCIA_BENEFICIARIO_NAO_PREVISTA = 432,
	[Description("Tarifa de título baixado via rastreamento")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_RASTREAMENTO = 433,
	[Description("Código da moeda inválido")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_MOEDA_INVALIDO = 434,
	[Description("Nosso número duplicado")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NOSSO_NUMERO_DUPLICADO2 = 435,
	[Description("Dados para débito ao sacado inválidos")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DADOS_DEBITO_AO_SACADO_INVALIDOS = 436,
	[Description("Título não pode ser baixado")]
	[AtributoDominio("44", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TITULO_NAO_PODE_SER_BAIXADO = 437,
	[Description("Nome do pagador inválido")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOME_PAGADOR_INVALIDO = 438,
	[Description("Título não aceito para compor a carteira de garantias")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_CNAB400
	})]
	TITULO_NAO_ACEITO_PARA_COMPOR_CARTEIRA_GARANTIAS = 439,
	[Description("Tarifa de título baixado por conf. pedido ")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_CONF_PEDIDO = 440,
	[Description("Instrução incompatível para o mesmo título nesta data")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_INCOMPATIVEL_PARA_MESMO_TITULO_NESSA_DATA = 441,
	[Description("Carteira ou variação encerrada")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CARTEIRA_OU_VARIACAO_ENCERRADA = 442,
	[Description("Emissão de 2ª via de bloqueto de cobrança registrada")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMISSAO_SEGUNDA_VIA_BLOQUETO_COBRANCA_REGISTRADA = 443,
	[Description("Data de vencimento com prazo superior ao limite")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	DATA_VENCIMENTO_COM_PRAZO_SUPERIOR_AO_LIMITE = 444,
	[Description("Valor nominal incorreto")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	VALOR_NOMINAL_INCORRETO = 445,
	[Description("Tipo do número de inscrição do pagador inválido")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_NUMERO_INSCRICAO_PAGADOR_INVALIDO = 446,
	[Description("Número do título inválido")]
	[AtributoDominio("45", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	NUMERO_TITULO_INVALIDO = 447,
	[Description("Tarifa de título baixado - protestado")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_PROTESTADO = 448,
	[Description("Por alteração da variação")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	POR_ALTERACAO_VARIACAO2 = 449,
	[Description("Convênio encerrado")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CONVENIO_ENCERRADO = 450,
	[Description("Código do cedente inválido")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CODIGO_CEDENTE_INVALIDO3 = 451,
	[Description("Registro borderô emissão expressa")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_BORDERO_EMISSAO_EXPRESSA2 = 452,
	[Description("Proibido taxa - multa para correspondente")]
	[AtributoDominio("46", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_TAXA_MULTA_PARA_CORRESPONDENTE = 453,
	[Description("Endereço do pagador não informado")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ENDERECO_PAGADOR_NAO_INFORMADO = 454,
	[Description("Tarifa de título baixado para devolução")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_PARA_DEVOLUCAO = 455,
	[Description("Instrução não permitida - espécie inválida")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_NAO_PERMITIDA_ESPECIE_INVALIDA = 456,
	[Description("Título tem valor diverso do informado")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_POSSUI_VALOR_DIFERENTE_DO_INFORMADO = 457,
	[Description("Cancelamento de rateio rejeitado, título não registrado na cobrança")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CANCELAMENTO_RATEIO_REJEITADO = 458,
	[Description("Registro borderô emissão banco com comprovante de entrega")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_BORDERO_EMISSAO_BANCO_COMPROVANTE_ENTREGA = 459,
	[Description("Falta tipo de conta do contrato")]
	[AtributoDominio("47", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_TIPO_CONTA_CONTRATO = 460,
	[Description("CEP inválido")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CEP_INVALIDO = 461,
	[Description("Tarifa de título baixado franco de pagamento")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_FRANCO_PAGTO = 462,
	[Description("Dados do pagador inválidos")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	DADOS_PAGADOR_INVALIDOS = 463,
	[Description("Motivo de baixa inválido para a carteira")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	MOTIVO_BAIXA_INVALIDO_PARA_CARTEIRA = 464,
	[Description("Acerto rejeitado, título já rateado ou baixado")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	ACERTO_REJEITADO_TITULO_JA_RATEADO = 465,
	[Description("Registro borderô emissão banco sem comprovante de entrega")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_BORDERO_EMISSAO_BANCO_SEM_COMPROVANTE_ENTREGA = 466,
	[Description("Tipo de conta inexistente")]
	[AtributoDominio("48", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TIPO_CONTA_INEXISTENTE = 467,
	[Description("Tarifa de título baixado sustado e retirado em cartório")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_SUST_RET_CARTORIO = 468,
	[Description("CEP sem praça de cobrança")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CEP_SEM_PRACA_COBRANCA = 469,
	[Description("Dados do endereço do pagador inválidos")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	DADOS_ENDERECO_PAGADOR_INVALIDOS = 470,
	[Description("Abatimento a cancelar não consta do título")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ABATIMENTO_CANCELAR_NAO_CONSTA_TITULO = 471,
	[Description("Movimento inválido para título baixado/liquidado")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_INVALIDO_PARA_TITULO_BAIXADO_LIQUIDADO = 472,
	[Description("Número de inscrição do pagador/avalista inválido")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NUMERO_INSCRICAO_PAGADOR_AVALISTA_INVALIDO2 = 473,
	[Description("Cancelamento de rateio rejeitado, título não registrado no rateio")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CANCELAMENTO_RATEIO_REJEITADO2 = 474,
	[Description("Registro meios magnéticos emissão expressa")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_EXPRESSA2 = 475,
	[Description("Dígito contrato não confere")]
	[AtributoDominio("49", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_CONTRATO_NAO_CONFERE2 = 476,
	[Description("CEP referente ao banco correspondente")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240
	})]
	CEP_REFERENTE_BANCO_CORRESPONDENTE = 477,
	[Description("Tarifa de título baixado sustado sem remessa para cartório")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_BAIXADO_SUS_SEM_REM_CARTORIO = 478,
	[Description("Data da emissão do título inválida")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	DATA_EMISSAO_TITULO_INVALIDA = 479,
	[Description("Comando incompatível com a carteira")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	COMANDO_INCOMPATIVEL_COM_CARTEIRA = 480,
	[Description("Pagador/avalista não informado")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_AVALISTA_NAO_INFORMADO2 = 481,
	[Description("Cancelamento de rateio rejeitado, título já rateado")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACERTO_DOS_DADOS_RATEIO_CREDITO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DOS_DADOS_DE_RATEIO,
		EnumChaveContexto.BAN041_CNAB400
	})]
	CANCELAMENTO_RATEIO_REJEITADO3 = 482,
	[Description("Tarifa de título transferido para desconto")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_TRANSFERIDO_DESCONTO = 483,
	[Description("Movimento inválido para título enviado para cartório")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	MOVIMENTO_INVALIDO_PARA_TITULO_ENVIADO_PARA_CARTORIO = 484,
	[Description("Dígito do título não confere")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIGITO_TITULO_NAO_CONFERE2 = 485,
	[Description("CEP incompatível com a unidade da federação")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CEP_INCOMPATIVEL_UNIDADE_FEDERACAO = 486,
	[Description("Instrução não permitida - título com negativação expressa agendada")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCOES_REJEITADAS,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INSTRUCAO_NAO_PERMITIDA_NEGATIVACAO_EXPRESSA_AGENDADA = 487,
	[Description("Acerto")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ACERTO = 488,
	[Description("Código do convenente inválido")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CODIGO_CONVENENTE_INVALIDO = 489,
	[Description("Título inexistente ou liquidado")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	TITULO_INEXISTENTE_LIQUIDADO = 490,
	[Description("Cobrado baixa manual")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	COBRADO_BAIXA_MANUAL = 491,
	[Description("Unidade da federação inválida")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	UNIDADE_FEDERACAO_INVALIDA = 492,
	[Description("Empresa não aceita banco correspondente")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_AGENCIA_COBRADORA3 = 493,
	[Description("Abatimento igual ou maior que o valor do título")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ABATIMENTO_IGUAL_MAIOR_VALOR_TITULO = 494,
	[Description("Reembolso de título vendor ou descontado, quando ocorrem reembolsos de títulos por falta de liquidação")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_DO_TIPO_DE_COBRANCA,
		EnumChaveContexto.BAN001_CBR643
	})]
	REEMBOLSO_TITULO_VENDOR_OU_DESCONTADO = 495,
	[Description("Valor abatimento inválido")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	VALOR_ABATIMENTO_INVALIDO2 = 496,
	[Description("Tipo ou Número da inscrição do pagador avalista inválido")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	NUMERO_INSCRICAO_PAGADOR_AVALISTA_INVALIDO = 497,
	[Description("Controle do participante inválido")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CONTROLE_PARTICIPANTE_INVALIDO2 = 498,
	[Description("Baixa por acerto com cliente")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	BAIXA_POR_ACERTO_CLIENTE = 499,
	[Description("Empresa não aceita banco correspondente - cobrança mensagem")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CAMPO_ERRO_AGENCIA_COBRADORA4 = 500,
	[Description("Instrução com o mesmo conteúdo")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	INSTRUCAO_COM_MESMO_CONTEUDO = 501,
	[Description("Título já se encontra na situação pretendida")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_JA_SE_ENCONTRA_SITUACAO_PRETENDIDA2 = 502,
	[Description("Data de vencimento inválida")]
	[AtributoDominio("53", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_VENCIMENTO_INVALIDA7 = 503,
	[Description("Pagador avalista não informado")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	PAGADOR_AVALISTA_NAO_INFORMADO = 504,
	[Description("Tarifa de baixa por contabilidade")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_BAIXA_POR_CONTABILIDADE = 505,
	[Description("Banco correspondente - título com vencimento inferior a 15 dias")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DATA_VENCIMENTO = 506,
	[Description("Data vencimento para bancos correspondentes inferior ao aceito pelo banco")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DATA_VENCIMENTO_BANCOS_CORRESPONDENTES_INFERIOR_AO_ACEITO = 507,
	[Description("Título fora do prazo admitido para conta 1")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_FORA_PRAZO_ADMITIDO_CONTA_1 = 508,
	[Description("Faixa de CEP da agência cobradora não abrange CEP do pagador")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	FAIXA_cep_AGENCIA_COBRADORA_NAO_ABRANGE_CEP_PAGADOR = 509,
	[Description("Estado inválido")]
	[AtributoDominio("54", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	ESTADO_INVALIDO2 = 509,
	[Description("TR tentativas cons. deb. aut.")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TR_TENTATIVA_CONS_DEB_AUT = 510,
	[Description("Nosso número no banco correspondente não informado")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	NOSSO_NUMERO_BANCO_CORRESPONDENTE_NAO_INFORMADO = 511,
	[Description("Código do documento ou lojista ou filial de entrega inválido")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CODIGO_DOCUMENTO_LOJISTA_FILIAL_INVALIDO = 512,
	[Description("CEP não pertence a depositária informada")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DEP_BANCO_CORRESPONDENTE = 513,
	[Description("Alterações iguais para o mesmo controle")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACOES_IGUAIS_PARA_MESMO_CONTROLE = 514,
	[Description("Novo vencimento fora dos limites da carteira")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOVO_VENCIMENTO_FORA_LIMITES_CARTEIRA = 515,
	[Description("Título já com opção de devolução")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	TITULO_JA_COM_OPCAO_DEVOLUCAO = 516,
	[Description("Falta tipo de pessoa para alteração de CNPJ ou CPF")]
	[AtributoDominio("55", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_TIPO_PESSOA = 517,
	[Description("TR crédito online")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TR_CREDITO_ONLINE = 518,
	[Description("Código do banco correspondente não informado")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_BANCO_CORRESPONDENTE_NAO_INFORMADO = 519,
	[Description("Vencimento superior a 180 dias da data de entrada")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DATA_VENCIMENTO_BANCO_CORRESPONDENTE = 520,
	[Description("CNPJ ou CPF inválido, não numérico ou zerado")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CNPJ_CPF_INVALIDO_NAO_NUMERICO_OU_ZERADO = 521,
	[Description("Título não pertence ao convenente")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_NAO_PERTENCE_CONVENENTE = 522,
	[Description("Processo de protesto em andamento")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	PROCESSO_PROTESTO_EM_ANDAMENTO = 523,
	[Description("Número de inscrição inválido")]
	[AtributoDominio("56", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	NUMERO_INSCRICAO_INVALIDO = 524,
	[Description("Tarifa de registro de pagamento bradesco expresso")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REG_PAGTO_BRADESCO_EXPRESSO = 525,
	[Description("Código de multa inválido")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	CODIGO_DA_MULTA_INVALIDO = 526,
	[Description("CEP só depositária banco do brasil com vencimento inferior a 8 dias")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DATA_VENCIMENTO2 = 527,
	[Description("Prazo de vencimento inferior a 15 dias")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	PRAZO_VENCIMENTO_INFERIOR_15_DIAS = 528,
	[Description("Variação incompatível com carteira")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VARICAO_INCOMPATIVEL_COM_CARTEIRA = 529,
	[Description("Título já com a opção de protesto")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	TITULO_JA_COM_OPCAO_PROTESTO = 530,
	[Description("Data de emissão inválida")]
	[AtributoDominio("57", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_EMISSAO_INVALIDA3 = 531,
	[Description("Tarifa de emissão de papeleta")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_EMISSAO_PAPELETA = 532,
	[Description("Data da multa inválida")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DATA_DA_MULTA_INVALIDA = 533,
	[Description("Impossível a variação única para a carteira indicada")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	IMPOSSIVEL_VARIACAO_UNICA_CARTEIRA_INDICADA = 534,
	[Description("Processo de devolução em andamento")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	PROCESSO_DE_DEVOLUCAO_EM_ANDAMENTO = 535,
	[Description("Data de vencimento desconto inválida")]
	[AtributoDominio("58", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_VENCIMENTO_DESCONTO_INVALIDA = 536,
	[Description("Tarifa pelo fornecimento de papeleta semi preechida")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_FORNEC_PAPELETA_SEMI_PREENCHIDA = 537,
	[Description("Valor ou percentual da multa inválido")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	VALOR_PERCENTUAL_MULTA_INVALIDO = 538,
	[Description("Título vencido com transferência para a carteira 51")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_VENCIDO_COM_TRANSFERENCIA_PARA_CARTEIRA_51 = 539,
	[Description("Novo prazo para protesto/devolução inválido")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	NOVO_PRAZO_PROTESTO_DEVOLUCAO_INVALIDO = 540,
	[Description("Aceite inválido para espécie de documento")]
	[AtributoDominio("59", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	ACEITE_INVALIDO_PARA_ESPECIE_DOCUMENTO = 541,
	[Description("Movimento para título não cadastrado")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	MOVIMENTO_PARA_TITULO_NAO_CADASTRADO = 542,
	[Description("Contrato limite de desconto inválido ou inexistente")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CONTRATO_LIMITE_DESCONTO_INVALIDO = 543,
	[Description("Acondicionador de papeletas RPB S")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ACONDICIONADOR_DE_PAPELETAS_RPB_S = 544,
	[Description("Valor de abatimento inválido")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_ABATIMENTO = 545,
	[Description("Valor de IOF - alteração não permitida para carteiras N.S. - moeda variável")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_IOF_ALTERACAO_NAO_PERMITIDA = 546,
	[Description("Título com prazo superior a 179 dias em variação única para carteira 51")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_PRAZO_SUPERIOR_179_DIAS = 547,
	[Description("Não aceite inválido para espécie de documento")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	NAO_ACEITE_INVALIDO_PARA_ESPECIE_DOCUMENTO = 548,
	[Description("Acondicionador de papeletas RPB S Personal")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ACONDICIONADOR_DE_PAPELATAS_RPB_S_PERSONAL = 549,
	[Description("Alteração da agência cobradora/dv inválida")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	ALTERACAO_AGENCIA_COBRADORA_INVALIDA = 550,
	[Description("Valor da proposta abaixo do valor mínimo para operações de desconto")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	VALOR_PROPOSTA_ABIAXO_VALOR_MINIMO_OPERACOES_DESCONTO = 551,
	[Description("Juros de mora maior do que o permitido")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_JUROS_DE_MORA = 552,
	[Description("Título já baixado ou liquidado ou não existe título correspondente no sistema")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	TITULO_JA_BAIXADO_OU_LIQUIDADO = 553,
	[Description("Título já foi fichado para protesto")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_FICHADO_PARA_PROTESTO = 554,
	[Description("Banco ou agência cobrador inválido")]
	[AtributoDominio("61", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	BANCO_AGENCIA_COBRADOR_INVALIDO = 555,
	[Description("Papeleta formulário em branco")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PAPELETA_FORMULARIO_BRANCO = 556,
	[Description("Tipo de impressão inválido")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TIPO_IMPRESSAO_INVALIDO = 557,
	[Description("Valor do desconto maior que o valor do título")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CAMPO_ERRO_DESCONTO = 558,
	[Description("Alteração da situação de débito inválida para o código de responsabilidade")]
	[AtributoDominio("62", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	ALTERACAO_SITUACAO_DEBITO_INVALIDA_CODIGO_RESPONSABILIDADE = 559,
	[Description("Limite operacional não cadastrado")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	LIMITE_OPERACIONAL_NAO_CADASTRADO = 560,
	[Description("Entrada para título já cadastrado")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
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
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ENTRADA_PARA_TITULO_JA_CADASTRADO = 561,
	[Description("Formulário A4 serrilhado")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORMULARIO_A4_SERRILHADO = 562,
	[Description("Valor da importância por dia de desconto não permitido")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DESCONTO_ANTECIPACAO = 563,
	[Description("Dígito do nosso número inválido")]
	[AtributoDominio("63", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DIGITO_NOSSO_NUMERO_INVALIDO = 564,
	[Description("Fornecimento de softwares de transmissão")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_DE_SOFTWARES_TRANSMISS = 565,
	[Description("Número de linha inválido")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	NUMERO_LINHA_INVALIDO = 566,
	[Description("Número de parcela incompatíveis")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	NUMERO_PARCELAS_INCOMPATIVEIS = 567,
	[Description("Data de emissão do título inválida")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_EMISSAO_TITULO = 568,
	[Description("Título não passível de débito/baixa - situação normal")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_NAO_PASSIVEL_DEBITO_BAIXA = 569,
	[Description("Entrada inválida para cobrança caucionada")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ENTRADA_INVALIDA_PARA_COBRANCA_CAUCIONADA = 570,
	[Description("Proibido alterar vencimento título cadastrado")]
	[AtributoDominio("64", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_ALTERAR_VENCIMENTO_TITULO_CADASTRADO = 571,
	[Description("Limite excedido")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	LIMITE_EXCEDIDO = 572,
	[Description("Fornecimento de softwares de consulta")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_DE_SOFTWARES_CONSULTA = 573,
	[Description("Código do banco para débito inválido")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CODIGO_BANCO_PARA_DEBITO_INVALIDO = 574,
	[Description("Existe parcela com erro no carnê")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	EXISTE_PARCELA_COM_ERRO_NO_CARNE = 575,
	[Description("Taxa de financiamento inválida")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_TAXA_FINANCIAMENTO = 576,
	[Description("Título com ordem de não protestar - não pode ser encaminhado a cartório")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_COM_ORDEM_NAO_PROTESTAR = 577,
	[Description("Cep do sacado não informado")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CEP_SACADO_NAO_INFORMADO = 578,
	[Description("Proibido informar nosso número para código de carteira")]
	[AtributoDominio("65", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	PROIBIDO_INFORMAR_NOSSO_NUMERO_CODIGO_CARTEIRA = 579,
	[Description("Número da autorização inexistente")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	NUMERO_AUTORIZACAO_INEXISTENTE = 580,
	[Description("Fornecimento de micro completo")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_MICRO_COMPLETO = 581,
	[Description("Agência/Conta/Dv para débito inválido")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	AGENCIA_CONTA_DV_PARA_DEBITO_INVALIDO = 582,
	[Description("Contrato de limite desconto inoperante")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CONTRATO_LIMITE_DESCONTO_INOPERANTE = 583,
	[Description("Data de vencimento inválida ou fora de operação")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DATA_VENCIMENTO3 = 584,
	[Description("Alteração não permitida para carteiras de notas de seguro")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_NAO_PERMITIDA_PARA_CARTEIRAS_NOTAS_DE_SEGUROS = 585,
	[Description("Número do documento do sacado (CNPJ/CPF) inválido")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NUMERO_DOCUMENTO_SACADO_INVALIDO = 586,
	[Description("Agência cobradora não encontrada")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	AGENCIA_COBRADORA_NAO_ENCONTRADA = 587,
	[Description("Falta vencimento desconto 2")]
	[AtributoDominio("66", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VENCIMENTO_DESCONTO2 = 588,
	[Description("Débito automático agendado")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_AUTOMATICO_AGENDADO = 589,
	[Description("Fornecimento de moden")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_MODEN = 590,
	[Description("Dados para débito incompatível com a identificação da emissão do bloqueto")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DADOS_PARA_DEBITO_INCOMPATIVEL_IDENTIFICACAO_EMISSAO_BLOQUETO = 591,
	[Description("Valor do título ou quantidade de moeda inválido")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_VALOR_QUANTIDADE = 592,
	[Description("Nome inválido do sacador avalista")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	NOME_INVALIDO_SACADOR_AVALISTA = 593,
	[Description("Título ou carnê rejeitado")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_CARNE_REJEITADO = 594,
	[Description("Agência do cedente não encontrada")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	AGENCIA_CEDENTE_NAO_ENCONTRADA = 595,
	[Description("Limite insuficiente")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	LIMITE_INSUFICIENTE = 596,
	[Description("Data desconto 2 inválida")]
	[AtributoDominio("67", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_DESCONTO_2_INVALIDA = 597,
	[Description("Débito não agendado - erro nos dados de remessa")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_ERRO_DADOS_DE_REMESSSA = 598,
	[Description("Fornecimento de máquina de fax")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_DE_MAQUINA_FAX = 599,
	[Description("Débito automático agendado")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_AUTOMATICO_AGENDADO2 = 600,
	[Description("Carteira inválida ou não cadastrada no intercâmbio da cobrança")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CARTEIRA2 = 601,
	[Description("Movimentação inválida para título")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	MOVIMENTACAO_INVALIDA_PARA_TITULO = 602,
	[Description("Nosso número não encontrado para reemissão")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	NOSSO_NUMERO_NAO_ENCONTRADO_PARA_REEMISSAO = 603,
	[Description("Data desconto 2 posterior ao vencimento")]
	[AtributoDominio("68", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_DESCONTO_2_POSTERIOR_VENCIMENTO = 604,
	[Description("Fornecimento de máquinas óticas")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_DE_MAQUINAS_OTICAS = 605,
	[Description("Débito não agendado - pagador não consta no cadastro do autorizante")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_PAGADOR_NAO_CONSTA_NO_CADASTRO_AUTORIZANTE = 606,
	[Description("Débito não agendado - erro nos dados da remessa")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_ERRO_DADOS_REMESSA = 607,
	[Description("Cliente não opera com desconto de duplicatas")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CLIENTE_NAO_OPERA_DESCONTO_DUPLICATA = 608,
	[Description("Valor ou percentual de juros inválido")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	VALOR_PERCENTUAL_JUROS_INVALIDO = 609,
	[Description("Carteira inválida para títulos com rateio de crédito")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CARTEIRA_INVALIDA_TITULOS_RATEIO_CREDITO = 610,
	[Description("Alteração de dados inválida")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ALTERACAO_DADOS_INVALIDA = 611,
	[Description("Falta valor desconto 2")]
	[AtributoDominio("69", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	FALTA_VALOR_DESCONTO2 = 612,
	[Description("Débito não agendado - beneficiário não autorizado pelo pagador")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_BENEFICIARIO_NAO_AUTORIZADO_PELO_PAGADOR = 613,
	[Description("Fornecimento de impressoras")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	FORNECIMENTO_DE_IMPRESSORAS = 614,
	[Description("Débito não agendado - sacado não consta no cadastro de autorizante")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_SACADO_NAO_CONSTA_CADASTRO_AUTORIZANTE = 615,
	[Description("Arquivo não HSBC ou lote duplicado ou sequência de registro inválida")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ARQUIVO_NAO_HSBC = 616,
	[Description("Título já se encontra isento de juros")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_SE_ENCONTRA_ISENTO_JUROS = 617,
	[Description("Cedente não cadastrado para fazer rateio de crédito")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CEDENTE_NAO_CADASTRADO_PARA_RATEIO_CREDITO = 618,
	[Description("Apelido do cliente não cadastrado")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	APELIDO_CLIENTE_NAO_CADASTRADO = 619,
	[Description("Título não selecionado por erro no CNPJ/CPF ou endereço")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TITULO_NAO_SELECIONADO_POR_ERRO_CNPJ_CPF_ENDERECO = 620,
	[Description("Data vencimento desconto 2 inválida")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DATA_DESCONTO_2_INVALIDA2 = 621,
	[Description("Débito não agendado - beneficiário não participa da modalidade de débito automático")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_BENEFICIARIO_NAO_PARTICIPA_DA_MODALIDADE_DEBITO_AUTOMATICO = 622,
	[Description("Reativação de título")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	REATIVACAO_DE_TITULO = 623,
	[Description("Débito não agendado - Cedente não autorizado pelo sacado")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_CEDENTE_NAO_AUTORIZADO_PELO_SACADO = 624,
	[Description("Contrato limite em processo de renovação")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CONTRATO_LIMITE_EM_PROCESSO_RENOVACAO = 625,
	[Description("Código de juros inválido")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CODIGO_JUROS_INVALIDO = 626,
	[Description("Erro na composição do arquivo")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ERRO_COMPOSICAO_ARQUIVO = 627,
	[Description("IOC maior que valor do título")]
	[AtributoDominio("71", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	IOC_MAIOR_VALOR_TITULO = 628,
	[Description("Débito não agendado - código de moeda diferente de real")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_CODIGO_DE_MOEDA_DIFERENTE_REAL = 629,
	[Description("Alteração de produto negociado")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ALTERACAO_DE_PRODUTO_NEGOCIADO = 630,
	[Description("Débito não agendado - Cedente não participa da modalidade débito automático")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_CEDENTE_NAO_PARTICIPA_MODALIDADE_DEBITO_AUTOMATICO = 631,
	[Description("Erro no código convênio")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ERRO_CODIGO_CONVENIO = 632,
	[Description("Endereço inválido - sacador avalista")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ENDERECO_INVALIDO_SACADOR_AVALISTA = 633,
	[Description("Prefixo da agência cobradora inválido")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	PREFIXO_AGENCIA_COBRADORA_INVALIDO = 634,
	[Description("Lote de serviço inválido")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	LOTE_SERVICO_INVALIDO = 635,
	[Description("CEP não pertence ao estado")]
	[AtributoDominio("72", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	CEP_NAO_PERTENCE_ESTADO = 636,
	[Description("Tarifa de emissão de contra recibo")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_EMISSAO_DE_CONTRA_RECIBO = 637,
	[Description("Débito não agendado - data de vencimento inválida")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_DATA_VENCIMENTO_INVALIDA = 638,
	[Description("Débito não agendado - Código de moeda diferente de real")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_CODIGO_MOEDA_DIFERENTE_DE_REAL = 639,
	[Description("Rejeitado pela análise de crédito")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REJEITADO_PELA_ANALISE_CREDITO = 640,
	[Description("Bairro inválido do sacador avalista")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	BAIRRO_INVALIDO_SACADOR_AVALISTA = 641,
	[Description("Número do controle do participante inválido")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NUMERO_CONTROLE_PARTICIPANTE_INVALIDO = 642,
	[Description("Código do cedente inválido")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_CEDENTE_INVALIDO2 = 643,
	[Description("Seu número já existente")]
	[AtributoDominio("73", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	SEU_NUMERO_JA_EXISTENTE = 644,
	[Description("Débito não agendado - conforme seu pedido título não registrado")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_CONFORME_SEU_PEDIDO_TITULO_NAO_REGISTRADO = 645,
	[Description("Tarifa de emissão de segunda via de papeleta")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_EMISSAO_SEGUNDA_VIA_PAPELETA = 646,
	[Description("Débito não agendado - data de vencimento inválida")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_DATA_VENCIMENTO_INVALIDA2 = 647,
	[Description("Vencimento fora dos limites aprovados")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	VENCIMENTO_FORA_LIMITES_APROVADOS = 648,
	[Description("Cidade inválida do sacador avalista")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CIDADE_INVALIDA_SACADOR_AVALISTA = 649,
	[Description("Cliente não cadastrado no CIOPE")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CLIENTE_NAO_CADASTRADO_CIOPE = 650,
	[Description("Cliente não pertence a cobrança eletrônica")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CLIENTE_NAO_PERTENCE_COBRANCA_REGISTRADA = 651,
	[Description("Moeda inválida para tipo de operação")]
	[AtributoDominio("74", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	MOEDA_INVALIDA_TIPO_OPERACAO = 652,
	[Description("Débito não agendado - tipo numérico da inscrição do pagador debitado inválido")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA_POR_CEP_IRREGULAR,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	DEBITO_NAO_AGENDADO_TIPO_NUMERO_INSCRICAO_DO_PAGADOR_DEBITADO_INVALIDO = 653,
	[Description("Tarifa de regravação de arquivo de retorno")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REGRAVACAO_ARQUIVO_RETORNO = 654,
	[Description("Débito não agendado - conforme seu pedido título não registrado")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_CONFORME_SEU_PEDIDO = 655,
	[Description("Erro somatório de registros do lote")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ERRO_SOMATORIO_REGISTROS_LOTE = 656,
	[Description("Sigla do estado inválida do sacador avalista")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	SIGLA_ESTADO_INVALIDA_SACADOR_AVALISTA = 657,
	[Description("Quantidade de dias do prazo limite para recebimento de título vencido inválido")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	QUANTIDADE_DIAS_PRAZO_LIMITE_RECEBIMENTO_TITULO_VENCIDO_INVALIDO = 658,
	[Description("Nome da empresa inválido")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NOME_EMPRESA_INVALIDO = 659,
	[Description("Moeda inexistente")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	MOEDA_INEXISTENTE = 660,
	[Description("Pagador eletrônico DDA")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PAGADOR_ELETRONICO_DDA = 661,
	[Description("Arquivamento de títulos a vencer mensal")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	ARQ_TITULOS_A_VENCER_MENSAL = 662,
	[Description("Débito não agendado - Tipo ou número de inscridção do debitado inválido")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DEBITO_NAO_AGENDADO_TIPO_NUMERO_INSCRICAO_DEBITADO_INVALIDO = 663,
	[Description("CEP inválido do sacador avalista")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CEP_INVALIDO_SACADOR_AVALISTA = 664,
	[Description("Título excluído automaticamente por decurso de prazo CIOPE")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_EXCLUIDO_AUTOMATICAMENTE_DECURSO_PRAZO_CIOPE = 665,
	[Description("Nome do banco inválido")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NOME_BANCO_INVALIDO = 666,
	[Description("Alteração do prazo de protesto inválida")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	ALTERACAO_PRAZO_PROTESTO_INVALIDA = 667,
	[Description("Banco aguarda cópia autenticada do documento")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	BANCO_AGUARDA_COPIA_AUTENTICADA_DOCUMENTO = 668,
	[Description("Nosso número dígito com erro")]
	[AtributoDominio("76", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	NOSSO_NUMERO_DIGITO_COM_ERRO = 669,
	[Description("Transferência para desconto não permitido para carteira")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TRANSFERENCIA_PARA_DESCONTO_NAO_PERMITIDO_PARA_CARTEIRA = 670,
	[Description("Sequência de registro inválida não acrescida de 1")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	SEQUENCIA_REGISTRO_INVALIDA = 671,
	[Description("Listagem auxiliar de crédito")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	LISTAGEM_AUXILIAR_DE_CREDITO = 672,
	[Description("Título vencido transferido para conta 1 - carteira vinculada")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_VENCIDO_TRANSFERIDO_PARA_CONTA_1 = 673,
	[Description("Código da remessa inválido")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_REMESSA_INVALIDO = 674,
	[Description("Alteração do prazo de devolução inválida")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	ALTERACAO_PRAZO_DEVOLUCAO_INVALIDA = 675,
	[Description("Título selecionado falta seu número")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TITULO_SELECIONADO_FALTA_SEU_NUMERO = 676,
	[Description("Dias vencidos superior ao prazo de devolução")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA2,
		EnumChaveContexto.BAN004_CNAB400
	})]
	DIAS_VENCIDOS_SUPERIOR_PRAZO_DEVOLUCAO = 677,
	[Description("Tarifa de cadastro de cartela de instrução permanente")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_CADASTRO_CARTELA_INSTRUCAO_PERMANENTE = 678,
	[Description("Pagador alega faturamento indevido")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.OCORRENCIAS_DO_SACADO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PAGADOR_ALEGA_FATURAMENTO_INDEVIDO = 679,
	[Description("Data inferior ou igual ao vencimento para débito automático")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	DATA_INFERIOR_OU_IGUAL_VENCIMENTO_DEBITO_AUTOMATICO = 680,
	[Description("Erro somatório lotes do arquivo")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ERRO_SOMATORIO_LOTES_ARQUIVO = 681,
	[Description("Duplicidade de agência ou conta beneficiária do rateio de crédito")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DUPLICIDADE_AGENCIA_CONTA_BENEFICIARIA_RATEIO_CREDITO = 682,
	[Description("Data/Hora geração do arquivo inválida")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_HORA_GERACAO_ARQUIVO_INVALIDA = 683,
	[Description("Título rejeitado pelo cartório por estar irregular")]
	[AtributoDominio("78", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TITULO_REJEITADO_PELO_CARTORIO_POR_ESTAR_IRREGULAR = 684,
	[Description("Canalização de crédito")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CANALIZACAO_DE_CREDITO = 685,
	[Description("Data de juros de mora inválida")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DATA_DE_JUROS_DE_MORA_INVALIDA = 686,
	[Description("Erro na quantidade de registros do arquivo")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ERRO_QUANTIDADE_REGISTROS_ARQUIVO = 687,
	[Description("Número sequencial do arquivo inválido")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_SEQUENCIAL_ARQUIVO_INVALIDO = 688,
	[Description("Título não selecionado - praça não atendida")]
	[AtributoDominio("79", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TITULO_NAO_SELECIONADO_PRACA_NAO_ATENDIDA = 689,
	[Description("Cadastro de mensagem fixa")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CADASTRO_DE_MENSAGEM_FIXA = 690,
	[Description("Data do desconto inválida")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	DATA_DO_DESCONTO_INVALIDA = 691,
	[Description("Sem registro trailler ou lote de arquivo")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	SEM_REGISTRO_TRAILLER_OU_LOTE = 692,
	[Description("Nosso número inválido")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	NOSSO_NUMERO_INVALIDO2 = 693,
	[Description("Quantidade de contas beneficiárias do rateio maior do que o permitido")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	QUANTIDADE_CONTAS_BENEFICIARIAS_RATEIO_MAIOR_PERMITIDO = 694,
	[Description("Versão do layout do arquivo inválido")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VERSAO_LAYOUT_ARQUIVO_INVALIDO = 695,
	[Description("Cartório aguarda autorização para protestar por edital")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	CARTORIO_AGUARDA_AUTORIZACAO_PARA_PROTESTAR_POR_EDITAL = 696,
	[Description("Registro borderô emissão expressa")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_BORDERO_EMISSAO_EXPRESSA = 697,
	[Description("Tarifa de reapresentação automática de título")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REAPRESENTACAO_AUTOMATICA_TITULO = 698,
	[Description("Tentativas esgotadas - baixado")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TENTATIVAS_ESGOTADAS_BAIXADO = 699,
	[Description("CEP inválido do sacador")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	CEP_INVALIDO_SACADOR = 700,
	[Description("Títulos abaixo dos parâmetros de valores do HSBC para Desconto")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	TITULOS_ABAIXO_DOS_PARAMETROS_HSBC = 701,
	[Description("Alteração bloqueada - título com negativação expressa ou protesto")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_BLOQUEADA_TITULO_COM_NEGATIVACAO_EXPRESSA = 702,
	[Description("Data para concessão de desconto inválida")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	DATA_CONCESSAO_DESCONTO_INVALIDA = 703,
	[Description("Conta para rateio de crédito inválida ou não pertence ao Itaú")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CONTA_RATEIO_CREDITO_INVALIDA = 704,
	[Description("Literal REMESSA-TESTE - Válido apenas para fase testes")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	LITERAL_REMESSA_TESTE_VALIDO_SO_FASE_TESTES = 705,
	[Description("CEP do pagador inválido")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	CEP_PAGADOR_INVALIDO = 706,
	[Description("Registro borderô emissão banco com comprovante de entrega")]
	[AtributoDominio("81", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_BORDERO_EMISSAO_BANCO_COMPROVANTE_ENTREGA2 = 707,
	[Description("Tarifa de registro de título de débito automático")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REGISTRO_TITULO_DEB_AUTOMATICO = 708,
	[Description("Tentativas esgotadas - pendente")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TENTATIVAS_ESGOTADAS_PENDENTE = 709,
	[Description("Cancelamento da operação pelo cliente")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CANCELAMENTO_OPERACAO_PELO_CLIENTE = 710,
	[Description("CEP do sacado inválido")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CEP_SACADO_INVALIDO = 711,
	[Description("Desconto ou abatimento não permitido para títulos com rateio de crédito")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	DESCONTO_ABATIMENTO_NAO_PERMITIDO_TITULOS_RATEIO_CREDITO = 712,
	[Description("Literal REMESSA-TESTE - obrigatório para fase de testes")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	LITERAL_REMESSA_TESTE_OBRIGATORIO = 713,
	[Description("CNPJ/CPF do pagador inválido")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	CNPJ_CPF_PAGADOR_INVALIDO = 714,
	[Description("Registro borderô emissão banco sem comprovante de entrega")]
	[AtributoDominio("82", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_BORDERO_EMISSAO_BANCO_SEM_COMPROVANTE_ENTREGA2 = 715,
	[Description("Tarifa de rateio de crédito")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_RATEIO_DE_CREDITO = 716,
	[Description("Cancelado pelo pagador e mantido pendente")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CANCELADO_PELO_PAGADOR_MANTIDO_PENDENTE = 717,
	[Description("Limite excedido")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	LIMITE_EXCEDIDO2 = 718,
	[Description("Recusa pela regra de análise")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	RECUSA_PELA_REGRA_DE_ANALISE = 719,
	[Description("Carteira ou variação não localizada no cedente")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	CARTEIRA_VARIACAO_NAO_LOCALIZADA_CEDENTE = 720,
	[Description("Valor do título menor do que a soma dos valores estipulados para o rateio")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	VALOR_TITULO_MENOR_SOMA_RATEIO = 721,
	[Description("Tipo número inscrição da empresa inválido")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_INSCRICAO_EMPRESA_INVALIDO = 722,
	[Description("Número do documento inválido")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	NUMERO_DOCUMENTO_INVALIDO = 723,
	[Description("Tipo/número inscrição sacador inválido")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TIPO_NUMERO_INSCRICAO_SACADOR_INVALIDO = 724,
	[Description("Registro meios magnéticos emissão expressa")]
	[AtributoDominio("83", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_EXPRESSA = 725,
	[Description("Emissão de papeleta sem valor")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMISSAO_PAPELETA_SEM_VALOR = 726,
	[Description("Cancelado pelo pagador - baixado")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DO_DESAGENDAMENTO_DO_DEBITO_AUTOMATICO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CANCELADO_PELO_PAGADOR_BAIXADO = 727,
	[Description("Número autorização inexistente")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NUMERO_AUTORIZACAO_INEXISTENTE2 = 728,
	[Description("Não aceito desconto - enviado carteira simples")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	NAO_ACEITO_DESCONTO_ENVIADO_CARTEIRA_SIMPLES = 729,
	[Description("Sacador não informado")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	SACADOR_NAO_INFORMADO = 730,
	[Description("Título não localizado na existência ou baixado por protesto")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	TITULO_NAO_LOCALIZADO_OU_BAIXADO_POR_PROTESTO = 731,
	[Description("Tipo de operação inválido")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_OPERACAO_INVALIDO = 732,
	[Description("Agência ou conta beneficiária do rateio é centralizadora de crédito do cedente")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_CONTA_BENEFICIARIA_RATEIO_CENTRALIZADORA_CREDITO = 733,
	[Description("Protesto inválido para título sem número do documento")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN104_CNAB400
	})]
	PROTESTO_INVALIDO_PARA_TITULO_SEM_NUMERO_DOCUMENTO = 734,
	[Description("Registro meios magnéticos emissão banco com comprovante de entrega")]
	[AtributoDominio("84", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_BANCO_COM_COMPROVANTE_ENTREGA = 735,
	[Description("Título com pagamento vinculado")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	TITULO_COM_PAGAMENTO_VINCULADO = 736,
	[Description("Registro predecessor não encontrado")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_PREDECESSOR_NAO_ENCONTRADO = 737,
	[Description("Sem uso")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	SEM_USO = 738,
	[Description("Título com pagamento vinculado")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_COM_PAGAMENTO_VINCULADO2 = 739,
	[Description("Recusa do comando 41 - parâmetro de liquidação parcial")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	RECUSA_COMANDO_41 = 740,
	[Description("Agência ou conta do cedente é contratual ou rateio de crédito não permitido")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	AGENCIA_CONTA_CEDENTE_CONTRATUAL = 741,
	[Description("Tipo de serviço inválido")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_SERVICO_INVALIDO = 742,
	[Description("Registro meios magéticos emissão banco sem comprovante de entrega")]
	[AtributoDominio("85", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_BANCO_SEM_COMPROVANTE_ENTREGA = 743,
	[Description("Seu número do documento inválido")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.TITULO_EM_ABERTO_NAO_ENVIADO_PAGADOR,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN041_CNAB400,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	SEU_NUMERO_DO_DOCUMENTO_INVALIDO = 744,
	[Description("Alteração seu número e uso empresa não informado")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ALTERACAO_SEU_NUMERO_NAO_INFORMADO = 745,
	[Description("Cadastro de reembolso de diferença")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CADASTRO_DE_REEMBOLSO_DE_DIFERENCA = 746,
	[Description("Forma de lançamento inválida")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	FORMA_LANCAMENTO_INVALIDA = 747,
	[Description("Liquidação - auto atendimento")]
	[AtributoDominio("86", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	LIQUIDACAO_AUTO_ATENDIMENTO = 748,
	[Description("Relatório de fluxo de pagamento")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	RELATORIO_FLUXO_DE_PAGTO = 749,
	[Description("E-mail/SMS enviado")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_ENVIO_DE_EMAIL_SMS,
		EnumCodigoMovimentoRetorno.ENVIO_DE_EMAIL_SMS_REJEITADO,
		EnumCodigoMovimentoRetorno.CANCELAMENTO_DE_SMS,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EMAIL_SMS_ENVIADO = 750,
	[Description("Ação gerencial")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ACAO_GERENCIAL = 751,
	[Description("Registro tipo 4 sem informação de agências ou contas beneficiárias para rateio")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	REGISTRO_TIPO_4_SEM_AGENCIAS_CONTAS_BENEFICIARIAS_PARA_RATEIO = 752,
	[Description("Alteração bloqueada - título com rateio de crédito")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ALTERACAO_OU_EXCLUSAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	ALTERACAO_BLOQUEADA_TITULO_RATEIO_CREDITO = 753,
	[Description("Número de remessa inválido")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_REMESSA_INVALIDO = 754,
	[Description("Liquidação boca do caixa")]
	[AtributoDominio("87", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	LIQUIDACAO_BOCA_CAIXA = 755,
	[Description("Emissão de extrato de movimentação de carteira")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMISSAO_EXTRATO_MOV_CARTEIRA = 756,
	[Description("Email pagador não lido no prazo de 5 dias")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMAIL_PAGADOR_NAO_LIDO_NO_PRAZO_5_DIAS = 757,
	[Description("Email lido")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EMAIL_LIDO = 758,
	[Description("Arquivo fora do padrão registrado no banco")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ARQUIVO_FORA_PADRAO_REGISTRADO_NO_BANCO = 759,
	[Description("Número da remessa menor/igual remessa anterior")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_REMESSA_MENOR_IGUAL_REMESSA_ANTERIOR = 760,
	[Description("Liquidação interbancária")]
	[AtributoDominio("88", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	LIQUIDACAO_INTERBANCARIA = 761,
	[Description("Email do pagador não enviado - título com débito automático")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMAIL_PAGADOR_NAO_ENVIADO_TITULO_COM_DEBITO_AUTOMATICO = 762,
	[Description("Mensagem de campo local de pagamento")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	MENSAGEM_CAMPO_LOCAL_DE_PAGTO = 763,
	[Description("E-mail/SMS devolvido - endereço de email ou número do celular incorreto")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EMAIL_SMS_DEVOLVIDO = 764,
	[Description("Lote de serviço divergente")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	LOTE_SERVICO_DIVERGENTE = 765,
	[Description("Contrato inoperante para meios eletrônicos")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	CONTRATO_INOPERANTE_MEIOS_ELETRONICOS = 766,
	[Description("Instrução de protesto automática")]
	[AtributoDominio("89", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	INSTRUCAO_PROTESTO_AUTOMATICA = 767,
	[Description("E-mail do pagador não enviado - título de cobrança sem registro")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMAIL_PAGADOR_NAO_ENVIADO_TITULO_DE_COBRANCA_SEM_REGISTRO = 768,
	[Description("Cadastro de concessionária serv. publ.")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CADASTRO_CONCESSIONARIA_SERV_PUBL = 769,
	[Description("E-mail devolvido - caixa postal cheia")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EMAIL_DEVOLVIDO = 770,
	[Description("Registro protocolo IED não encontrado ou registro lote não informado")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	REGISTRO_PROTOCOLO_IED_NAO_ENCONTRADO = 771,
	[Description("Cobrança mensagem - número da linha da mensagem inválido ou quantidade de linhas excedidas")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_REGISTRO_MENSAGEM = 772,
	[Description("Baixa automática")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA,
		EnumCodigoMovimentoRetorno.BAIXA_SOLICITADA,
		EnumCodigoMovimentoRetorno.DEBITO_EM_CONTA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	BAIXA_AUTOMATICA = 773,
	[Description("Número sequencial do registro inválido")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_SEQUENCIAL_REGISTRO_INVALIDO = 774,
	[Description("Protesto sustado por solicitação do beneficiário")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	PROTESTO_SUSTADO_POR_SOLICITACAO_BENEFICIARIO = 775,
	[Description("Instrução de protesto manual")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	INSTRUCAO_PROTESTO_MANUAL = 776,
	[Description("Registro meios magnéticos emissão banco com comprovante de entrega")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_BANCO_COMPROVANTE_ENTREGA = 777,
	[Description("Classificação de extrato de conta corrente")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CLASSIF_EXTRATO_CONTA_CORRENTE = 778,
	[Description("Email pagador não recebido")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_DE_PEDIDO_DE_ALTERACAO_DE_OUTROS_DADOS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	EMAIL_PAGADOR_NAO_RECEBIDO = 779,
	[Description("E-mail ou número do celular do sacado não informado")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	EMAIL_NUMERO_CELULAR_SACADO_NAO_INFORMADO = 780,
	[Description("Situação do título não permitida para desconto")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	SITUACAO_TITULO_NAO_PERMITIDA_PARA_DESCONTO = 781,
	[Description("DAC agência/conta corrente inválido")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DAC = 782,
	[Description("Erro na sequência do registro detalhe")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ERRO_SEQUENCIA_REGISTRO_DETALHE = 783,
	[Description("Outras instruções automáticas")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	OUTRAS_INSTRUCOES_AUTOMATICAS = 784,
	[Description("Registro meios mangéticos emissão banco sem comprovante de entrega")]
	[AtributoDominio("91", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	REGISTRO_MEIOS_MAGNETICOS_EMISSAO_BANCO_SEM_COMPROVANTE_ENTREGA2 = 785,
	[Description("Protesto sustado por alteração do vencimento")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	PROTESTO_SUSTADO_POR_ALTERACAO_VENCIMENTO = 786,
	[Description("Contabilidade especial")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CONTABILIDADE_ESPECIAL = 787,
	[Description("Sacado optante por bloqueto eletrônico - e-mail não enviado")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN021_CNAB400,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	SACADO_OPTANTE_POR_BLOQUETO_ELETRONICO = 788,
	[Description("DAC agência/conta/carteira/nosso número inválido")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_DAC2 = 789,
	[Description("Código do movimento divergente entre grupo de segmento")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_MOVIMENTO_DIVERGENTE_ENTRE_GRUPO_DE_SEGMENTO = 790,
	[Description("Título reservado para outra operação")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	TITULO_RESERVADO_PARA_OUTRA_OPERACAO = 791,
	[Description("Outras instruções manuais")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	OUTRAS_INSTRUCOES_MANUAIS = 792,
	[Description("Liquidação auto atendimento")]
	[AtributoDominio("92", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	LIQUIDACAO_AUTO_ATENDIMENTO2 = 793,
	[Description("Realimentação de pagamento")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	REALIMENTACAO_PAGTO = 794,
	[Description("Código para emissão de bloqueto não permite envio de e-mail")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CODIGO_EMISSAO_BLOQUETO_NAO_PERMITE_ENVIO_EMAIL = 795,
	[Description("Sigla do estado inválida")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_ESTADO = 796,
	[Description("Quantidade de registros no lote inválido")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_REGISTROS_NO_LOTE_INVALIDO = 797,
	[Description("Horário indisponível para operação de desconto")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	HORARIO_INDISPONIVEL_PARA_OPERACAO = 798,
	[Description("Protesto sustado por alteração no prazo do protesto")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	PROTESTO_SUSTADO_POR_ALTERACAO_PRAZO_PROTESTO = 799,
	[Description("Bancos correspondentes")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	BANCOS_CORRESPONDENTES = 800,
	[Description("Liquidação boca do caixa")]
	[AtributoDominio("93", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	LIQUIDACAO_BOCA_CAIXA2 = 801,
	[Description("Repasse de créditos")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	REPASSE_DE_CREDITOS = 802,
	[Description("Título penhorado - instrução não liberada pela agência")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TITULO_PENHORADO_INSTRUCAO_NAO_LIBERADA_PELA_AGENCIA = 803,
	[Description("Código de carteira inválido para envio de e-mail")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CODIGO_CARTEIRA_INVALIDO_PARA_ENVIO_DE_EMAIL = 804,
	[Description("Sigla do estado incompatível com CEP do pagador")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_ESTADO2 = 805,
	[Description("Quantidade de registros no lote divergente")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_REGISTROS_LOTE_DIVERGENTE = 806,
	[Description("Título já atualizado em outra operação")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	TITULO_JA_ATUALIZADO_EM_OUTRA_OPERACAO = 807,
	[Description("Liquidação interbancária")]
	[AtributoDominio("94", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	LIQUIDACAO_INTERBANCARIA2 = 808,
	[Description("Pagador aceita faturamento")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.OCORRENCIAS_DO_SACADO,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PAGADOR_ACEITA_FATURAMENTO = 809,
	[Description("Contrato não permite envio de e-mail")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CONTRATO_NAO_PERMITE_ENVIO_DE_EMAIL = 810,
	[Description("CEP do pagador não numérico ou inválido")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_CEP2 = 811,
	[Description("Quantidade de lotes no arquivo inválido")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_LOTES_INVALIDO = 812,
	[Description("Data de geração do arquivo diferente da data de processamento")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	DATA_GERACAO_ARQUIVO_DIFERENTE_DATA_PROCESSAMENTO = 813,
	[Description("Entidade pública")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	ENTIDADE_PUBLICA = 814,
	[Description("Instruções de protesto/Serasa automática")]
	[AtributoDominio("95", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	INSTRUCOES_PROTESTO_SERASA_AUTOMATICA = 815,
	[Description("Tarifa de registro de pagamento de outras mídias")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REG_PAGTO_OUTRAS_MIDIAS = 816,
	[Description("Número de contrato inválido")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NUMERO_CONTRATO_INVALIDO = 817,
	[Description("Operação não confirmada pelo cliente no Connect Bank")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	OPERACAO_NAO_CONFIRMADA_PELO_CLIENTE = 818,
	[Description("Endereço/Nome/Cidade do pagador inválido")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_ENDERECO = 819,
	[Description("Quantidade de lotes no arquivo divergente")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_LOTES_DIVERGENTE = 820,
	[Description("Instrução de protesto serasa/manual")]
	[AtributoDominio("96", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	INSTRUCAO_PROTESTO_SERASA_MANUAL = 821,
	[Description("Tarifa de registro de pagamento Net Empresa")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_REG_PAGTO_NET_EMPRESA = 822,
	[Description("Rejeição da alteração do prazo limite de recebimento")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_ALTERACAO_PRAZO_LIMITE_RECEBIMENTO = 823,
	[Description("Cobrança mensagem sem mensagem")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	COBRANCA_MENSAGEM_SEM_MENSAGEM = 824,
	[Description("Quantidade de registros no arquivo inválida")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_REGISTROS_INVALIDA = 825,
	[Description("Título em cartório")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.TITULOS_EM_CARTEIRA,
		EnumCodigoMovimentoRetorno.SITUACAO_TITULO_EM_CARTORIO,
		EnumChaveContexto.BAN041_FEBRABAN240
	})]
	TITULO_EM_CARTORIO = 826,
	[Description("Outras instruções automáticas")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	OUTRAS_INSTRUCOES_AUTOMATICAS2 = 827,
	[Description("Instrução não permitida título negativado")]
	[AtributoDominio("97", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	INSTRUCAO_NAO_PERMITIDA_TITULO_NEGATIVADO = 1120,
	[Description("Tarifa de título pago ou vencido")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TARIFA_TITULO_PAGO_VENCIDO = 828,
	[Description("Rejeição de dispensa de prazo limite de recebimento")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_DISPENSA_PRAZO_LIMITE_RECEBIMENTO = 829,
	[Description("Registro mensagem sem flash cadastrado ou flash informado diferente do cadastrado")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_FLASH = 830,
	[Description("Quantidade de registros divergente")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_REGISTROS_DIVERGENTE = 831,
	[Description("Outras instruções manuais")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	OUTRAS_INSTRUCOES_MANUAIS2 = 832,
	[Description("Inclusão Bloqueada face a determinação Judicial")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	INCLUSAO_BLOQUEADA_FACE_DETERMINACAO_JUDICIAL = 1121,
	[Description("Erro na formação do carnê")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN021_CNAB400
	})]
	ERRO_FORMACAO_CARNE = 1152,
	[Description("Outros motivos")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REJEICAO_DO_TITULO,
		EnumChaveContexto.BAN021_CNAB400
	})]
	OUTROS_MOTIVOS2 = 1172,
	[Description("TR de título baixado por decurso de prazo")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TR_TIT_BAIXADO_POR_DECURSO_PRAZO = 833,
	[Description("Rejeição da alteração do número do título dado pelo cedente")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_ALTERACAO_NUMERO_TITULO_CEDENTE = 834,
	[Description("Outras irregularidades")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	OUTRAS_IRREGULARIDADES2 = 835,
	[Description("Conta de cobrança com flash cadastrado e sem registro de mensagem correspondente")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN341_CNAB400
	})]
	CAMPO_ERRO_FLASH_INVALIDO = 836,
	[Description("Outros motivos")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN001_CBR643
	})]
	OUTROS_MOTIVOS = 837,
	[Description("Código de DDD inválido")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_DDD_INVALIDO = 838,
	[Description("Bancos correspondentes")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumCodigoMovimentoRetorno.TARIFAS_DIVERSAS,
		EnumChaveContexto.BAN399_CNAB400
	})]
	BANCOS_CORRESPONDENTES2 = 839,
	[Description("Telefone beneficiário não informado / inconsistente")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN237_CNAB400
	})]
	TELEFONE_BENEFICIARIO_NAO_INFORMADO = 1123,
	[Description("Aceito")]
	[AtributoDominio("A", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_PROTESTO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ACEITO = 840,
	[Description("Rejeição da alteração do número controle do participante")]
	[AtributoDominio("A1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_ALTERACAO_NUMERO_CONTROLE_PARTICIPANTE = 841,
	[Description("Praça do pagador não cadastrada")]
	[AtributoDominio("A2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PRACA_PAGADOR_NAO_CADASTRADA = 842,
	[Description("Rejeição da alteração dos dados do sacado")]
	[AtributoDominio("A2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_ALTERACAO_DADOS_SACADO = 843,
	[Description("Tipo de cobrança do título divergente com praça do pagador")]
	[AtributoDominio("A2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_COBRANCA_TITULO_DIVERGENTE_PRACA_PAGADOR = 844,
	[Description("Rejeição da alteração dos dados do sacador avalista")]
	[AtributoDominio("A3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REJEICAO_ALTERACAO_DADOS_SACADOR_AVALISTA = 845,
	[Description("Cooperativa/agência depositária divergente")]
	[AtributoDominio("A3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	COOPERATIVA_AGENCIA_DEPOSITARIA_DIVERGENTE = 846,
	[Description("Sacado DDA")]
	[AtributoDominio("A4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN748_FEBRABAN240
	})]
	SACADO_DDA = 847,
	[Description("Beneficiário não cadastrado ou possui CNPJ inválido")]
	[AtributoDominio("A4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	BENEFICIARIO_NAO_CADASTRADO_OU_CNPJ_INVALIDO = 848,
	[Description("Registro rejeitado - título já liquidado")]
	[AtributoDominio("A5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	REGISTRO_REJEITADO_TITULO_JA_LIQUIDADO = 849,
	[Description("Pagador não cadastrado")]
	[AtributoDominio("A5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_NAO_CADASTRADO = 850,
	[Description("Código do convenente inválido ou encerrado")]
	[AtributoDominio("A6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	CODIGO_CONVENENTE_INVALIDO_OU_ENCERRADO = 851,
	[Description("Data da instrução/ocorrência inválida")]
	[AtributoDominio("A6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_INSTRUCAO_OCORRENCIA_INVALIDA = 852,
	[Description("Título já se encontra na situação pretendida")]
	[AtributoDominio("A7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TITULO_JA_SE_ENCONTRA_SITUACAO_PRETENDIDA = 853,
	[Description("Ocorrência não pode ser comandada")]
	[AtributoDominio("A7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	OCORRENCIA_NAO_PODE_SER_COMANDADA = 854,
	[Description("Valor do abatimento inválido para cancelamento")]
	[AtributoDominio("A8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN136_CNAB400,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	VALOR_ABATIMENTO_INVALIDO_PARA_CANCELAMENTO = 855,
	[Description("Recebimento da liquidação fora da rede Sicredi - via compensação eletrônica")]
	[AtributoDominio("A8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	RECEBIMENTO_LIQUIDACAO_FORA_REDE_SICREDI = 856,
	[Description("Não autoriza pagamento parcial")]
	[AtributoDominio("A9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	NAO_AUTORIZA_PAGAMENTO_PARCIAL = 857,
	[Description("Tarifa de manutenção de título vencido")]
	[AtributoDominio("A9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_MANUTENCAO_TITULO_VENCIDO = 858,
	[Description("Código de desconto preenchido, obrigatório informar data e valor/percentual")]
	[AtributoDominio("AA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_DESCONTO_PREENCHIDO_OBRIGATORIO_INFORMAR_DATA_VALOR = 859,
	[Description("Código de desconto obrigatório para código de movimento = 7")]
	[AtributoDominio("AB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_DESCONTO_OBRIGATORIO = 860,
	[Description("Forma de cadastramento inválida")]
	[AtributoDominio("AC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	FORMA_CADASTRAMENTO_INVALIDA = 861,
	[Description("Data de desconto deve estar em ordem crescente")]
	[AtributoDominio("AD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_DESCONTO_DEVE_ESTAR_ORDEM_CRESCENTE = 862,
	[Description("Data de desconto é posterior a data de vencimento")]
	[AtributoDominio("AE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_DESCONTO_POSTERIOR_VENCIMENTO = 863,
	[Description("Título não está com situação EM ABERTO")]
	[AtributoDominio("AF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TITULO_NAO_ESTA_SITUACAO_EM_ABERTO = 864,
	[Description("Título já está vencido/vencendo")]
	[AtributoDominio("AG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TITULO_JA_ESTA_VENCIDO_VENCENDO = 865,
	[Description("Não existe desconto a ser cancelado")]
	[AtributoDominio("AH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NAO_EXISTE_DESCONTO_A_SER_CANCELADO = 866,
	[Description("Data solicitada para protesto/devolução é anterior a data atual")]
	[AtributoDominio("AI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_SOLICITADA_PARA_PROTESTO_DEVOLUCAO_ANTERIOR_DATA_ATUAL = 867,
	[Description("Código do sacado inválido")]
	[AtributoDominio("AJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_SACADO_INVALIDO = 868,
	[Description("Número da parcela inválida ou fora da sequência")]
	[AtributoDominio("AK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_PARCELA_INVALIDA_FORA_DA_SEQUENCIA = 869,
	[Description("Estorno de envio não permitido")]
	[AtributoDominio("AL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ESTORNO_DE_ENVIO_NAO_PERMITIDO = 870,
	[Description("Nosso número dora de sequência")]
	[AtributoDominio("AM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NOSSO_NUMERO_FORA_SEQUENCIA = 871,
	[Description("Autoriza pagamento parcial")]
	[AtributoDominio("B1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	AUTORIZA_PAGAMENTO_PARCIAL = 872,
	[Description("Tarifa de baixa da carteira")]
	[AtributoDominio("B1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_DE_BAIXA_DA_CARTEIRA = 873,
	[Description("Valor nominal do título conflitante")]
	[AtributoDominio("B2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	VALOR_NOMINAL_CONFLITANTE = 1148,
	[Description("Tarifa de registro de entrada de título")]
	[AtributoDominio("B3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_REGISTRO_ENTRADA_TITULOS = 874,
	[Description("Tipo de pagamento inválido")]
	[AtributoDominio("B3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	TIPO_PAGAMENTO_INVALIDO = 1149,
	[Description("Tipo de moeda inválido")]
	[AtributoDominio("B4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_MOEDA_INVALIDO2 = 875,
	[Description("Valor máximo/percentual inválido")]
	[AtributoDominio("B4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	VALOR_MAXIMO_PERCENTUAL_INVALIDO = 1150,
	[Description("Tipo de desconto/juros inválido")]
	[AtributoDominio("B5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_DESCONTO_JUROS_INVALIDO = 876,
	[Description("Valor mínimo/percentual inválido")]
	[AtributoDominio("B5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	VALOR_MINIMO_PERCENTUAL_INVALIDO = 1151,
	[Description("Mensage padrão não cadastrada")]
	[AtributoDominio("B6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	MENSAGEM_PADRAO_NAO_CADASTRADA = 877,
	[Description("Seu número inválido")]
	[AtributoDominio("B7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	SEU_NUMERO_INVALIDO = 878,
	[Description("Percentual de multa inválido")]
	[AtributoDominio("B8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PERCENTUAL_MULTA_INVALIDO = 879,
	[Description("Valor ou percentual de juros inválido")]
	[AtributoDominio("B9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VALOR_PERCENTUAL_JUROS_INVALIDO2 = 880,
	[Description("Sistema intermitente - Entre em contato com a sua Cooperativa")]
	[AtributoDominio("C0", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	SISTEMA_INTERMITENTE = 1154,
	[Description("Situação do título aberto")]
	[AtributoDominio("C1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	SITUACAO_TITULO_ABERTO = 1155,
	[Description("Data limite para concessão de desconto inválida")]
	[AtributoDominio("C1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_LIMITE_CONCESSAO_DESCONTO_INVALIDA = 881,
	[Description("Aceite do título inválido")]
	[AtributoDominio("C2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ACEITE_TITULO_INVALIDO = 882,
	[Description("Status do borderô inválido")]
	[AtributoDominio("C3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	STATUS_BORDERO_INVALIDO = 1156,
	[Description("Campo alterado na instrução '31 - alteração de outros dados' inválido")]
	[AtributoDominio("C3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CAMPO_ALTERADO_INSTRUCAO_31_INVALIDO = 883,
	[Description("Nome do beneficiário inválido")]
	[AtributoDominio("C4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	NOME_BENEFICIARIO_INVALIDO = 1157,
	[Description("Título ainda não foi confirmado pela centralizadora")]
	[AtributoDominio("C4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_AINDA_NAO_CONFIRMADO_PELA_CENTRALIZADORA = 884,
	[Description("Título rejeitado pela centralizadora")]
	[AtributoDominio("C5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_REJEITADO_PELA_CENTRALIZADORA = 885,
	[Description("Documento inválido")]
	[AtributoDominio("C5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	DOCUMENTO_INVALIDO = 1158,
	[Description("Título já liquidado")]
	[AtributoDominio("C6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_JA_LIQUIDADO = 886,
	[Description("Instrução não atualiza cadastro do título")]
	[AtributoDominio("C5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN136_CNAB400
	})]
	INSTRUCAO_NAO_ATUALIZA_CADASTRO_TITULO = 1159,
	[Description("Título já baixado")]
	[AtributoDominio("C7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.BAIXA_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_JA_BAIXADO = 887,
	[Description("Existe mesma instrução pendente de confirmação para este título")]
	[AtributoDominio("C8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	EXISTE_MESMA_INSTRUCAO_PENDENTE = 888,
	[Description("Instrução prévia de concessão de abatimento não existe ou não confirmada")]
	[AtributoDominio("C9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	INSTRUCAO_PREVIA_CONCESSAO_ABATIMENTO_NAO_EXISTE = 889,
	[Description("Desprezado")]
	[AtributoDominio("D", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.CONFIRMACAO_RECEBIMENTO_INSTRUCAO_DE_PROTESTO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DESPREZADO = 890,
	[Description("Título dentro do prazo de vencimento (em dia)")]
	[AtributoDominio("D1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_DENTRO_PRAZO_VENCIMENTO = 891,
	[Description("Espécie de documento não permite protesto de título")]
	[AtributoDominio("D2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ESPECIE_DOCUMENTO_NAO_PERMITE_PROTESTO = 892,
	[Description("Título possui instrução de baixa pendente de confirmação")]
	[AtributoDominio("D3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_POSSUI_INSTRUCAO_BAIXA_PENDENTE_CONFIRMACAO = 893,
	[Description("Quantidade de mensagens padrão excede o limite permitido")]
	[AtributoDominio("D4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	QUANTIDADE_MENSAGENS_PADRAO_EXCEDE_LIMITE_PERMITIDO = 894,
	[Description("Quantidade inválida no pedido de boletos pré-impressos da cobrança sem registro")]
	[AtributoDominio("D5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	QUANTIDADE_INVALIDA_PEDIDO_BOLETOS_PRE_IMPRESSOS_COBRANCA_SEM_REGISTRO = 895,
	[Description("Tipo de impressão inválida para cobrança sem registro")]
	[AtributoDominio("D6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_IMPRESSAO_INVALIDA_COBRANCA_SEM_REGISTRO = 896,
	[Description("Cidade ou estado do pagador não informado")]
	[AtributoDominio("D7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CIDADE_OU_ESTADO_PAGADOR_NAO_INFORMADO = 897,
	[Description("Sequência para composição do nosso número do ano atual esgotada")]
	[AtributoDominio("D8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	SEQUENCIA_COMPOSICAO_NOSSO_NUMERO_ANO_ATUAL_ESGOTADA = 898,
	[Description("Registro mensagem para título não cadastrado")]
	[AtributoDominio("D9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGISTRO_MENSAGEM_PARA_TITULO_NAO_CADASTRADO = 899,
	[Description("Registro complementar ao cadastro do título da cobrança com e sem registro não cadastrado")]
	[AtributoDominio("E2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGISTRO_COMPLEMENTAR_AO_CADASTRO_DO_TITULO = 900,
	[Description("Tipo de postagem inválido, diferente de S, N e branco")]
	[AtributoDominio("E3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_POSTAGEM_INVALIDO = 901,
	[Description("Pedido de boletos pré-impressos")]
	[AtributoDominio("E4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PEDIDOS_BOLETOS_PRE_IMPRESSOS = 902,
	[Description("Confirmação/rejeição para pedidos de boletos não cadastrados")]
	[AtributoDominio("E5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONFIRMACAO_REJEICAO_PEDIDOS_BOLETOS_NAO_CADASTRADOS = 903,
	[Description("Pagador/Avalista não cadastrado")]
	[AtributoDominio("E6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_AVALISTA_NAO_CADASTRADO = 904,
	[Description("Informação para atualização do valor do título para protesto inválido")]
	[AtributoDominio("E7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	INFORMACAO_PARA_ATUALIZACAO_VALOR_TITULO_PARA_PROTESTO_INVALIDO = 905,
	[Description("Tipo de impressão inválido, diferente de A, B e branco")]
	[AtributoDominio("E8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_IMPRESSAO_INVALIDO2 = 906,
	[Description("Código do pagador do título divergente com o código da cooperativa de crédito")]
	[AtributoDominio("E9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_PAGADOR_DIVERGENTE_CODIGO_COOPERATIVA_DE_CRÉDITO = 907,
	[Description("Liquidado no sistema do cliente")]
	[AtributoDominio("F1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	LIQUIDADO_NO_SISTEMA_DO_CLIENTE = 908,
	[Description("Baixado no sistema do cliente")]
	[AtributoDominio("F2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	BAIXADO_NO_SISTEMA_DO_CLIENTE = 909,
	[Description("Instrução inválida, este título está caucionado/descontado")]
	[AtributoDominio("F3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	INSTRUCAO_INVALIDA_TITULO_CAUCIONADO_DESCONTADO = 910,
	[Description("Instrução fixa com caracteres inválidos")]
	[AtributoDominio("F4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	INSTRUCAO_FIXA_COM_CARACTERES_INVALIDOS = 911,
	[Description("Tarifa de entrada na rede Sicredi")]
	[AtributoDominio("F5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.DEBITO_DE_TARIFA_CUSTAS,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TARIFA_ENTRADA_REDE_SICREDI = 912,
	[Description("Nosso número/número da parcela fora da sequência - total de parcelas inválido")]
	[AtributoDominio("F6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOSSO_NUMERO_NUMERO_PARCELA_FORA_SEQUENCIA = 913,
	[Description("Falta de comprovante na prestação de serviço")]
	[AtributoDominio("F7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	FALTA_COMPROVANTE_PRESTACAO_SERVICO = 914,
	[Description("Nome do beneficiário incompleto ou incorreto")]
	[AtributoDominio("F8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOME_BENEFICIARIO_INCOMPLETO_OU_INCORRETO = 915,
	[Description("CNPJ ou CPF incompatível com o nome do pagador / sacador avalista")]
	[AtributoDominio("F9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CNPJ_CPF_INCOMPATIVEL_NOME_PAGADOR_SACADOR_AVALISTA = 916,
	[Description("CNPJ ou CPF do pagador incompatível com a espécie")]
	[AtributoDominio("G1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CNPJ_CPF_PAGADOR_INCOMPATIVEL_COM_ESPECIE = 917,
	[Description("Título aceito: sem assinatura do pagador")]
	[AtributoDominio("G2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REMESSA_A_CARTORIO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_ACEITO_SEM_ASSINATURA_PAGADOR = 918,
	[Description("Título aceito: rasurado ou rasgado")]
	[AtributoDominio("G3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REMESSA_A_CARTORIO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULOA_ACEITO_RASURADO_OU_RASGADO = 919,
	[Description("Título aceito: falta título")]
	[AtributoDominio("G4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REMESSA_A_CARTORIO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_ACEITO_FALTA_TITULO = 920,
	[Description("Praça de pagamento incompatível com o endereço")]
	[AtributoDominio("G5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PRACA_DE_PAGAMENTO_INCOMPATIVEL_COM_ENDERECO = 921,
	[Description("Título_aceito: sem endosso ou beneficiário irregular")]
	[AtributoDominio("G6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REMESSA_A_CARTORIO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_ACEITO_SEM_ENDOSSO_OU_BENEFICIARIO_IRREGULAR = 922,
	[Description("Título aceito: valor por extenso diferente do valor numérico")]
	[AtributoDominio("G7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.REMESSA_A_CARTORIO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_ACEITO_VALOR_POR_EXTENSO_DIFERENTE_VALOR_NUMERICO = 923,
	[Description("Saldo maior que o valor do título")]
	[AtributoDominio("G8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	SALDO_MAIOR_QUE_VALOR_TITULO = 924,
	[Description("Tipo do endosso inválido")]
	[AtributoDominio("G9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TIPO_ENDOSSO_INVALIDO = 925,
	[Description("Nome do pagador incompleto ou incorreto")]
	[AtributoDominio("H1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOME_PAGADOR_INCOMPLETO_OU_INCORRETO = 926,
	[Description("Sustação judicial")]
	[AtributoDominio("H2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	SUSTACAO_JUDICIAL = 927,
	[Description("Pagador não encontrado")]
	[AtributoDominio("H3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_NAO_ENCONTRADO = 928,
	[Description("Alteração de carteira")]
	[AtributoDominio("H4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ALTERACAO_DE_CARTEIRA = 929,
	[Description("Recebimento de liquidação fora da rede Sicredi - VLB inferior - via compensação")]
	[AtributoDominio("H5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VLB_INFERIOR = 930,
	[Description("Recebimento de liquidação fora da rede Sicredi - VLB superior - via compensação")]
	[AtributoDominio("H6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VLB_SUPERIOR = 931,
	[Description("Espécie de documento necessita beneficiário ou avalista do tipo pessoa jurídica")]
	[AtributoDominio("H7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ESPECIE_DOCUMENTO_NECESSITA_PJ = 932,
	[Description("Recebimento de liquidação fora da rede Sicredi - Contigência via compensação")]
	[AtributoDominio("H8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.LIQUIDACAO_APOS_BAIXA_OU_LIQUIDACAO_TITULO_NAO_REGISTRADO,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONTIGENCIA_VIA_COMPENSACAO = 933,
	[Description("Dados do título não conferem com disquete")]
	[AtributoDominio("H9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DADOS_TITULO_NAO_CONFEREM_COM_DISQUETE = 934,
	[Description("Pagador e sacador avalista são a mesma pessoa")]
	[AtributoDominio("I1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_SACADOR_AVALISTA_SAO_MESMA_PESSOA = 935,
	[Description("Aguardar um dia útil após o vencimento para protestar")]
	[AtributoDominio("I2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	AGUARDAR_UM_DIA_UTIL_APOS_VENCIMENTO_PARA_PROTESTAR = 936,
	[Description("Data de venvcimento rasurada")]
	[AtributoDominio("I3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_VENCIMENTO_RASURADA = 937,
	[Description("Vencimento - extenso não confere com número")]
	[AtributoDominio("I4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	VENCIMENTO_EXTENSO_NAO_CONFERE_COM_NUMERO = 938,
	[Description("Falta data de vencimento no título")]
	[AtributoDominio("I5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	FALTA_DATA_VENCIMENTO_TITULO = 939,
	[Description("DM/DMI sem comprovante autenticado ou declaração")]
	[AtributoDominio("I6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DM_DMI_SEM_COMPROVANTE_AUTENTICADO = 940,
	[Description("Comprovante ilegível para conferência e microfilmagem")]
	[AtributoDominio("I7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	COMPROVANTE_ILEGIVEL_PARA_CONFERENCIA = 941,
	[Description("Nome solicitado não confere com emitente ou pagador")]
	[AtributoDominio("I8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOME_SOLICITADO_NAO_CONFERE_COM_EMITENTE_PAGADOR = 942,
	[Description("Confirmar se são 2 emitentes. Se sim, confirmar os dados do 2º")]
	[AtributoDominio("I9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONFIRMAR_SE_SAO_DOIS_EMITENTES = 943,
	[Description("Endereço do pagador igual ao do portador")]
	[AtributoDominio("J1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ENDERECO_PAGADOR_IGUAL_PORTADOR = 944,
	[Description("Endereço do apresentante incompleto ou não informado")]
	[AtributoDominio("J2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ENDERECO_APRESENTANTE_INCOMPLETO = 945,
	[Description("Rua ou número inexistente no endereço")]
	[AtributoDominio("J3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	RUA_OU_NUMERO_INEXISTENTE_NO_ENDERECO = 946,
	[Description("Falta endosso do favorecido para o apresentante")]
	[AtributoDominio("J4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	FALTA_ENDOSSO_FAVORECIDO_PARA_APRESENTANTE = 947,
	[Description("Data de emissão rasurada")]
	[AtributoDominio("J5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DATA_EMISSAO_RASURADA = 948,
	[Description("Falta assinatura do pagador do título")]
	[AtributoDominio("J6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	FALTA_ASSINATURA_PAGADOR_TITULO = 949,
	[Description("Nome do apresentante não informado ou incompleto ou incorreto")]
	[AtributoDominio("J7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NOME_APRESENTANTE_NAO_INFORMADO_OU_INCOMPLETO_OU_INCORRETO = 950,
	[Description("Erro no preenchimento do título")]
	[AtributoDominio("J8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	ERRO_PREENCHIMENTO_TITULO = 951,
	[Description("Título com direito de regresso vencido")]
	[AtributoDominio("J9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_COM_DIREITO_REGRESSO_VENCIDO = 952,
	[Description("Título apresentado em duplicidade")]
	[AtributoDominio("K1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_APRESENTADO_EM_DUPLICIDADE = 953,
	[Description("Título já protestado")]
	[AtributoDominio("K2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_JA_PROTESTADO = 954,
	[Description("Letra de câmbio vencida - falta aceite do pagador")]
	[AtributoDominio("K3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	LETRA_CAMBIO_VENCIDA = 955,
	[Description("Falta declaração de saldo assinada no título")]
	[AtributoDominio("K4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	FALTA_DECLARACAO_DE_SALDO_ASSINANDA_TITULO = 956,
	[Description("Contrato de câmbio - falta conta gráfica")]
	[AtributoDominio("K5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CONTRATO_CAMBIO = 957,
	[Description("Ausência de documento físico")]
	[AtributoDominio("K6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	AUSENCIA_DOCUMENTO_FISICO = 958,
	[Description("Pagador falecido")]
	[AtributoDominio("K7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_FALECIDO = 959,
	[Description("Pagador apresentou quitação do título")]
	[AtributoDominio("K8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_APRESENTOU_QUITACAO_TITULO = 960,
	[Description("Título de outra jurisdição territorial")]
	[AtributoDominio("K9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_OUTRA_JURISDICAO_TERRITORIAL = 961,
	[Description("Título com emissão anterior a concordata do pagador")]
	[AtributoDominio("L1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	TITULO_EMISSAO_ANTEIOR_CONCORDATA_PAGADOR = 962,
	[Description("Pagador consta na lista de falência")]
	[AtributoDominio("L2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGADOR_CONSTA_LISTA_FALENCIA = 963,
	[Description("Apresentante não aceita publicação de edital")]
	[AtributoDominio("L3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	APRESENTANTE_NAO_ACEITA_PUBLICACAO_EM_EDITAL = 964,
	[Description("Dados do pagador em branco ou inválido")]
	[AtributoDominio("L4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	DADOS_PAGADOR_EM_BRANCO_OU_INVALIDO = 965,
	[Description("Código do pagador na agência beneficiária está duplicado")]
	[AtributoDominio("L5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CODIGO_PAGADOR_DUPLICADO = 966,
	[Description("Reconhecimento da dívida pelo pagador")]
	[AtributoDominio("M1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ACEITE_DO_PAGADOR,
		EnumChaveContexto.BAN748_CNAB400
	})]
	RECONHECIMENTO_DA_DIVIDA_PELO_PAGADOR = 967,
	[Description("Não reconhecimento da dívida pelo pagador")]
	[AtributoDominio("M2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.OCORRENCIAS_DO_SACADO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	NAO_RECONHECIMENTO_DA_DIVIDA_PELO_PAGADOR = 968,
	[Description("Regularização centralizadora - Rede Sicredi")]
	[AtributoDominio("X1", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGULARIZACAO_CENTRALIZADORA_REDE_SICREDI = 969,
	[Description("Regularização centralizadora - Compensação")]
	[AtributoDominio("X2", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGULARIZACAO_CENTRALIZADORA_COMPENSACAO = 970,
	[Description("Regularização centralizadora - Banco correspondente")]
	[AtributoDominio("X3", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGULARIZACAO_CENTRALIZADORA_BANCO_CORRESPONDENTE = 971,
	[Description("Regularização centralizadora - VLB inferior - via compensação")]
	[AtributoDominio("X4", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGULARIZACAO_CENTRALIZADORA_VLB_INFERIOR = 972,
	[Description("Regularização centralizadora - VLB superior - via compensação")]
	[AtributoDominio("X5", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	REGULARIZACAO_CENTRALIZADORA_VLB_SUPERIOR = 973,
	[Description("Pago com cheque")]
	[AtributoDominio("X0", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE = 974,
	[Description("Pago com cheque - bloqueado 24 horas")]
	[AtributoDominio("X6", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_24_HORAS = 975,
	[Description("Pago com cheque - bloqueado 48 horas")]
	[AtributoDominio("X7", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_48_HORAS = 976,
	[Description("Pago com cheque - bloqueado 72 horas")]
	[AtributoDominio("X8", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_72_HORAS = 977,
	[Description("Pago com cheque - bloqueado 96 horas")]
	[AtributoDominio("X9", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_96_HORAS = 978,
	[Description("Pago com cheque - bloqueado 120 horas")]
	[AtributoDominio("XA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_120_HORAS = 979,
	[Description("Pago com cheque - bloqueado 144 horas")]
	[AtributoDominio("XB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA2,
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.LIQUIDACAO,
		EnumChaveContexto.BAN748_CNAB400
	})]
	PAGO_COM_CHEQUE_BLOQUEADO_144_HORAS = 980,
	[Description("Arquivo de retorno inexistente para redisp. Nesta Data/Número")]
	[AtributoDominio("VA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ARQUIVO_RETORNO_INEXISTENTE = 981,
	[Description("Registro duplicado")]
	[AtributoDominio("VB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	REGISTRO_DUPLICADO = 982,
	[Description("Cedente deve ser padrão FEBRABAN240")]
	[AtributoDominio("VC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CEDENTE_DEVE_SER_PADRAO_FEBRABAN240 = 983,
	[Description("Indentificação do banco sacado inválida")]
	[AtributoDominio("VD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	IDENTIFICACAO_BANCO_SACADO_INVALIDA = 984,
	[Description("Número do documento de cobrança inválido")]
	[AtributoDominio("VE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_DOCUMENTO_COBRANCA_INVALIDO = 985,
	[Description("Valor/percentual a ser concedido inválido")]
	[AtributoDominio("VF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_PERCENTUAL_A_SER_CONCEDIDO_INVALIDO = 986,
	[Description("Data de inscrição inválida")]
	[AtributoDominio("VG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_INSCRICAO_INVALIDA = 987,
	[Description("Data de movimento inválida")]
	[AtributoDominio("VH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_MOVIMENTO_INVALIDA = 988,
	[Description("Data inicial inválida")]
	[AtributoDominio("VI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_INICIAL_INVALIDA = 989,
	[Description("Data final inválida")]
	[AtributoDominio("VJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_FINAL_INVALIDA = 990,
	[Description("Banco de sacado já cadastrado")]
	[AtributoDominio("VK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	BANCO_SACADO_JA_CADASTRADO = 991,
	[Description("Cedente não cadastrado")]
	[AtributoDominio("VL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CEDENTE_NAO_CADASTRADO = 992,
	[Description("Número de lote duplicado")]
	[AtributoDominio("VM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_LOTE_DUPLICADO = 993,
	[Description("Forma de emissão de bloqueto inválida")]
	[AtributoDominio("VN", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	FORMA_EMISSAO_BLOQUETO_INVALIDA = 994,
	[Description("Forma entrega bloqueto inválida para emissão via banco")]
	[AtributoDominio("VO", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	FORMA_ENTREGA_BLOQUETO_INVALIDA_PARA_EMISSAO_VIA_BANCO = 995,
	[Description("Forma entrega bloqueto inválida para emissão via cedente")]
	[AtributoDominio("VP", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	FORMA_ENTREGA_BLOQUETO_INVALIDA_PARA_EMISSAO_VIA_CEDENTE = 996,
	[Description("Opção para endosso inválida")]
	[AtributoDominio("VQ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	OPCAO_PARA_ENDOSSO_INVALIDA = 997,
	[Description("Tipo de juros ao mês inválido")]
	[AtributoDominio("VR", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_JUROS_AO_MES_INVALIDO = 998,
	[Description("Percentual de juros ao mês inválido")]
	[AtributoDominio("VS", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_JUROS_AO_MES_INVALIDO = 999,
	[Description("Percentual/valor de desconto inválido")]
	[AtributoDominio("VT", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_VALOR_DESCONTO_INVALIDO = 1000,
	[Description("Prazo de desconto inválido")]
	[AtributoDominio("VU", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PRAZO_DESCONTO_INVALIDO = 1001,
	[Description("Preencher somente percentual ou valor")]
	[AtributoDominio("VV", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PREENCHER_SOMENTE_PERCENTUAL_VALOR = 1002,
	[Description("Prazo de multa inválido")]
	[AtributoDominio("VW", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PRAZO_MULTA_INVALIDO = 1003,
	[Description("Percentual de desconto tem que estar em ordem decrescente")]
	[AtributoDominio("VX", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_DESCONTO_DEVE_ESTAR_ORDEM_DECRESCENTE = 1004,
	[Description("Valor desconto tem que estar em ordem decrescente")]
	[AtributoDominio("VY", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DESCONTO_TEM_QUE_ESTAR_EM_ORDEM_DECRESCENTE = 1005,
	[Description("Dias/data de desconto tem que estar em ordem decrescente")]
	[AtributoDominio("VZ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DIAS_DATA_DESCONTO_DEVE_ESTAR_ORDEM_DECRESCENTE = 1006,
	[Description("Valor do contrato para aquisição de bens inválido")]
	[AtributoDominio("WA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CONTRATO_AQUISICAO_DE_BENS_INVALIDO = 1007,
	[Description("Valor do contrato para fundo de reserva inválido")]
	[AtributoDominio("WB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CONTRATO_FUNDO_RESERVA_INVALIDO = 1008,
	[Description("Valor de rendimento de aplicações financiamento inválido")]
	[AtributoDominio("WC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_RENDIMENTO_APLICACOES_FINANCIAMENTO_INVALIDO = 1009,
	[Description("Valor multa/juros monetários inválido")]
	[AtributoDominio("WD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_MULTA_JUROS_MONETARIOS_INVALIDO = 1010,
	[Description("Valor prêmios de seguro inválido")]
	[AtributoDominio("WE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_PREMIOS_SEGURO_INVALIDO = 1011,
	[Description("Valor custas judiciais inválido")]
	[AtributoDominio("WF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CUSTAS_JUDICIAIS_INVALIDO = 1012,
	[Description("Valor reembolso de despesas inválido")]
	[AtributoDominio("WG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_REEMBOLSO_DESPESAS_INVALIDO = 1013,
	[Description("Valor outros inválido")]
	[AtributoDominio("WH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_OUTROS_INVALIDO = 1014,
	[Description("Valor da aquisição de bens inválido")]
	[AtributoDominio("WI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_AQUISICAO_BENS_INVALIDO = 1015,
	[Description("Valor devolvido ao consorciado inválido")]
	[AtributoDominio("WJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DEVOLVIDO_CONSORCIADO_INVALIDO = 1016,
	[Description("Valor de despesa de registro de contrato inválido")]
	[AtributoDominio("WK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DESPESA_REGISTRO_CONTRATO_INVALIDO = 1017,
	[Description("Valor de rendimentos pagos inválido")]
	[AtributoDominio("WL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_RENDIMENTO_PAGOS_INVALIDO = 1018,
	[Description("Data de descrição inválida")]
	[AtributoDominio("WM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_DESCRICAO_INVALIDA = 1019,
	[Description("Valor do seguro inválido")]
	[AtributoDominio("WN", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_SEGURO_INVALIDO = 1020,
	[Description("Data de vencimento inválida")]
	[AtributoDominio("WO", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_VENCIMENTO_INVALIDA8 = 1021,
	[Description("Data de nascimento inválida")]
	[AtributoDominio("WP", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_NASCIMENTO_INVALIDA = 1022,
	[Description("CPF/CNPJ do aluno inválido")]
	[AtributoDominio("WQ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CPF_CNPJ_ALUNO_INVALIDO = 1023,
	[Description("Data de avaliação inválida")]
	[AtributoDominio("WR", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_AVALIACAO_INVALIDA = 1024,
	[Description("CPF/CNPJ do locatário inválido")]
	[AtributoDominio("WS", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CPF_CNPJ_LOCATARIO_INVALIDO = 1025,
	[Description("Literal da remessa inválido")]
	[AtributoDominio("WT", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	LITERAL_REMESSA_INVALIDO = 1026,
	[Description("Tipo de registro inválido")]
	[AtributoDominio("WU", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_REGISTRO_INVALIDO = 1027,
	[Description("Modelo inválido")]
	[AtributoDominio("WV", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	MODELO_INVALIDO = 1028,
	[Description("Código do banco do sacado inválido")]
	[AtributoDominio("WW", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_BANCO_SACADO_INVALIDO = 1029,
	[Description("Banco do sacado não cadastrado")]
	[AtributoDominio("WX", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	BANCO_SACADO_NAO_CADASTRADO = 1030,
	[Description("Quantidade de dias para protesto tem que estar entre 2 e 90")]
	[AtributoDominio("WY", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_DIAS_PROTESTO_TEM_QUE_ESTAR_ENTRE_2_E_90 = 1031,
	[Description("Não existem sacados para este banco")]
	[AtributoDominio("WZ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NAO_EXISTEM_SACADOS_PARA_ESTE_BANCO = 1032,
	[Description("Preço unitário do produto inválido")]
	[AtributoDominio("XA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PRECO_UNITARIO_PRODUTO_INVALIDO = 1033,
	[Description("Preco total do produto inválido")]
	[AtributoDominio("XB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PRECO_TOTAL_PRODUTO_INVALIDO = 1034,
	[Description("Valor atual do bem inválido")]
	[AtributoDominio("XC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_ATUAL_DO_BEM_INVALIDO = 1035,
	[Description("Quantidade de bens entregues inválido")]
	[AtributoDominio("XD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_BENS_ENTREGUES_INVALIDO = 1036,
	[Description("Quantidade de bens distribuídos inválido")]
	[AtributoDominio("XE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_BENS_DISTRIBUIDOS_INVALIDO = 1037,
	[Description("Quantidade de bens não entregues inválido")]
	[AtributoDominio("XF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_BENS_NAO_ENTREGUES_INVALIDO = 1038,
	[Description("Número da próxima assembleia inválido")]
	[AtributoDominio("XG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_PROXIMA_ASSEMBLEIA_INVALIDO = 1039,
	[Description("Horário da próxima assembleia inválido")]
	[AtributoDominio("XH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	HORARIO_PROXIMA_ASSEMBLEIA_INVALIDO = 1040,
	[Description("Data da próxima assembleia inválida")]
	[AtributoDominio("XI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_PROXIMA_ASSEMBLEIA_INVALIDA = 1041,
	[Description("Número de ativos inválido")]
	[AtributoDominio("XJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_ATIVOS_INVALIDO = 1042,
	[Description("Número de desistentes excluídos inválido")]
	[AtributoDominio("XK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_DESISTENTES_EXCLUIDOS_INVALIDO = 1043,
	[Description("Número de quitados inválido")]
	[AtributoDominio("XL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_QUITADOS_INVALIDO = 1044,
	[Description("Número de contemplados inválido")]
	[AtributoDominio("XM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_CONTEMPLADOS_INVALIDO = 1045,
	[Description("Número de não contemplados inválido")]
	[AtributoDominio("XN", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_NAO_CONTEMPLADOS_INVALIDO = 1046,
	[Description("Data da última assembleia inválido")]
	[AtributoDominio("XO", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_ULTIMA_ASSEMBLEIA_INVALIDO = 1047,
	[Description("Quantidade de prestações inválida")]
	[AtributoDominio("XP", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_PRESTACOES_INVALIDA = 1048,
	[Description("Data de vencimento da parcela inválida")]
	[AtributoDominio("XQ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_VENCIMENTO_PARCELA_INVALIDA = 1049,
	[Description("Valor da amortização inválido")]
	[AtributoDominio("XR", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_AMORTIZACAO_INVALIDO = 1050,
	[Description("Código do personalizado inválido")]
	[AtributoDominio("XS", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_PERSONALIZADO_INVALIDO = 1051,
	[Description("Valor da contribuição inválido")]
	[AtributoDominio("XT", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CONTRIBUICAO_INVALIDO = 1052,
	[Description("Percentual de contribuição inválido")]
	[AtributoDominio("XU", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_CONTRIBUICAO_INVALIDO = 1053,
	[Description("Valor do fundo reserva inválido")]
	[AtributoDominio("XV", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_FUNDO_RESERVA_INVALIDO = 1054,
	[Description("Número da parcela inválido ou fora da sequência")]
	[AtributoDominio("XW", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_PARCELA_INVALIDO_FORA_SEQUENCIA = 1055,
	[Description("Percentual fundo de reserva inválido")]
	[AtributoDominio("XX", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_FUNDO_RESERVA_INVALIDO = 1056,
	[Description("Prazo para desconto/multa preenchido, obrigatório informar o percentual ou valor")]
	[AtributoDominio("XY", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PRAZO_DESCONTO_MULTA_INFORMADO_OBRIGATORIO_INFORMAR_PERCENTUAL_VALOR = 1057,
	[Description("Valor taxa de administração inválida")]
	[AtributoDominio("XZ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_TAXA_ADMINISTRACAO_INVALIDA = 1058,
	[Description("Data de juros inválida ou não informada")]
	[AtributoDominio("YA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_JUROS_INVALIDA_OU_NAO_INFORMADA = 1059,
	[Description("Data desconto inválida ou não informada")]
	[AtributoDominio("YB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_DESCONTO_INVALIDA_OU_NAO_INFORMADA = 1060,
	[Description("E-mail inválido")]
	[AtributoDominio("YC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	EMAIL_INVALIDO = 1061,
	[Description("Código de ocorrência inválido")]
	[AtributoDominio("YD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_OCORRENCIA_INVALIDO2 = 1062,
	[Description("Sacado já cadastrado")]
	[AtributoDominio("YE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	SACADO_JA_CADASTRADO = 1063,
	[Description("Sacado não cadastrado")]
	[AtributoDominio("YF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	SACADO_NAO_CADASTRADO = 1064,
	[Description("Remessa sem registro tipo 9")]
	[AtributoDominio("YG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	REMESSA_SEM_REGISTRO_TIPO_9 = 1065,
	[Description("Identificação da solicitação inválida")]
	[AtributoDominio("YH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	IDENTIFICACAO_SOLICITACAO_INVALIDA = 1066,
	[Description("Quantidade de bloquetos solicitada inválida")]
	[AtributoDominio("YI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_BLOQUETOS_SOLICITADA_INVALIDA = 1067,
	[Description("Trailler do arquivo não encontrado")]
	[AtributoDominio("YJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TRAILLER_ARQUIVO_NAO_ENCONTRADO = 1068,
	[Description("Tipo inscrição do responsável inválido")]
	[AtributoDominio("YK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	TIPO_INSCRICAO_RESPONSAVEL_INVALIDO = 1069,
	[Description("Número inscrição do responsável inválido")]
	[AtributoDominio("YL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_INSCRICAO_RESPONSAVEL_INVALIDO = 1070,
	[Description("Ajuste de vencimento inválido")]
	[AtributoDominio("YM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	AJUSTE_VENCIMENTO_INVALIDO = 1071,
	[Description("Ajuste de emissão inválido")]
	[AtributoDominio("YN", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	AJUSTE_EMISSAO_INVALIDO = 1072,
	[Description("Código de modelo inválido")]
	[AtributoDominio("YO", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_MODELO_INVALIDO = 1073,
	[Description("Via de entrega inválida")]
	[AtributoDominio("YP", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VIA_ENTREGA_INVALIDA = 1074,
	[Description("Espécie banco de sacado inválido")]
	[AtributoDominio("YQ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ESPECIE_BANCO_SACADO_INVALIDO = 1075,
	[Description("Aceite banco de sacado inválido")]
	[AtributoDominio("YR", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	ACEITA_BANCO_SACADO_INVALIDO = 1076,
	[Description("Sacado já cadastrado")]
	[AtributoDominio("YS", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	SACADO_JA_CADASTRADO2 = 1077,
	[Description("Sacado não cadastrado")]
	[AtributoDominio("YT", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	SACADO_NAO_CADASTRADO2 = 1078,
	[Description("Número do telefone inválido")]
	[AtributoDominio("YU", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	NUMERO_TELEFONE_INVALIDO = 1079,
	[Description("CNPJ do condomínio inválido")]
	[AtributoDominio("YV", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CNPJ_CONDOMINIO_INVALIDO = 1080,
	[Description("Indicador de registro de título inválido")]
	[AtributoDominio("YW", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	INDICADOR_REGISTRO_TITULO_INVALIDO = 1081,
	[Description("Valor da nota inválido")]
	[AtributoDominio("YX", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_NOTA_INVALIDO = 1082,
	[Description("Quantidade de dias para devolução tem q estar entre 5 e 120")]
	[AtributoDominio("YY", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_DIAS_DEVOLUCAO_TEM_QUE_ESTAR_ENTRE_5_E_120 = 1083,
	[Description("Quantidade de produtos inválida")]
	[AtributoDominio("YZ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	QUANTIDADE_PRODUTOS_INVALIDA = 1084,
	[Description("Percentual taxa de administração inválido")]
	[AtributoDominio("ZA", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_TAXA_ADMINISTRACAO_INVALIDO = 1085,
	[Description("Valor de seguro inválido")]
	[AtributoDominio("ZB", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_SEGURO_INVALIDO2 = 1086,
	[Description("Percentual de seguro inválido")]
	[AtributoDominio("ZC", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_SEGURO_INVALIDO = 1087,
	[Description("Valor da diferença da parcela inválido")]
	[AtributoDominio("ZD", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DIFERENCA_PARCELA_INVALIDO = 1088,
	[Description("Percentual da diferença da parcela inválido")]
	[AtributoDominio("ZE", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_DIFERENCA_PARCELA_INVALIDO = 1089,
	[Description("Valor de reajuste de saldo de caixa inválido")]
	[AtributoDominio("ZF", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_REAJUSTE_SALDO_CAIXA_INVALIDO = 1090,
	[Description("Percentual de reajuste do saldo de caixa inválido")]
	[AtributoDominio("ZG", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_REAJUSTE_SALDO_CAIXA_INVALIDO = 1091,
	[Description("Valor total a pagar inválido")]
	[AtributoDominio("ZH", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_TOTAL_A_PAGAR_INVALIDO = 1092,
	[Description("Percentual ao total a pagar inválido")]
	[AtributoDominio("ZI", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_AO_TOTAL_A_PAGAR_INVALIDO = 1093,
	[Description("Valor de outros acréscimos inválido")]
	[AtributoDominio("ZJ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_OUTROS_ACRESCIMOS_INVALIDO = 1094,
	[Description("Percentual de outros acréscimos inválido")]
	[AtributoDominio("ZK", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTAUL_OUTROS_ACRESCIMOS_INVALIDO = 1095,
	[Description("Valor de outras deduções inválido")]
	[AtributoDominio("ZL", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_OUTRAS_DEDUCOES_INVALIDO = 1096,
	[Description("Percentual de outras deduções inválido")]
	[AtributoDominio("ZM", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_OUTRAS_DEDUCOES_INVALIDO = 1097,
	[Description("Valor de contribuição inválido")]
	[AtributoDominio("ZN", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CONTRIBUICAO_INVALIDO2 = 1098,
	[Description("Percentual de contribuição inválido")]
	[AtributoDominio("ZO", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_CONTRIBUICAO_INVALIDO2 = 1099,
	[Description("Valor de juros/multa inválido")]
	[AtributoDominio("ZP", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_JUROS_MULTA_INVALIDO = 1100,
	[Description("Percentual de juros/multa inválido")]
	[AtributoDominio("ZQ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_JUROS_MULTA_INVALIDO = 1101,
	[Description("Valor cobrado inválido")]
	[AtributoDominio("ZR", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_COBRADO_INVALIDO = 1102,
	[Description("Percentual cobrado inválido")]
	[AtributoDominio("ZS", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	PERCENTUAL_COBRADO_INVALIDO = 1103,
	[Description("Valor disponibilizado em caixa inválido")]
	[AtributoDominio("ZT", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DISPONIBILIZADO_CAIXA_INVALIDO = 1104,
	[Description("Valor depósito bancário inválido")]
	[AtributoDominio("ZU", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_DEPOSITO_BANCARIO_INVALIDO = 1105,
	[Description("Valor aplicações financeiras inválido")]
	[AtributoDominio("ZV", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_APLICACOES_FINANCEIRAS_INVALIDO = 1106,
	[Description("Data/Valor preenchidos, obrigatório informar código de desconto")]
	[AtributoDominio("ZW", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DATA_VALOR_PREENCHIDOS_OBRIGATORIO_INFORMAR_CODIGO_DESCONTO = 1107,
	[Description("Valor cheques em cobrança inválido")]
	[AtributoDominio("ZX", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	VALOR_CHEQUE_EM_COBRANCA_INVALIDO = 1108,
	[Description("Desconto com valor fixo, obrigatório informar o valor do título")]
	[AtributoDominio("ZY", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	DESCONTO_COM_VALOR_FIXO_OBRIGATORIO_INFORMAR_VALOR_TITULO = 1109,
	[Description("Código de movimento inválido para segmento Y8")]
	[AtributoDominio("ZZ", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoMovimentoRetorno.ENTRADA_REJEITADA,
		EnumCodigoMovimentoRetorno.ENTRADA_CONFIRMADA,
		EnumCodigoMovimentoRetorno.INSTRUCAO_REJEITADA,
		EnumCodigoMovimentoRetorno.ALTERACAO_DE_DADOS_REJEITADA,
		EnumChaveContexto.BAN104_FEBRABAN240
	})]
	CODIGO_MOVIMENTO_INVALIDO_SEGMENTO_Y8 = 1110
}
