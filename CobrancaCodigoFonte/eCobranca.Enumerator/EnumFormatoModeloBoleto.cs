using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumFormatoModeloBoleto
{
	[Description("Página inteira")]
	[AtributoDominio("01", "PI", "Possibilita a geração apenas de 1 boleto por página", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	PAGINA_INTEIRA,
	[Description("Meia página")]
	[AtributoDominio("02", "MP", "Possibilita a geração de até 2 boletos por página", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	MEIA_PAGINA,
	[Description("Carnet")]
	[AtributoDominio("03", "CR", "Possibilita a geração de até 3 boletos por página", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CARNET_TRES_POR_PAGINA
}
