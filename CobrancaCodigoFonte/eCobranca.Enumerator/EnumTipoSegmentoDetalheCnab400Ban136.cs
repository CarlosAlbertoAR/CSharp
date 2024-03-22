using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban136
{
	[Description("Registro de detalhe - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN136_CNAB400 })]
	REGISTRO_TIPO1,
	[Description("Registro de dados do sacador/avalista - remessa - CNAB400")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN136_CNAB400 })]
	REGISTRO_TIPO5
}
