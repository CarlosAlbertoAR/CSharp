using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoEmissaoBoleto
{
	[Description("Banco emite e processo o registro")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	BANCO_EMITE_E_PROCESSA_REGISTRO,
	[Description("Cliente emite e banco processa o registro")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN237_CNAB400,
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN041_FEBRABAN240,
		EnumChaveContexto.BAN084_CNAB400,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN097_FEBRABAN240,
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN399_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO,
	[Description("Banco emite e cliente complementa")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_PRE_EMITE_CLIENTE_COMPLEMENTA,
	[Description("Banco reemite")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_REEMITE,
	[Description("Banco não reemite")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_NAO_REEMITE,
	[Description("Banco emitente aberta")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_EMITENTE_ABERTA,
	[Description("Banco emitente auto envelopável")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_EMITENTE_AUTO_ENVELOPAVEL,
	[Description("Banco emite (boleto auto-envelopado)")]
	[AtributoDominio("9", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN399_FEBRABAN240 })]
	BANCO_EMITE_BOLETO_AUTO_ENVELOPADO
}
