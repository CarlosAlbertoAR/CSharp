using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumIdentificacaoRegistroOpcionalYFebraban
{
	[Description("Informação de dados do sacador avalista")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACAO_DE_DADOS_DO_SACADOR_AVALISTA,
	[Description("Alegação ao sacado")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	ALEGACAO_DO_SACADO,
	[Description("Informação de dados do sacado")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACAO_DE_DADOS_DO_SACADO,
	[Description("Informação de dados de cheques utilizados")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACAO_DE_DADOS_DE_CHEQUES_UTILIZADOS,
	[Description("Informações sobre dados de parcelas de compror")]
	[AtributoDominio("11", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACOES_SOBRE_DADOS_DE_PARCELAS_DE_COMPROR,
	[Description("Informação de dados de rateio de crédito")]
	[AtributoDominio("50", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACAO_DE_DADOS_DE_RATEIO_DE_CREDITO,
	[Description("Informações de notas fiscais")]
	[AtributoDominio("51", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACOES_DE_NOTAS_FISCAIS,
	[Description("Identificação dos entes envolvidos no processo de pagamento")]
	[AtributoDominio("52", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	IDENTIFICACAO_DOS_ENTES_ENVOLVIDOS_NO_PROCESSO_DE_PAGAMENTO
}
