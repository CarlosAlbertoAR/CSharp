using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoInscricao
{
	[Description("Isento")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643
	})]
	ISENTO,
	[Description("Isento ou não informado")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	ISENTO_OU_NAO_INFORMADO,
	[Description("CPF: Pessoa física")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CPF,
	[Description("CPF: Pessoa física")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CPF_PF,
	[Description("CNPJ: Pessoa jurídica")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN001_CBR643,
		EnumChaveContexto.BAN033_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN399_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	CNPJ,
	[Description("CNPJ: Pessoa jurídica")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN748_CNAB400
	})]
	CNPJ_PJ,
	[Description("PIS/PASEP")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	PIS_PASEP,
	[Description("PIS/PASEP")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240
	})]
	PIS_OU_PASEP,
	[Description("Não tem")]
	[AtributoDominio("98", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	NAO_TEM,
	[Description("Outros")]
	[AtributoDominio("99", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN399_CNAB400
	})]
	OUTROS,
	[Description("Outros")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN033_FEBRABAN240,
		EnumChaveContexto.BAN037_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240
	})]
	OUTROS_2
}
