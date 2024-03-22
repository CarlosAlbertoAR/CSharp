using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumCodigoDistribuicao
{
	[Description("Postagem pelo cedente")]
	[AtributoDominio("0", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400
	})]
	POSTAGEM_PELO_CEDENTE,
	[Description("Sacado via correios")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400
	})]
	SACADO_VIA_CORREIOS,
	[Description("Banco distribui")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	BANCO_DISTRIBUI,
	[Description("Cliente distribui")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN003_FEBRABAN240,
		EnumChaveContexto.BAN085_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240,
		EnumChaveContexto.BAN756_FEBRABAN240
	})]
	CLIENTE_DISTRIBUI,
	[Description("Cedente via agência caixa")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400
	})]
	CEDENTE_VIA_AGENCIA_CAIXA,
	[Description("Banco envia email")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_ENVIA_EMAIL,
	[Description("Sacado via email")]
	[AtributoDominio("3", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN104_FEBRABAN240,
		EnumChaveContexto.BAN104_CNAB400
	})]
	SACADO_VIA_EMAIL,
	[Description("Banco envia SMS")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN001_FEBRABAN240,
		EnumChaveContexto.BAN237_FEBRABAN240,
		EnumChaveContexto.BAN341_FEBRABAN240,
		EnumChaveContexto.BAN422_FEBRABAN240
	})]
	BANCO_ENVIA_SMS,
	[Description("Sacado via SMS")]
	[AtributoDominio("4", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_FEBRABAN240 })]
	SACADO_VIA_SMS
}
