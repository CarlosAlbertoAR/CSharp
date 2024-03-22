using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumLayoutCobranca
{
	[Description("FEBRABAN240")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoBanco.BANCO_DO_BRASIL,
		EnumCodigoBanco.BANCO_SANTANDER,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_ITAU,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	FEBRABAN240,
	[Description("CNAB400")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[]
	{
		EnumCodigoBanco.BANCO_SANTANDER,
		EnumCodigoBanco.UNIPRIME_NORTE_PARANA,
		EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED,
		EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL,
		EnumCodigoBanco.CRESOL,
		EnumCodigoBanco.BANCO_BRADESCO,
		EnumCodigoBanco.BANCO_ITAU,
		EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI
	})]
	CNAB400,
	[Description("CBR641")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumCodigoBanco.BANCO_DO_BRASIL })]
	CBR641,
	[Description("CBR643")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumCodigoBanco.BANCO_DO_BRASIL })]
	CBR643,
	[Description("FEBRABAN150")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumCodigoBanco.BANCO_DA_AMAZONIA })]
	FEBRABAN150
}
