using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoNomenclaturaBoleto
{
	[Description("CNPJ + Nº Documento + Nosso número")]
	[AtributoDominio("1", "COMPLETO", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CNPJ_DOCUMENTO_NN,
	[Description("Nº Documento + Nosso número")]
	[AtributoDominio("2", "NORMAL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	DOCUMENTO_NN,
	[Description("Nosso número")]
	[AtributoDominio("3", "SIMPLES", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	NN
}
