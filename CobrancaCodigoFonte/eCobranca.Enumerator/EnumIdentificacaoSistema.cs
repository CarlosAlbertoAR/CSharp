using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumIdentificacaoSistema
{
	[Description("MX")]
	[AtributoDominio("MX", null)]
	[AtributoChave(new object[]
	{
		EnumChaveContexto.BAN099_CNAB400,
		EnumChaveContexto.BAN237_CNAB400
	})]
	MX
}
