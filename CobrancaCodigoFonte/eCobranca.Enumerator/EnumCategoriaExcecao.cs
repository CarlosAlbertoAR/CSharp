using System.ComponentModel;

namespace eCobranca.Enumerator;

public enum EnumCategoriaExcecao
{
	[Description("Regra de negócio")]
	REGRA_NEGOCIO,
	[Description("Validação")]
	VALIDACAO,
	[Description("Geral")]
	GERAL
}
