using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumModoSaida
{
	[Description("Saída individual")]
	[AtributoDominio("01", "SI", "Para cada página será gerado um arquivo individual", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SAIDA_INDIVIDUAL,
	[Description("Saída unificada")]
	[AtributoDominio("02", "SU", "Todas as páginas serão unificadas em um único arquivo", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SAIDA_UNIFICADA,
	[Description("Saída mista")]
	[AtributoDominio("03", "SU", "Para cada página será gerado um arquivo individual e no final um unificado para a impressão", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SAIDA_COMPOSTA,
	[Description("Saída nula")]
	[AtributoDominio("04", "SU", "Não são gerados arquivos físicos", "", "", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SAIDA_NULA
}
