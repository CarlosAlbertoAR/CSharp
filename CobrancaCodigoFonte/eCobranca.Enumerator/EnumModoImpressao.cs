using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumModoImpressao
{
	[Description("Impressão direta")]
	[AtributoDominio("01", "ID", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	IMPRESSAO_SEM_PREVIEW,
	[Description("Impressão com pré-visualização")]
	[AtributoDominio("02", "IPV", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	IMPRESSAO_COM_PREVIEW
}
