using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumParametrosAdicionaisConfiguracao
{
	[Description("GeraHeaderArquivoRemessaFebraban240")]
	[AtributoDominio("001", "", "Sinaliza se será ou não gerado o segmento header de arquivo (cabeçalho de arquivo) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_HEADER_ARQUIVO_REMESSA_FEBRABAN240 = 0,
	[Description("GeraHeaderLoteRemessaFebraban240")]
	[AtributoDominio("002", "", "Sinaliza se será ou não gerado o segmento header de lote (cabeçalho de lote) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_HEADER_LOTE_REMESSA_FEBRABAN240 = 1,
	[Description("GeraSegmentoDetalhePRemessaFebraban240")]
	[AtributoDominio("003", "", "Sinaliza se será ou não gerado o segmento de detalhe P (dados principais) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_SEGMENTO_DETALHE_P_REMESSA_FEBRABAN240 = 2,
	[Description("GeraSegmentoDetalheQRemessaFebraban240")]
	[AtributoDominio("004", "", "Sinaliza se será ou não gerado o segmento de detalhe Q (dados do sacado) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_SEGMENTO_DETALHE_Q_REMESSA_FEBRABAN240 = 3,
	[Description("GeraSegmentoDetalheRRemessaFebraban240")]
	[AtributoDominio("005", "", "Sinaliza se será ou não gerado o segmento de detalhe R (desconto e multa) remessa FEBRABAN240.", "A", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_SEGMENTO_DETALHE_R_REMESSA_FEBRABAN240 = 4,
	[Description("GeraTraillerLoteRemessaFebraban240")]
	[AtributoDominio("006", "", "Sinaliza se será ou não gerado o segmento trailler do lote (rodapé de lote) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_TRAILLER_LOTE_REMESSA_FEBRABAN240 = 5,
	[Description("GeraTraillerArquivoRemessaFebraban240")]
	[AtributoDominio("007", "", "Sinaliza se será ou não gerado o segmento trailler de arquivo (rodapé de arquivo) da remessa FEBRABAN240.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_TRAILLER_ARQUIVO_REMESSA_FEBRABAN240 = 6,
	[Description("GeraHeaderRemessaCnab400")]
	[AtributoDominio("008", "", "Sinaliza se será ou não gerado o segmento header do arquivo (cabeçalho de arquivo) de remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_HEADER_REMESSA_CNAB400 = 7,
	[Description("GeraTraillerRemessaCnab400")]
	[AtributoDominio("009", "", "Sinaliza se será ou não gerado o segmento trailler do arquivo (rodapé de arquivo) da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_GERA_TRAILLER_REMESSA_CNAB400 = 8,
	[Description("NomeArquivoRemessa")]
	[AtributoDominio("010", "", "Nome completo com extensão que o arquivo de remessa irá receber.", "AAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_NOME_ARQUIVO_REMESSA = 9,
	[Description("ModoHomologacao")]
	[AtributoDominio("011", "", "Modo de homologação?", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_MODO_HOMOLOGACAO = 10,
	[Description("CodificacaoArquivoRemessa")]
	[AtributoDominio("012", "", "Codificação do arquivo de remessa", "AAAA", "UTF8", new object[] { "UTF8", "ANSI" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_CODIFICACAO_ARQUIVO_REMESSA = 11,
	[Description("EnviaSegmentosAdicionaisOutrasInstrucoesRemessa")]
	[AtributoDominio("013", "", "Sinaliza se deverá ser enviado os segmentos opcionais (Q e R) para instruções diferentes de 01 - Entrada de Título", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumChaveContexto.GERAL
	})]
	REM_ENVIA_SEGMENTOS_ADICIONAIS_OUTRAS_INSTRUCOES_REMESSA = 81,
	[Description("GeraDetalheRemessaCnab400")]
	[AtributoDominio("011", "", "Sinaliza se será ou não gerado o segmento detalhe (dados principais) do arquivo de remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL,
		EnumCodigoBanco.HSBC_BANK_BRASIL,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_GERA_DETALHE_REMESSA_CNAB400 = 12,
	[Description("GeraMensagemRemessaCnab400")]
	[AtributoDominio("012", "", "Sinaliza se será ou não gerado o segmento mensagem (detalhe opcional para multa) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_DO_BRASIL
	})]
	REM_GERA_MENSAGEM_REMESSA_CNAB400 = 13,
	[Description("GeraRegistroTransacaoTipo1RemessaCnab400")]
	[AtributoDominio("013", "", "Sinaliza se será ou não gerado o Registro de transação tipo 1 (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_SANTANDER,
		EnumCodigoBanco.BANCO_SAFRA
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_1_REMESSA_CNAB400 = 14,
	[Description("GeraRegistroTransacaoTipo2RemessaCnab400")]
	[AtributoDominio("014", "", "Sinaliza se será ou não gerado o registro de transação tipo 2 (descontos adicionais e mensagem) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_SAFRA
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_2_REMESSA_CNAB400 = 15,
	[Description("GeraRegistroTransacaoTipo3RemessaCnab400")]
	[AtributoDominio("015", "", "Sinaliza se será ou não gerado o registro de transação tipo 3 (rateio de crédito) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_3_REMESSA_CNAB400 = 16,
	[Description("GeraRegistroTransacaoTipo7RemessaCnab400")]
	[AtributoDominio("016", "", "Sinaliza se será ou não gerado o registro de transação tipo 7 (dados sacador avalista) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_7_REMESSA_CNAB400 = 17,
	[Description("ClienteOptaDebitoAutomatico")]
	[AtributoDominio("017", "", "Sinaliza se o beneficiário trabalha com débito automático.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_BRADESCO
	})]
	REM_CLIENTE_OPTA_DEBITO_AUTOMATICO = 18,
	[Description("GeraRegistroDetalheRemessaCnab400")]
	[AtributoDominio("017", "", "Sinaliza se será ou não gerado o registro de detalhe (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL,
		EnumCodigoBanco.HSBC_BANK_BRASIL
	})]
	REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400 = 19,
	[Description("GeraRegistroDetalheOpcionalRemessaCnab400")]
	[AtributoDominio("018", "", "Sinaliza se será ou não gerado o registro de detalhe opcional (dados sacador avalista) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL
	})]
	REM_GERA_REGISTRO_DETALHE_OPCIONAL_REMESSA_CNAB400 = 20,
	[Description("GeraRegistroTipo1RemessaCnab400")]
	[AtributoDominio("089", "", "Sinaliza se será ou não gerado o registro tipo 1 (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.UNICRED
	})]
	REM_GERA_REGISTRO_TIPO1_REMESSA_CNAB400 = 89,
	[Description("GeraRegistroTipo5RemessaCnab400")]
	[AtributoDominio("090", "", "Sinaliza se será ou não gerado o registro tipo 5 (dados sacador avalista) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.UNICRED
	})]
	REM_GERA_REGISTRO_TIPO5_REMESSA_CNAB400 = 90,
	[Description("GeraRegistroMensagemFrenteRemessaCnab400")]
	[AtributoDominio("019", "", "Sinaliza se será ou não gerado o registro de mensagem de frente (envio de mensagens para impressão da frente do boleto) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU
	})]
	REM_GERA_REGISTRO_MENSAGEM_FRENTE_REMESSA_CNAB400 = 21,
	[Description("GeraRegistroMensagemVersoRemessaCnab400")]
	[AtributoDominio("020", "", "Sinaliza se será ou não gerado o registro de mensagem de verso (envio de mensagens para impressão do verso do boleto) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU
	})]
	REM_GERA_REGISTRO_MENSAGEM_VERSO_REMESSA_CNAB400 = 22,
	[Description("PrimeiraInstrucaoCobranca")]
	[AtributoDominio("030", "", "Define qual será a primeira instrução de cobrança no envio de remessa no padrão CNAB400 do banco 341 - ITAÚ ", "00", "AUSENCIA_DE_INSTRUCOES", new object[]
	{
		EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES,
		EnumInstrucaoCobranca.DEVOLVER_APOS_05_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_30_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.RECEBER_CONFORME_INSTRUCOES_NO_PROPRIO_TITULO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_10_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_15_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_20_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR2,
		EnumInstrucaoCobranca.NAO_PROTESTAR2,
		EnumInstrucaoCobranca.DEVOLVER_APOS_25_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_35_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_40_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_45_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_50_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_55_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_60_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_90_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_05_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_10_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_15_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_20_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_25_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_30_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_35_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_40_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_45_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_50_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_55_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_30_DIAS_CORRIDOS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.IMPORTANCIA_DE_DESCONTO_POR_DIA,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_60_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_90_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_ABATIMENTO_REF_PISPASEP_COFIN_CSSL_MESMO_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_APOS_XX_DIAS_CORRIDOS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_APOS_XX_DIAS_UTEIS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.RECEBER_ATE_O_ULTIMO_DIA_DO_MES_DE_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_MESMO_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_O_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_CONFORME_NOTA_DE_CREDITO,
		EnumInstrucaoCobranca.PROTESTO_PARA_FINS_FALIMENTARES,
		EnumInstrucaoCobranca.SUJEITO_A_PROTESTO_SE_NAO_FOR_PAGO_NO_VENCIMENTO,
		EnumInstrucaoCobranca.IMPORTANCIA_POR_DIA_DE_ATRASO_A_PARTIR_DE_DDMMAA,
		EnumInstrucaoCobranca.TEM_DIA_DA_GRACA,
		EnumInstrucaoCobranca.DISPENSAR_JUROS_COMISSAO_DE_PERMANENCIA,
		EnumInstrucaoCobranca.RECEBER_SOMENTE_COM_A_PARCELA_ANTERIOR_QUITADA,
		EnumInstrucaoCobranca.EFETUAR_O_PAGAMENTO_SOMENTE_ATRAVES_DESTE_BOLETO_E_NA_REDE_BANCARIA,
		EnumInstrucaoCobranca.APOS_VENCIMENTO_PAGAVEL_SOMENTE_NA_EMPRESA,
		EnumInstrucaoCobranca.SOMAR_VALOR_DO_TITULO_AO_VALOR_DO_CAMPO_MORA_MULTA_CASO_EXISTA,
		EnumInstrucaoCobranca.DEVOLVER_APOS_365_DIAS_DE_VENCIDO,
		EnumInstrucaoCobranca.COBRANCA_NEGOCIADA_PAGAVEL_SOMENTE_POR_ESTE_BOLETO_NA_REDE_BANCARIA,
		EnumInstrucaoCobranca.TITULO_ENTREGUE_EM_PENHOR_EM_FAVOR_DO_CEDENTE_ACIMA,
		EnumInstrucaoCobranca.TITULO_TRANSFERIDO_A_FAVOR_DO_CEDENTE,
		EnumInstrucaoCobranca.VALOR_DA_IDA_ENGLOBA_MULTA_DE_10_PORCENTO_PRO_RATA,
		EnumInstrucaoCobranca.COBRAR_JUROS_APOS_15_DIAS_DA_EMISSAO,
		EnumInstrucaoCobranca.PAGAMENTO_EM_CHEQUE_SOMENTE_RECEBER_COM_CHEQUE_DE_EMISSAO_DO_SACADO,
		EnumInstrucaoCobranca.OPERACAO_REF_A_VENDOR,
		EnumInstrucaoCobranca.APOS_VENCIMENTO_CONSULTAR_A_AGENCIA_CEDENTE,
		EnumInstrucaoCobranca.ANTES_DO_VENCIMENTO_OU_APOS_15_DIAS_PAGAVEL_SOMENTE_EM_NOSSA_SEDE,
		EnumInstrucaoCobranca.NAO_RECEBER_ANTES_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NO_VENCIMENTO_PAGAVEL_EM_QUALQUER_AGENCIA_BANCARIA,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_XX_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_XX_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.MENSAGENS_NOS_BOLETOS_COM_30_POSICOES,
		EnumInstrucaoCobranca.MENSAGENS_NOS_BOLETOS_COM_40_POSIC0ES,
		EnumInstrucaoCobranca.DUPLICATA_FATURA
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU
	})]
	REM_PRIMEIRA_INSTRUCAO_COBRANCA = 76,
	[Description("SegundaInstrucaoCobranca")]
	[AtributoDominio("031", "", "Define qual será a segunda instrução de cobrança no envio de remessa no padrão CNAB400 do banco 341 - ITAÚ ", "00", "AUSENCIA_DE_INSTRUCOES", new object[]
	{
		EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES,
		EnumInstrucaoCobranca.DEVOLVER_APOS_05_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_30_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.RECEBER_CONFORME_INSTRUCOES_NO_PROPRIO_TITULO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_10_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_15_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_20_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR2,
		EnumInstrucaoCobranca.NAO_PROTESTAR2,
		EnumInstrucaoCobranca.DEVOLVER_APOS_25_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_35_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_40_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_45_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_50_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_55_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_60_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_90_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_05_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_10_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_15_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_20_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_25_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_30_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_35_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_40_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_45_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_50_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_55_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_30_DIAS_CORRIDOS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.IMPORTANCIA_DE_DESCONTO_POR_DIA,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_60_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_90_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_ABATIMENTO_REF_PISPASEP_COFIN_CSSL_MESMO_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_APOS_XX_DIAS_CORRIDOS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_APOS_XX_DIAS_UTEIS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.RECEBER_ATE_O_ULTIMO_DIA_DO_MES_DE_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_MESMO_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_O_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_CONFORME_NOTA_DE_CREDITO,
		EnumInstrucaoCobranca.PROTESTO_PARA_FINS_FALIMENTARES,
		EnumInstrucaoCobranca.SUJEITO_A_PROTESTO_SE_NAO_FOR_PAGO_NO_VENCIMENTO,
		EnumInstrucaoCobranca.IMPORTANCIA_POR_DIA_DE_ATRASO_A_PARTIR_DE_DDMMAA,
		EnumInstrucaoCobranca.TEM_DIA_DA_GRACA,
		EnumInstrucaoCobranca.DISPENSAR_JUROS_COMISSAO_DE_PERMANENCIA,
		EnumInstrucaoCobranca.RECEBER_SOMENTE_COM_A_PARCELA_ANTERIOR_QUITADA,
		EnumInstrucaoCobranca.EFETUAR_O_PAGAMENTO_SOMENTE_ATRAVES_DESTE_BOLETO_E_NA_REDE_BANCARIA,
		EnumInstrucaoCobranca.APOS_VENCIMENTO_PAGAVEL_SOMENTE_NA_EMPRESA,
		EnumInstrucaoCobranca.SOMAR_VALOR_DO_TITULO_AO_VALOR_DO_CAMPO_MORA_MULTA_CASO_EXISTA,
		EnumInstrucaoCobranca.DEVOLVER_APOS_365_DIAS_DE_VENCIDO,
		EnumInstrucaoCobranca.COBRANCA_NEGOCIADA_PAGAVEL_SOMENTE_POR_ESTE_BOLETO_NA_REDE_BANCARIA,
		EnumInstrucaoCobranca.TITULO_ENTREGUE_EM_PENHOR_EM_FAVOR_DO_CEDENTE_ACIMA,
		EnumInstrucaoCobranca.TITULO_TRANSFERIDO_A_FAVOR_DO_CEDENTE,
		EnumInstrucaoCobranca.VALOR_DA_IDA_ENGLOBA_MULTA_DE_10_PORCENTO_PRO_RATA,
		EnumInstrucaoCobranca.COBRAR_JUROS_APOS_15_DIAS_DA_EMISSAO,
		EnumInstrucaoCobranca.PAGAMENTO_EM_CHEQUE_SOMENTE_RECEBER_COM_CHEQUE_DE_EMISSAO_DO_SACADO,
		EnumInstrucaoCobranca.OPERACAO_REF_A_VENDOR,
		EnumInstrucaoCobranca.APOS_VENCIMENTO_CONSULTAR_A_AGENCIA_CEDENTE,
		EnumInstrucaoCobranca.ANTES_DO_VENCIMENTO_OU_APOS_15_DIAS_PAGAVEL_SOMENTE_EM_NOSSA_SEDE,
		EnumInstrucaoCobranca.NAO_RECEBER_ANTES_DO_VENCIMENTO,
		EnumInstrucaoCobranca.NO_VENCIMENTO_PAGAVEL_EM_QUALQUER_AGENCIA_BANCARIA,
		EnumInstrucaoCobranca.NAO_RECEBER_APOS_XX_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_XX_DIAS_DO_VENCIMENTO,
		EnumInstrucaoCobranca.MENSAGENS_NOS_BOLETOS_COM_30_POSICOES,
		EnumInstrucaoCobranca.MENSAGENS_NOS_BOLETOS_COM_40_POSIC0ES,
		EnumInstrucaoCobranca.DUPLICATA_FATURA
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU
	})]
	REM_SEGUNDA_INSTRUCAO_COBRANCA = 77,
	[Description("GeraRegistroDetalheOpcionalMultaRemessaCnab400")]
	[AtributoDominio("032", "", "Sinaliza se será ou não gerado o registro de detalhe opcional (dados de multa) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_ITAU
	})]
	REM_GERA_REGISTRO_DETALHE_OPCIONAL_MULTA_REMESSA_CNAB400 = 80,
	[Description("GeraRegistroTipo1RemessaCnab400")]
	[AtributoDominio("021", "", "Sinaliza se será ou não gerado o Registro do tipo 1 (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	REM_GERA_REGISTRO_TIPO_1_REMESSA_CNAB400 = 23,
	[Description("GeraRegistroTipo2RemessaCnab400")]
	[AtributoDominio("022", "", "Sinaliza se será ou não gerado o registro do tipo 2 (descontos adicionais e mensagem) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	REM_GERA_REGISTRO_TIPO_2_REMESSA_CNAB400 = 24,
	[Description("GeraRegistroTipo6RemessaCnab400")]
	[AtributoDominio("023", "", "Sinaliza se será ou não gerado o registro do tipo 3 (rateio de crédito) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	REM_GERA_REGISTRO_TIPO_6_REMESSA_CNAB400 = 25,
	[Description("GeraRegistroTipo7RemessaCnab400")]
	[AtributoDominio("024", "", "Sinaliza se será ou não gerado o registro do tipo 7 (dados sacador avalista) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	REM_GERA_REGISTRO_TIPO_7_REMESSA_CNAB400 = 26,
	[Description("GeraRegistroTransacaoTipo1DetalheTituloRemessaCnab400")]
	[AtributoDominio("025", "", "Sinaliza se será ou não gerado o Registro de transação tipo 1 (dados principais do titulo) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_1_DETALHE_TITULO_REMESSA_CNAB400 = 27,
	[Description("GeraRegistroTransacaoTipo2MensagemRemessaCnab400")]
	[AtributoDominio("026", "", "Sinaliza se será ou não gerado o Registro de transação tipo 2 (mensagem) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_2_MENSAGEM_TITULO_REMESSA_CNAB400 = 28,
	[Description("GeraRegistroTransacaoTipo1RemessaCnab400")]
	[AtributoDominio("098", "", "Sinaliza se será ou não gerado o Registro de transação tipo 1 (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.UNIPRIME_NORTE_PARANA
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_1_REMESSA_CNAB400_BAN084 = 98,
	[Description("GeraRegistroTransacaoTipo2RemessaCnab400")]
	[AtributoDominio("099", "", "Sinaliza se será ou não gerado o registro de transação tipo 2 (descontos adicionais e mensagem) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.UNIPRIME_NORTE_PARANA
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_2_REMESSA_CNAB400_BAN084 = 99,
	[Description("TipoCarenciaJuros")]
	[AtributoDominio("028", "", "Define se a cobrança de juros será por dias 1-úteis ou 2-corridos", "0", "DIAS_UTEIS", new object[]
	{
		EnumTipoCarencia.DIAS_UTEIS,
		EnumTipoCarencia.DIAS_CORRIDOS
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_TIPO_CARENCIA_JUROS_CNAB400 = 29,
	[Description("TipoCarenciaMulta")]
	[AtributoDominio("028", "", "Define se a cobrança multa será por dias 1-úteis ou 2-corridos", "0", "DIAS_UTEIS", new object[]
	{
		EnumTipoCarencia.DIAS_UTEIS,
		EnumTipoCarencia.DIAS_CORRIDOS
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_TIPO_CARENCIA_MULTA_CNAB400 = 30,
	[Description("CarenciaCobrancaJuros")]
	[AtributoDominio("029", "", "Define a quantidade de dias de carência para a cobrança da taxa de juros", "00", "00", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_CARENCIA_COBRANCA_JUROS = 31,
	[Description("CarenciaCobrancaMulta")]
	[AtributoDominio("030", "", "Define a quantidade de dias de carência para a cobrança da taxa de multa", "00", "00", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_CARENCIA_COBRANCA_MULTA = 32,
	[Description("GeraDetalheOpcionalRemessaCnab400")]
	[AtributoDominio("031", "", "Define se será gerado o segmento de detalhe opcional na remessa do layout Cnab400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_GERA_DETALHE_OPCIONAL_REMESSA_CNAB400 = 78,
	[Description("TipoEnvioProtesto")]
	[AtributoDominio("032", "", "O cooperado poderá escolher entre o envio para o Cartório para realização do Protesto do título ou para o Serasa para a negativação do título.", "00", "NENHUM", new object[]
	{
		EnumTipoEnvioProtesto.CARTORIO,
		EnumTipoEnvioProtesto.SERASA,
		EnumTipoEnvioProtesto.NENHUM
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO
	})]
	REM_TIPO_ENVIO_PROTESTO_REMESSA_CNAB400 = 79,
	[Description("GeraRegistroTransacaoTipo1RemessaCnab400")]
	[AtributoDominio("029", "", "Sinaliza se será ou não gerado o Registro de transação tipo 1 (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_1_REMESSA_CNAB400_BAN099 = 33,
	[Description("GeraRegistroTransacaoTipo2RemessaCnab400")]
	[AtributoDominio("030", "", "Sinaliza se será ou não gerado o registro de transação tipo 2 (descontos adicionais e mensagem) do arquivo da remessa CNAB400.", "A", "N", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED
	})]
	REM_GERA_REGISTRO_TRANSACAO_TIPO_2_REMESSA_CNAB400_BAN099 = 34,
	[Description("UtilizaCodigoDeCobrancaNova")]
	[AtributoDominio("027", "", "Sinaliza se o beneficiário utiliza conta de cobrança nova com mais de 8 dígitos", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_SANTANDER
	})]
	REM_UTILIZA_CODIGO_DE_COBRANCA_NOVA = 35,
	[Description("PrimeiraInstrucaoCodificada")]
	[AtributoDominio("028", "", "Define qual será a primeira instrução no envio de remessa no padrão CNAB400 do banco 756 - SICOOB ", "00", "AUSENCIA_DE_INSTRUCOES", new object[]
	{
		EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES,
		EnumInstrucaoCobranca.COBRAR_JUROS,
		EnumInstrucaoCobranca.PROTESTAR_3_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_4_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_5_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_PROTESTAR,
		EnumInstrucaoCobranca.PROTESTAR_10_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_15_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_20_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_SO_ATE_DATA_ESTIPULADA,
		EnumInstrucaoCobranca.DEVOLVER_APOS_15_DIAS_VENCIDO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_30_DIAS_VENCIDO
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	REM_PRIMEIRA_INSTRUCAO_CODIFICADA = 74,
	[Description("SegundaInstrucaoCodificada")]
	[AtributoDominio("029", "", "Define qual será a segunda instrução no envio de remessa no padrão CNAB400 do banco 756 - SICOOB ", "00", "AUSENCIA_DE_INSTRUCOES", new object[]
	{
		EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES,
		EnumInstrucaoCobranca.COBRAR_JUROS,
		EnumInstrucaoCobranca.PROTESTAR_3_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_4_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_5_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.NAO_PROTESTAR,
		EnumInstrucaoCobranca.PROTESTAR_10_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_15_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.PROTESTAR_20_DIAS_UTEIS_APOS_VENCIMENTO,
		EnumInstrucaoCobranca.CONCEDER_DESCONTO_SO_ATE_DATA_ESTIPULADA,
		EnumInstrucaoCobranca.DEVOLVER_APOS_15_DIAS_VENCIDO,
		EnumInstrucaoCobranca.DEVOLVER_APOS_30_DIAS_VENCIDO
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL
	})]
	REM_SEGUNDA_INSTRUCAO_CODIFICADA = 75,
	[Description("GeraRegistroTransacaoRemessaCnab400")]
	[AtributoDominio("086", "", "Sinaliza se será ou não gerado o Registro de transação (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO
	})]
	REM_GERA_REGISTRO_TRANSACAO_REMESSA_CNAB400 = 86,
	[Description("GeraRegistroTransacaoTipo1RemessaCnab400")]
	[AtributoDominio("029", "", "Sinaliza se será ou não gerado o Registro DE DETALHE (dados principais) do arquivo da remessa CNAB400.", "A", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_REMESSA,
		EnumCodigoBanco.CRESOL
	})]
	REM_GERA_REGISTRO_DETALHE_REMESSA_CNAB400_BAN133 = 96,
	[Description("MargemEsquerda")]
	[AtributoDominio("001", "", "Define a margem esquerda personalizada do boleto em milímetros (mm).", "00", "12", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MARGEM_ESQUERDA = 36,
	[Description("MargemDireita")]
	[AtributoDominio("002", "", "Define a margem direita personalizada do boleto em milímetros (mm).", "00", "12", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MARGEM_DIREITA = 37,
	[Description("MargemSuperior")]
	[AtributoDominio("003", "", "Define a margem superior personalizada do boleto em milímetros (mm).", "00", "3", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MARGEM_SUPERIOR = 38,
	[Description("MargemInferior")]
	[AtributoDominio("004", "", "Define a margem inferior personalizada do boleto em milímetros (mm).", "00", "3", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MARGEM_INFERIOR = 39,
	[Description("LarguraCodigoBarras")]
	[AtributoDominio("005", "", "Define a largura do código de barras impresso no boleto em milímetros (mm).", "000", "103", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_LARGURA_CODIGO_BARRAS = 40,
	[Description("AlturaCodigoBarras")]
	[AtributoDominio("006", "", "Define a altura do código de barras impresso no boleto em milímetros (mm).", "00", "13", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_ALTURA_CODIGO_BARRAS = 41,
	[Description("PagamentoAutorizadoSomenteNoBancoCedente")]
	[AtributoDominio("007", "", "Define se o pagamento do boleto será autorizado apenas nas agências do banco cedente emissor do boleto.", "A", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE = 42,
	[Description("GeraMensagemAutomaticaJuros")]
	[AtributoDominio("008", "", "Define se será gerada mensagem automática de juros no campo instruções do boleto.", "A", "S", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_GERA_MENSAGEM_AUTOMATICA_JUROS = 43,
	[Description("GeraMensagemAutomaticaMulta")]
	[AtributoDominio("009", "", "Define se será gerada mensagem automática de multa no campo instruções do boleto.", "A", "S", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_GERA_MENSAGEM_AUTOMATICA_MULTA = 44,
	[Description("GeraMensagemAutomaticaDesconto")]
	[AtributoDominio("010", "", "Define se será gerada mensagem automática de desconto no campo instruções do boleto.", "A", "S", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_GERA_MENSAGEM_AUTOMATICA_DESCONTO = 45,
	[Description("GeraMensagemAutomaticaProtesto")]
	[AtributoDominio("011", "", "Define se será gerada mensagem automática de protesto no campo instruções do boleto.", "A", "S", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_GERA_MENSAGEM_AUTOMATICA_PROTESTO = 46,
	[Description("QuebrarLinhasMensagensAutomaticas")]
	[AtributoDominio("012", "", "Define se será gerada quebra de linha nas mensagens automáticas no campo instruções do boleto.", "A", "S", new object[] { "N", "S" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_QUEBRAR_LINHAS_MENSAGENS_AUTOMATICAS = 47,
	[Description("ExibirRazaoSocialBeneficiario")]
	[AtributoDominio("015", "", "Define se será impresso no boleto a razão social do beneficiário", "A", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_EXIBIR_RAZAO_SOCIAL_BENEFICIARIO = 50,
	[Description("FonteCampoInstrucoes")]
	[AtributoDominio("016", "", "Define qual a fonte será utilizada no campo instruções do boleto", "", "ARIAL_NARROW", new object[] { "ARIAL_NARROW", "COURIER_NEW" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_FONTE_CAMPO_INSTRUCOES = 82,
	[Description("ModeloBoletoSecundario")]
	[AtributoDominio("017", "", "Define qual o modelo de layout secundário será utilizado para a geração de boletos", "", "", new object[] { "BOLETO_PADRAO_SACADO_PAGINA_INTEIRA", "BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA", "BOLETO_TOPO_SACADO_MEIA_PAGINA", "BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA", "BOLETO_CARNET_SACADO", "BOLETO_CARNET_SACADO_ENTREGA", "BOLETO_CARNET_SACADO_ENTREGA_ZEBRA", "BOLETO_CARNET_SACADO_ENTREGA_FITA" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MODELO_BOLETO_SECUNDARIO = 83,
	[Description("AplicarQuebraPaginaGeracaoBoletos")]
	[AtributoDominio("018", "", "Define que a geração do pdf enviado para a impressora respeitará a configuração do número de boletos por página aplicada.", "", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_APLICAR_QUEBRA_PAGINA_GERACAO_BOLETOS = 85,
	[Description("ExibeMensagemHibridaDeJurosMultaDesconto")]
	[AtributoDominio("087", "", "Define se as mensagens de juros, multa e desconto serão exibidas com percentual e valor.", "", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_EXIBE_MENSAGEM_HIBRIDA_JUROS_MULTA_DESCONTO = 87,
	[Description("ExibeConteudoCampoInstrucoesEmCaixaAlta")]
	[AtributoDominio("088", "", "Define se o conteúdo do campos intruções do boleto será exibido em caixa alta.", "", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_EM_CAIXA_ALTA = 88,
	[Description("MensagemAoPagador")]
	[AtributoDominio("91", "", "Define alguma mensagem específica que será impressa no campo informações extras no recibo do pagador", "", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_MENSAGEM_AO_PAGADOR = 91,
	[Description("ExibeConteudoCampoInstrucoesNasInformacoesExtrasDoPagador")]
	[AtributoDominio("92", "", "Define se o conteúdo do campo de instruções da ficha de compensação será replicada para o campo de informações extras do recibo do pagador.", "", "N", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_EXIBE_CONTEUDO_CAMPO_INSTRUCOES_NAS_INFORMACOES_EXTRAS_PAGADOR = 92,
	[Description("SenhaBloqueioBoletoPDF")]
	[AtributoDominio("93", "", "Define a senha que será utilizada para impedir o acesso indevido aos boletos gerados no formato de PDF.", "", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_SENHA_BLOQUEIO_BOLETOS = 93,
	[Description("EnveloparImagemBoletoEmArquivoPDF")]
	[AtributoDominio("94", "", "Define se os boletos gerados no formato PDF possuirão internamente uma imagem ao invés de texto.", "", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_ENVELOPAR_IMAGEM_DE_BOLETO_EM_ARQUIVO_PDF = 94,
	[Description("GerarBoletoPdfComprimido")]
	[AtributoDominio("95", "", "Define se os boletos gerados como pdf puros serão comprimidos para ocupar menos espaço (ativado por padrão).", "", "S", new object[] { "S", "N" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	BOL_COMPRIMIR_PDF = 95,
	[Description("TempoEsperaEnvioDocumentoParaImpressao")]
	[AtributoDominio("001", "", "Define o tempo em segundos que o eCobrança aguardará quando o boleto for enviado para a impressoa.", "00", "05", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO,
		EnumChaveContexto.GERAL
	})]
	IMP_TEMPO_ESPERA_IMPRESSAO = 51,
	[Description("AlturaPaginaImpressao")]
	[AtributoDominio("002", "", "Define a altura da página para impressão.", "000", "297", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO,
		EnumChaveContexto.GERAL
	})]
	IMP_ALTURA_PAGINA_IMPRESSAO = 52,
	[Description("LarguraPaginaImpressao")]
	[AtributoDominio("003", "", "Define a largura da página para impressão.", "000", "210", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO,
		EnumChaveContexto.GERAL
	})]
	IMP_LARGURA_PAGINA_IMPRESSAO = 53,
	[Description("TipoOrientacaoPagina")]
	[AtributoDominio("004", "", "Define o tipo de oritentação da página para impressão.", "TTTTTTTT", "RETRATO", new object[] { "PAISAGEM", "RETRATO" })]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO,
		EnumChaveContexto.GERAL
	})]
	IMP_TIPO_ORIENTACAO_PAGINA = 54,
	[Description("ImpressoraPersonalizada")]
	[AtributoDominio("005", "", "Define o nome da impressora que será utilizada.", "", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_IMPRESSAO,
		EnumChaveContexto.GERAL
	})]
	IMP_IMPRESSORA_PERSONALIZADA = 84,
	[Description("CodigoDesconto2")]
	[AtributoDominio("001", "", "Define o código do segundo desconto configurado para o título de cobrança.", "00", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_CODIGO_DESCONTO2 = 55,
	[Description("DataDesconto2")]
	[AtributoDominio("002", "", "Define a data limite para consessão do segundo desconto configurado para o título de cobrança.", "000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_DATA_DESCONTO2 = 56,
	[Description("ValorDesconto2")]
	[AtributoDominio("003", "", "Define o valor do segundo desconto configurado para o título de cobrança.", "0000000000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_VALOR_DESCONTO2 = 57,
	[Description("CodigoDesconto3")]
	[AtributoDominio("004", "", "Define o código do terceiro desconto configurado para o título de cobrança.", "000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_CODIGO_DESCONTO3 = 58,
	[Description("DataDesconto3")]
	[AtributoDominio("005", "", "Define a data limite para concessão do terceiro desconto configurado para o título de cobrança.", "0000000000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_DATA_DESCONTO3 = 59,
	[Description("ValorDesconto3")]
	[AtributoDominio("006", "", "Define o valor do terceiro desconto configurado para o título de cobrança.", "000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_VALOR_DESCONTO3 = 60,
	[Description("EnderecoSacadorAvalista")]
	[AtributoDominio("007", "", "Define o endereço completo (logradouro e complemento) do sacador/avalista do título de cobrança.", "0000000000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_ENDERECO_SACADOR_AVALISTA = 61,
	[Description("BairroSacadorAvalista")]
	[AtributoDominio("008", "", "Define o nome do bairro do sacador/avalista do título de cobrança.", "AAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_BAIRRO_SACADOR_AVALISTA = 62,
	[Description("CepSacadorAvalista")]
	[AtributoDominio("009", "", "Define o cep (código de endereçamento postal) do sacador/avalista do título de cobrança.", "00000000", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_CEP_SACADOR_AVALISTA = 63,
	[Description("CidadeSacadorAvalista")]
	[AtributoDominio("010", "", "Define o nome da cidade do sacador/avalista do título de cobrança.", "AAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_CIDADE_SACADOR_AVALISTA = 64,
	[Description("UfSacadorAvalista")]
	[AtributoDominio("011", "", "Define a UF (unidade federativa) do sacador/avalista do título de cobrança.", "AA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_UF_SACADOR_AVALISTA = 65,
	[Description("Mensagem1")]
	[AtributoDominio("012", "", "Define a primeira mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM1_BOLETO = 66,
	[Description("Mensagem2")]
	[AtributoDominio("013", "", "Define a segunda mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM2_BOLETO = 67,
	[Description("Mensagem3")]
	[AtributoDominio("014", "", "Define a terceira mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM3_BOLETO = 68,
	[Description("Mensagem4")]
	[AtributoDominio("015", "", "Define a quarta mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM4_BOLETO = 69,
	[Description("Mensagem5")]
	[AtributoDominio("016", "", "Define a quinta mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM5_BOLETO = 70,
	[Description("Mensagem6")]
	[AtributoDominio("017", "", "Define a sexta mensagem a ser impressa no boleto quando emitido pelo banco.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumChaveContexto.GERAL
	})]
	DOC_MENSAGEM6_BOLETO = 71,
	[Description("Campo alterado")]
	[AtributoDominio("018", "", "Define qual o campo que foi alterado do documento de cobrança para reenvio de remessa.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "DESCONTO", new object[]
	{
		EnumCampoAlteradoDocumentoCobranca.DESCONTO,
		EnumCampoAlteradoDocumentoCobranca.JUROS_POR_DIA,
		EnumCampoAlteradoDocumentoCobranca.DESCONTO_POR_DIA_ANTECIPACAO,
		EnumCampoAlteradoDocumentoCobranca.DATA_LIMITE_CONCESSAO_DESCONTO,
		EnumCampoAlteradoDocumentoCobranca.CANCELAMENTO_PROTESTO_AUTOMATICO,
		EnumCampoAlteradoDocumentoCobranca.CARTEIRA_DE_COBRANCA
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	DOC_CAMPO_ALTERADO = 72,
	[Description("CodigoInstrucao")]
	[AtributoDominio("019", "", "Define qual será o código de instrução enviado ao banco", "00", "SEM_INSTRUCOES", new object[]
	{
		EnumCodigoInstrucao.SEM_INSTRUCOES,
		EnumCodigoInstrucao.ACATAR_INSTRUCOES,
		EnumCodigoInstrucao.NAO_COBRAR_ENCARGOS_MONETARIOS,
		EnumCodigoInstrucao.NAO_RECEBER_APOS_VENCIMENTO,
		EnumCodigoInstrucao.APOS_VENCIMENTO_COBRAR_COMISSAO_PERMANENCIA
	})]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.DOCUMENTO_COBRANCA,
		EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL
	})]
	DOC_CODIGO_INSTRUCAO = 73
}
