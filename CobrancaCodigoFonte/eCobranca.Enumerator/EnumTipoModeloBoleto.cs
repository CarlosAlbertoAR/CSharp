using System.ComponentModel;
using eCobranca.Atributos;

namespace eCobranca.Enumerator;

public enum EnumTipoModeloBoleto
{
	[Description("Modelo de boleto padrão uma página com apenas recibo de sacado e ficha de compensação")]
	[AtributoDominio("01", "Padrão sacado página inteira", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_PADRAO_SACADO_PAGINA_INTEIRA,
	[Description("Modelo de boleto padrão uma página com recibo de entrega, recibo do sacado e ficha de compensação")]
	[AtributoDominio("02", "Padrão sacado e entrega página inteira", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_PADRAO_SACADO_ENTREGA_PAGINA_INTEIRA,
	[Description("Modelo de boleto com o recibo do sacado no topo")]
	[AtributoDominio("03", "Padrão topo sacado meia página", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_TOPO_SACADO_MEIA_PAGINA,
	[Description("Modelo de boleto com o recibo do sacado e de entrega no topo")]
	[AtributoDominio("04", "Padrão topo sacado e entrega meia página", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA,
	[Description("Modelo de boleto em carnet com o recibo do sacado na lateral esquerda")]
	[AtributoDominio("05", "Padrão carnet sacado", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_CARNET_SACADO,
	[Description("Modelo de boleto em carnet com o recido de entrega no topo e o do sacado na lateral esquerda")]
	[AtributoDominio("06", "Padrão carnet sacado e entrega", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_CARNET_SACADO_ENTREGA,
	[Description("Modelo personalizado de boleto sob responsabilidade do cedente")]
	[AtributoDominio("07", "Personalizado", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_PERSONALIZADO,
	[Description("Modelo de boleto em carnet específico para impressoras zebras")]
	[AtributoDominio("08", "Padrão carnet sacado entrega para zebra", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_CARNET_SACADO_ENTREGA_ZEBRA,
	[Description("Modelo de boleto em carnet específico para impressoras portáteis de fitas de 75mm ")]
	[AtributoDominio("09", "Padrão carnet sacado entrega para impressoras portáteis", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_CARNET_SACADO_ENTREGA_FITA,
	[Description("Modelo de boleto padrão uma página com apenas recibo de sacado e ficha de compensação - Demonstrativo + Intruções extras")]
	[AtributoDominio("10", "Padrão sacado (demonstrativo + informações extras) página inteira", null)]
	[AtributoChave(new object[] { EnumChaveContexto.GERAL })]
	BOLETO_PADRAO_SACADO_PAGINA_INTEIRA_COM_INFORMACOES_EXTRAS
}
