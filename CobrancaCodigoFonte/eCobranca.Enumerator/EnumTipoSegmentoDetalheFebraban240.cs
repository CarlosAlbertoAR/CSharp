using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheFebraban240
{
	[Description("Segmento obrigatório P - remessa - FEBRABAN240")]
	[AtributoDominio("P", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_P,
	[Description("Segmento obrigatório Q - remessa - FEBRABAN240")]
	[AtributoDominio("Q", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Q,
	[Description("Segmento opcional R - remessa - FEBRABAN240")]
	[AtributoDominio("R", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_R,
	[Description("Segmento opcional S - remessa - FEBRABAN240")]
	[AtributoDominio("S", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_S,
	[Description("Segmento opcional S tipo de impressão 1 e 2 - remessa - FEBRABAN240")]
	[AtributoDominio("S", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_S_IMPRESSAO_TIPO_1_E_2,
	[Description("Segmento opcional S tipo de impressão 3 - remessa - FEBRABAN240")]
	[AtributoDominio("S", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_S_IMPRESSAO_TIPO_3,
	[Description("Segmento obrigatório T - retorno - FEBRABAN240")]
	[AtributoDominio("T", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_T,
	[Description("Segmento obrigatório U - remessa - FEBRABAN240")]
	[AtributoDominio("U", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_U,
	[Description("Segmento opcional Y - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y,
	[Description("Segmento opcional Y 01 - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y01,
	[Description("Segmento opcional Y 04 - remessa/Retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y04,
	[Description("Segmento opcional Y 05 - retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y05,
	[Description("Segmento opcional Y 50 - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y50,
	[Description("Segmento opcional Y 51 - remessa/retorno - FEBRABAN240")]
	[AtributoDominio("Y", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	SEGMENTO_Y51
}
