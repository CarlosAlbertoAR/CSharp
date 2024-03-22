using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoRegistroCnab400
{
	[Description("Registro header de arquivo - remessa - CNAB400")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400
	})]
	HEADER,
	[Description("Registro trailler de arquivo - remessa - CNAB400")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN341_CNAB400,
		EnumChaveContexto.BAN001_CBR641,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN004_CNAB400,
		EnumChaveContexto.BAN422_CNAB400,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN097_CNAB400
	})]
	TRAILLER
}
