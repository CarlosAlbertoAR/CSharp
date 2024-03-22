using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban033
{
	[Description("Registro detalhe - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	REGISTRO_TIPO_1,
	[Description("Registro mensagem - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN033_CNAB400 })]
	REGISTRO_TIPO_2
}
