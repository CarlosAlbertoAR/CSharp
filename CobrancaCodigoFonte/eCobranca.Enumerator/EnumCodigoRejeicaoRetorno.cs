using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoRejeicaoRetorno
{
	[Description("Moeda inválida")]
	[AtributoDominio("001", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	MOEDA_INVALIDA = 0,
	[Description("Moeda inválida para a carteira")]
	[AtributoDominio("002", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	MOEDA_INVALIDA_PARA_CARTEIRA = 1,
	[Description("CEP não corresponde UF")]
	[AtributoDominio("007", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_NAO_CORRESPONDE_UF = 2,
	[Description("Valor juros ao dia maior que 5% do valor do título")]
	[AtributoDominio("008", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_JUROS_DIA_MAIOR_5_PERCENTUAL = 3,
	[Description("Uso exclusivo não numérico para cobrança express")]
	[AtributoDominio("009", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	USO_EXCLUSIVO_NAO_NUMERICO_COBRANCA_EXPRESS = 4,
	[Description("Impossibilidade de registro - contate seu gerente")]
	[AtributoDominio("010", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	IMPOSSIBILIDADE_DE_REGISTRO = 5,
	[Description("Nosso número fora da faixa")]
	[AtributoDominio("011", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NOSSO_NUMERO_FORA_FAIXA = 6,
	[Description("CEP de cidade inexistente")]
	[AtributoDominio("012", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_INEXISTENTE = 7,
	[Description("CEP fora da faixa da cidade")]
	[AtributoDominio("013", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_FORA_FAIXA_CIDADE = 8,
	[Description("UF inválida para CEP da cidade")]
	[AtributoDominio("014", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	UF_INVALIDA_CEP_CIDADE = 9,
	[Description("CEP zerado")]
	[AtributoDominio("015", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_ZERADO = 10,
	[Description("CEP não consta na tabela SAFRA")]
	[AtributoDominio("016", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_NAO_CONSTA_TABELA_SAFRA = 11,
	[Description("CEP náo consta na tabela do banco correspondente")]
	[AtributoDominio("017", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_NAO_CONSTA_TABELA_BANCO_CORRESPONDENTE = 12,
	[Description("Protesto impraticável")]
	[AtributoDominio("019", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PROTESTO_IMPRATICAVEL = 13,
	[Description("Primeira instrução de cobrança inválida")]
	[AtributoDominio("020", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PRIMEIRA_INSTRUCAO_INVALIDA = 14,
	[Description("Segunda instrução de cobrança inválida")]
	[AtributoDominio("021", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	SEGUNDA_INSTRUCAO_INVALIDA = 15,
	[Description("Terceira instrução de cobrança inválida")]
	[AtributoDominio("023", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TERCEIRA_INSTRUCAO_INVALIDA = 16,
	[Description("Código de operação/ocorrência inválido")]
	[AtributoDominio("026", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CODIGO_OPERACAO_OCORRENCIA_INVALIDO = 17,
	[Description("Operação inválida para o cliente")]
	[AtributoDominio("027", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	OPERACAO_INVALIDA_PARA_CLIENTE = 18,
	[Description("Nosso número não numérico ou zerado")]
	[AtributoDominio("028", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NOSSO_NUMERO_NAO_NUMERICO_OU_ZERADO = 19,
	[Description("Nosso número com dígito de controle errado/inconsistente")]
	[AtributoDominio("029", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NOSSO_NUMERO_COM_DIGITO_CONTROLE_ERRADO = 19,
	[Description("Valor do abatimento não numérico ou zerado")]
	[AtributoDominio("030", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_ABATIMENTO_NAO_NUMERICO = 20,
	[Description("Seu número em branco")]
	[AtributoDominio("031", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	SEU_NUMERO_EM_BRANCO = 21,
	[Description("Código da carteira inválido")]
	[AtributoDominio("032", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CODIGO_CARTEIRA_INVALIDO = 22,
	[Description("Data de emissão inválida")]
	[AtributoDominio("036", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DATA_EMISSAO_INVALIDA = 23,
	[Description("Data de vencimento inválida")]
	[AtributoDominio("037", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DATA_VENCIMENTO_INVALIDA = 24,
	[Description("Depositária inválida")]
	[AtributoDominio("038", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DEPOSITARIA_INVALIDA = 25,
	[Description("Depositária inválida para cliente")]
	[AtributoDominio("039", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DEPOSITARIA_INVALIDA_PARA_CLIENTE = 26,
	[Description("Depositária não cadastrada no banco")]
	[AtributoDominio("040", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DEPOSITARIA_NAO_CADASTRADA_NO_BANCO = 27,
	[Description("Código de aceite inválido")]
	[AtributoDominio("041", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CODIGO_ACEITE_INVALIDO = 28,
	[Description("Espécie de título inválida")]
	[AtributoDominio("042", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ESPECIE_TITULO_INVALIDA = 29,
	[Description("Instrução de cobrança inválida")]
	[AtributoDominio("043", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_COBRANCA_INVALIDA = 30,
	[Description("Valor do título não numérico ou zerado")]
	[AtributoDominio("044", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_TITULO_NAO_NUMERICO_OUO_ZERADO = 31,
	[Description("Valor de juros não numérico ou zerado")]
	[AtributoDominio("046", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_JUROS_NAO_NUMERICO_OUO_ZERADO = 32,
	[Description("Data limite para desconto inválida")]
	[AtributoDominio("047", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DATA_LIMITE_DESCONTO_INVALIDA = 33,
	[Description("Valor do desconto inválido")]
	[AtributoDominio("048", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_DESCONTO_INVALIDO = 34,
	[Description("Valor IOF não numérico ou inválido")]
	[AtributoDominio("049", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_IOF_NAO_NUMERICO_OU_INVALIDO = 35,
	[Description("Código de inscrição do sacado inválido")]
	[AtributoDominio("051", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CODIGO_INSCRICAO_SACADO_INVALIDO = 36,
	[Description("Número de inscrição do sacado não numérico ou dígito errado")]
	[AtributoDominio("053", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NUMERO_INSCRICAO_SACADO_NAO_NUMERICO_OU_DIGITO_ERRADO = 37,
	[Description("Nome do sacado em branco")]
	[AtributoDominio("054", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	NOME_DO_SACADO_EM_BRANCO = 38,
	[Description("Endere;o do sacado em branco")]
	[AtributoDominio("055", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ENDERECO_SACADO_EM_BRANCO = 39,
	[Description("Cliente não cadastrado")]
	[AtributoDominio("056", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CLIENTE_NAO_CADASTRADO = 40,
	[Description("Processo de cartório inválido")]
	[AtributoDominio("058", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PROCESSO_CARTORIO_INVALIDO = 41,
	[Description("Estado do sacado inválido")]
	[AtributoDominio("059", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ESTADO_SACADO_INVALIDO = 42,
	[Description("CEP ou endereço divergem do correio")]
	[AtributoDominio("060", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_ENDERECO_DIVERGEM_CORREIO = 43,
	[Description("Instrução agendada para a agência")]
	[AtributoDominio("061", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_AGENDADA_PARA_AGENCIA = 44,
	[Description("Opera;áo inválida para carteira")]
	[AtributoDominio("062", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	OPERACAO_INVALIDA_PARA_CARTEIRA = 45,
	[Description("Título inexistente")]
	[AtributoDominio("064", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_INEXISTENTE = 46,
	[Description("Operação ou título inexistente")]
	[AtributoDominio("065", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	OPERACAO_OU_TITULO_INEXISTENTE = 47,
	[Description("Título já existente")]
	[AtributoDominio("066", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_JA_EXISTENTE = 48,
	[Description("Data de vencimento inválida para protesto")]
	[AtributoDominio("067", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	DATA_VENCIMENTO_INVALIDA_PARA_PROTESTO = 49,
	[Description("Cep do sacado não consta na tabela")]
	[AtributoDominio("068", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	CEP_SACADO_NAO_CONSTA_TABELA = 50,
	[Description("Praça não atendida pelo serviço cartório")]
	[AtributoDominio("069", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PRACA_NAO_ATENDIDA_SERVICO_CARTORIO = 51,
	[Description("Agência inválida")]
	[AtributoDominio("070", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	AGENCIA_INVALIDA = 52,
	[Description("Título já existente (COB)")]
	[AtributoDominio("072", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_JA_EXISTENTE_COB = 53,
	[Description("Título fora da sequência")]
	[AtributoDominio("074", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_FORA_SEQUENCIA = 54,
	[Description("Título inexistente (COB)")]
	[AtributoDominio("078", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_INEXISTENTE_COB = 55,
	[Description("Operação não concluída")]
	[AtributoDominio("079", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	OPERACAO_NAO_CONCLUIDA = 56,
	[Description("Título já baixado")]
	[AtributoDominio("080", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_JA_BAIXADO = 57,
	[Description("Prorrogação/alteração de vencimento inválida")]
	[AtributoDominio("083", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PRORROGACAO_ALTERACAO_VENCIMENTO_INVALIDA = 58,
	[Description("Operação inválida para carteira")]
	[AtributoDominio("085", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	OPERACAO_INVALIDA_PARA_CARTEIRA2 = 59,
	[Description("Abatimento maior do que o valor do título")]
	[AtributoDominio("086", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ABATIMENTO_MAIOR_VALOR_TITULO = 60,
	[Description("Título recusado como garantia")]
	[AtributoDominio("088", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	TITULO_RECUSADO_COMO_GARANTIA = 61,
	[Description("Alteração de data de protesto inválida")]
	[AtributoDominio("089", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ALTERACAO_DATA_PROTESTO_INVALIDA = 62,
	[Description("Entrada título cobrança direta inválida")]
	[AtributoDominio("094", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	ENTRADA_TITULO_COBRANCA_DIRETA_INVALIDA = 63,
	[Description("Baixa título cobrança direta inválida")]
	[AtributoDominio("095", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	BAIXA_TITULO_COBRANCA_DIRETA_INVALIDA = 64,
	[Description("Valor do título inválido")]
	[AtributoDominio("096", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	VALOR_TITULO_INVALIDO = 65,
	[Description("PCB do TFC divergem do PCB do COB")]
	[AtributoDominio("098", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	PCB_DO_TFC_DIVERGEM_PCB_COB = 66,
	[Description("Instrução não permitida - Título com protesto")]
	[AtributoDominio("100", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_NAO_PERMITIDA_TIT_COM_PROTESTO = 67,
	[Description("Instrução incompatível - Não existe instrução negativar para título")]
	[AtributoDominio("101", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_INCOMPATIVEL_NAO_EXISTE_INSTRUCAO_NEGATIVAR = 68,
	[Description("Instrução não permitida - prazo inválido para negociação")]
	[AtributoDominio("102", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INTRUCAO_NAO_PERMITIDA_PRAZO_INVALIDO_NEGOCIACAO = 69,
	[Description("Instrução não permitida - título inexistente")]
	[AtributoDominio("103", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_CNAB400 })]
	INSTRUCAO_NAO_PERMITIDA_TITULO_INEXISTENTE = 70
}
