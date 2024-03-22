using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoTaxaPermanencia
{
	[Description("Acata comissão por dia")]
	[AtributoDominio("00", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN104_CNAB400 })]
	ACATA_COMISSAO_POR_DIA
}
