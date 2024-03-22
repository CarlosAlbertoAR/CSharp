using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumAvisoDebitoAutomatico
{
	[Description("Emite aviso")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	EMITE_AVISO = 0,
	[Description("Emite o aviso com o endereço informado no arquivo remessa")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	EMITE_AVISO2 = 2,
	[Description("Não emite aviso")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN237_CNAB400 })]
	NAO_EMITE_AVISO = 1,
	[Description("Não Emite Aviso ao Pagador")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	NAO_EMITE_AVISO_AO_PADOR = 3,
	[Description("Emite aviso com o endereço constante no cadastro do banco")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN422_FEBRABAN240 })]
	EMITE_AVISO3 = 4
}
