using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoSegmentoDetalheCnab400Ban341
{
	[Description("Registro detalhe - remessa - CNAB400")]
	[AtributoDominio("1", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DETALHE = 0,
	[Description("Registro detalhe opcional - Multa - remessa - CNAB400")]
	[AtributoDominio("2", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DETALHE_OPCIONAL_MULTA = 4,
	[Description("Registro detalhe opcional - Dados Avalista - remessa - CNAB400")]
	[AtributoDominio("5", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	DETALHE_OPCIONAL = 1,
	[Description("Registro mensagem frente - remessa - CNAB400")]
	[AtributoDominio("7", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	MENSAGEM_FRENTE = 2,
	[Description("Registro mensagem verso - remessa - CNAB400")]
	[AtributoDominio("8", null)]
	[AtributoChave(new object[] { EnumChaveContexto.BAN341_CNAB400 })]
	MENSAGEM_VERSO = 3
}
