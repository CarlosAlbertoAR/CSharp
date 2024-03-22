using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoData
{
	[Description("Data no formato DDMMAA, onde: DD = Dia, MM = mês, AA = Ano")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	DDMMAA,
	[Description("Data no formato DDMMAAAA, onde: DD = Dia, MM = mês, AAAA = Ano")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	DDMMAAAA,
	[Description("Data no formato AAAAMMDD, onde: AAAA = Ano, MM = mês, DD = Dia")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	AAAAMMDD
}
