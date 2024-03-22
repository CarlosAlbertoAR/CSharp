using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoServico
{
	[Description("Cobrança")]
	[AtributoDominio("01", "COBRANCA", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400,
		EnumChaveContexto.BAN748_FEBRABAN240,
		EnumChaveContexto.BAN004_CNAB400
	})]
	COBRANCA,
	[Description("Envio de boleto por email")]
	[AtributoDominio("02", "ENVIOBOLETOPOREMAIL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ENVIO_BOLETO_POR_EMAIL,
	[Description("Cobrança sem registro/serviços")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	COBRANCA_SEM_REGISTRO,
	[Description("Envio de número cedente")]
	[AtributoDominio("03", "ENVIONUMEROCEDENTE", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	ENVIO_NUMERO_CEDENTE,
	[Description("Bloqueto eletrônico")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	BLOQUETO_ELETRONICO,
	[Description("Desconto de títulos")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	DESCONTO_TITULOS,
	[Description("Conciliação bancária")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CONCILIACAO_BANCARIA,
	[Description("Caução de títulos")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	CAUCAO_TITULOS,
	[Description("Débitos")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	DEBITOS,
	[Description("Custódia de cheques")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CUSTODIA_DE_CHEQUES,
	[Description("Gestão de caixa")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	GESTAO_DE_CAIXA,
	[Description("Consulta/Informação margem")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CONSULTA_INFORMACAO_MARGEM,
	[Description("Averbação da consignação/retenção")]
	[AtributoDominio("09", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	AVERBACAO_DA_CONSIGNACAO_RETENCAO,
	[Description("Pagamento dividendos")]
	[AtributoDominio("10", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_DIVIDENDOS,
	[Description("manutenção da consignação")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	MANUTENCAO_DA_CONSIGNACAO,
	[Description("Consignação de parcelas")]
	[AtributoDominio("12", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CONSIGNACAO_DE_PARCELAS,
	[Description("Glosa da consignação")]
	[AtributoDominio("13", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	GLOSA_DA_CONSIGNACAO,
	[Description("Consulta de tributos a pagar")]
	[AtributoDominio("14", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	CONSULTA_DE_TRIBUTOS_A_PAGAR,
	[Description("Pagamento fornecedor")]
	[AtributoDominio("20", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_FORNECEDOR,
	[Description("Pagamentos de contas, tributos e impostos")]
	[AtributoDominio("22", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTOS_DE_CONTAS_TRIBUTOS_IMPOSTOS,
	[Description("Compror")]
	[AtributoDominio("25", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	COMPROR,
	[Description("Compror rotativo")]
	[AtributoDominio("26", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	COMPROR_ROTATIVO,
	[Description("Alegação do sacado")]
	[AtributoDominio("29", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	ALEGACAO_DO_SACADO,
	[Description("Pagamento salários")]
	[AtributoDominio("30", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_SALARIOS,
	[Description("Pagamento honorários")]
	[AtributoDominio("32", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_HONORARIOS,
	[Description("Pagamento bolsa auxílio")]
	[AtributoDominio("33", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_BOLSA_AUXILIO,
	[Description("Pagamento prebenda (remuneração a padres e sacerdotes)")]
	[AtributoDominio("34", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_PREBENDA,
	[Description("Vendor")]
	[AtributoDominio("40", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	VENDOR,
	[Description("Vendor a termo")]
	[AtributoDominio("41", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	VENDOR_A_TERMO,
	[Description("Pagamento sinistros segurados")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_SINISTROS_SEGURADOS,
	[Description("Pagamento despesas viajante em trânsito")]
	[AtributoDominio("60", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_DESPESAS_VIAJANTE_EM_TRANSITO,
	[Description("Pagamento autorizado")]
	[AtributoDominio("70", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_AUTORIZADO,
	[Description("Pagamento credenciados")]
	[AtributoDominio("75", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_CREDENCIADOS,
	[Description("Pagamento remuneração")]
	[AtributoDominio("77", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_REMUNERACAO,
	[Description("Pagamento representantes vendores autorizados")]
	[AtributoDominio("80", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_REPRESENTANTES_VENDORES_AUTORIZADOS,
	[Description("Pagamento benefícios")]
	[AtributoDominio("90", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_BENEFICIOS,
	[Description("Pagamentos diversos")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PAGAMENTO_DIVERSOS,
	[Description("Cobrança de multa")]
	[AtributoDominio("99", "COBRANCAMULTA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN001_CBR641 })]
	COBRANCA_DE_MULTA
}
