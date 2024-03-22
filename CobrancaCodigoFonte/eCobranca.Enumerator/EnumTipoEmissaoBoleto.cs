using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoEmissaoBoleto
{
	[Description("Emissão efetuada pelo banco")]
	[AtributoDominio("1", "BAN", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	EMISSOR_BANCO,
	[Description("Emissão efetuada pelo cedente")]
	[AtributoDominio("2", "BAN", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN133_CNAB400,
		EnumChaveContexto.BAN756_CNAB400,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	EMISSOR_CEDENTE
}
