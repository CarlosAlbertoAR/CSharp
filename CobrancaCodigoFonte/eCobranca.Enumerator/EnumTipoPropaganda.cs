using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoPropaganda
{
	[Description("Propaganda modo texto")]
	[AtributoDominio("T", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	TEXTO,
	[Description("Propaganda modo imagem")]
	[AtributoDominio("I", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	IMAGEM
}
