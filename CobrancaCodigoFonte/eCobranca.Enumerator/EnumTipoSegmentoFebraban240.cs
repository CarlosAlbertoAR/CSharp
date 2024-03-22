using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoFebraban240
{
	[Description("Segmento Header de Arquivo - FEBRABAN240")]
	[AtributoDominio("HA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HEADER_ARQUIVO,
	[Description("Segmento Header de Lote - FEBRABAN240")]
	[AtributoDominio("HL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	HEADER_LOTE,
	[Description("Segmento Detalhe P - FEBRABAN240")]
	[AtributoDominio("SP", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_P,
	[Description("Segmento Detalhe Q - FEBRABAN240")]
	[AtributoDominio("SQ", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Q,
	[Description("Segmento Detalhe R - FEBRABAN240")]
	[AtributoDominio("SR", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_R,
	[Description("Segmento Detalhe S Impressão Tipo 1 e 2 - FEBRABAN240")]
	[AtributoDominio("SS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_S_IMPRESSAO_TIPO_1_E_2,
	[Description("Segmento Detalhe S Impressão Tipo 3 - FEBRABAN240")]
	[AtributoDominio("SS", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_S_IMPRESSAO_TIPO_3,
	[Description("Segmento Detalhe T - FEBRABAN240")]
	[AtributoDominio("ST", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_T,
	[Description("Segmento Detalhe U - FEBRABAN240")]
	[AtributoDominio("SU", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_U,
	[Description("Segmento Detalhe Y01 - FEBRABAN240")]
	[AtributoDominio("SY01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Y01,
	[Description("Segmento Detalhe Y01 - FEBRABAN240")]
	[AtributoDominio("SY04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Y04,
	[Description("Segmento Detalhe Y01 - FEBRABAN240")]
	[AtributoDominio("SY05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Y05,
	[Description("Segmento Detalhe Y01 - FEBRABAN240")]
	[AtributoDominio("SY50", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Y50,
	[Description("Segmento Detalhe Y01 - FEBRABAN240")]
	[AtributoDominio("SY51", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	SEGMENTO_Y51,
	[Description("Trailler de Lote - FEBRABAN240")]
	[AtributoDominio("TL", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	TRAILLER_LOTE,
	[Description("Trailler de Arquivo - FEBRABAN240")]
	[AtributoDominio("TA", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	TRAILLER_ARQUIVO
}
