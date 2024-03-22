using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumModuloParametrizacao
{
	[Description("Parametrização de configuração de carteira cobrança")]
	[AtributoDominio("01", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_CARTEIRA_COBRANCA,
	[Description("Parametrização de configuração de documento de cobrança")]
	[AtributoDominio("02", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_DOCUMENTO_COBRANCA,
	[Description("Parametrização de configuração de boleto")]
	[AtributoDominio("03", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_BOLETO,
	[Description("Parametrização de configuração de arquivo de remessa")]
	[AtributoDominio("04", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_REMESSA,
	[Description("Parametrização de configuração de arquivo de retorno")]
	[AtributoDominio("05", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_RETORNO,
	[Description("Parametrização de configuração de impressão")]
	[AtributoDominio("06", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	CONFIGURACAO_IMPRESSAO,
	[Description("Parametrização de documento de cobrança")]
	[AtributoDominio("07", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	DOCUMENTO_COBRANCA,
	[Description("Parametrização de ocorrência de cobrança")]
	[AtributoDominio("08", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	OCORRENCIA_COBRANCA
}
