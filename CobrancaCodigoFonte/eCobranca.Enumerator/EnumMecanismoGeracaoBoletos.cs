using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumMecanismoGeracaoBoletos
{
	[Description("FastReports")]
	[AtributoDominio("FRX", "", "Mecanismo de geração do FastReports", "", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	FRX,
	[Description("Html")]
	[AtributoDominio("HTM", "", "Mecanismo de geração baseado em html", "", "", null)]
	[AtributoChave(new object[]
	{
		EnumModuloParametrizacao.CONFIGURACAO_BOLETO,
		EnumChaveContexto.GERAL
	})]
	HTM
}
