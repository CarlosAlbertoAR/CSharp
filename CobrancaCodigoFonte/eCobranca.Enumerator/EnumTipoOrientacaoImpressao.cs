using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoOrientacaoImpressao
{
	[Description("Retrato")]
	[AtributoDominio("R", null)]
	RETRATO,
	[Description("Paisagem")]
	[AtributoDominio("P", null)]
	PAISAGEM
}
