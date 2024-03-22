using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoOperacao
{
	[Description("Remessa")]
	[AtributoDominio("1", "REMESSA", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN004_CNAB400
	})]
	REMESSA,
	[Description("Retorno")]
	[AtributoDominio("2", "RETORNO", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN097_CNAB400
	})]
	RETORNO,
	[Description("Remessa processada")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	REMESSA_PROCESSADA,
	[Description("Remessa processada parcial")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	REMESSA_PROCESSADA_PARCIAL,
	[Description("Remessa rejeitada")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	REMESSA_REJEITADA,
	[Description("Lançamento a crédito")]
	[AtributoDominio("C", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	LANCAMENTO_A_CREDITO,
	[Description("Lançamento a débito")]
	[AtributoDominio("D", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	LANCAMENTO_A_DEBITO,
	[Description("Extrato para conciliação")]
	[AtributoDominio("E", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	EXTRATO_PARA_CONCILIACAO,
	[Description("Extrato para gestão de caixa")]
	[AtributoDominio("G", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	EXTRATO_PARA_GESTAO_DE_CAIXA,
	[Description("Informações de títulos capturados do próprio banco")]
	[AtributoDominio("I", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	INFORMACOES_DE_TITULOS_CAPTURADOS_DO_PROPRIO_BANCO,
	[Description("Arquivo de remessa")]
	[AtributoDominio("R", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	ARQUIVO_REMESSA,
	[Description("Arquivo retorno")]
	[AtributoDominio("T", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	ARQUIVO_RETORNO
}
