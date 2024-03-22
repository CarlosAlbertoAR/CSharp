using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoDistribuicaoBoleto
{
	[Description("Distribuicao efetuada pelo banco")]
	[AtributoDominio("1", "BAN", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DISTRIBUIDOR_BANCO,
	[Description("Distribuição efetuada pelo beneficiário")]
	[AtributoDominio("2", "BEN", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	DISTRIBUIDOR_CEDENTE,
	[Description("banco envia email")]
	[AtributoDominio("3", "EMA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN085_FEBRABAN240 })]
	BANCO_ENVIA_EMAIL
}
