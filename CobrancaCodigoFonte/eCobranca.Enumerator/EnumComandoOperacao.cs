using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumComandoOperacao
{
	[Description("Comando de edição")]
	[AtributoDominio("edit", null)]
	EDIT,
	[Description("Comando de visualização")]
	[AtributoDominio("explore", null)]
	EXPLORE,
	[Description("Comando de busca")]
	[AtributoDominio("find", null)]
	FIND,
	[Description("Comando de abertura")]
	[AtributoDominio("open", null)]
	OPEN,
	[Description("Comando de impressão")]
	[AtributoDominio("print", null)]
	PRINT
}
