using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoFebraban150
{
	[Description("Segmento Header de Arquivo - FEBRABAN150")]
	[AtributoDominio("A", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HEADER_ARQUIVO,
	[Description("Segmento Detalhe G - FEBRABAN150")]
	[AtributoDominio("G", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_DETALHE_G,
	[Description("Segmento Trailler de Arquivo - FEBRABAN150")]
	[AtributoDominio("Z", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	TRAILLER_ARQUIVO
}
