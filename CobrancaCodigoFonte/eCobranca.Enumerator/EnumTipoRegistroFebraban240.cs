using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoRegistroFebraban240
{
	[Description("Header de arquivo - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	HEADER_DE_ARQUIVO,
	[Description("Header de lote - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	HEADER_DE_LOTE,
	[Description("Registro inicial de lote - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	REGISTROS_INICIAIS_DO_LOTE,
	[Description("Registro de detalhe do lote - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	DETALHE,
	[Description("Registro final de lote - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	REGISTROS_FINAIS_DO_LOTE,
	[Description("Trailler do lote - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	TRAILLER_DE_LOTE,
	[Description("Trailler do arquivo - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	TRAILLER_DE_ARQUIVO
}
