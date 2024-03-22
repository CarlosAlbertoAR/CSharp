using System.ComponentModel;

namespace eCobranca.Enumerator;

public enum EnumCamposLayoutEstruturalBoleto
{
	[Description("Folha de estilos padrão utilizada na confecção de boletos")]
	ESTILOS,
	[Description("Recibo do sacado em tamanho grande padrão utilizado em boletos que ocupam uma página inteira")]
	RECIBOSACADOGRANDE,
	[Description("Recibo do sacado em tamanho normal padrão utilizado em boletos que ocupam meia página")]
	RECIBOSACADONORMAL,
	[Description("Recibo do sacado em tamanho reduzido padrão utilizado em boletos que ocupam meia página")]
	RECIBOSACADOREDUZIDO,
	[Description("Recibo do sacado estreito sem demonstrativo utililzando em boletos que ocupam meia página")]
	RECIBOSACADOSIMPLES,
	[Description("Recibo do sacado do tipo canhoto padrão utilizado em boletos em formato de carnet")]
	RECIBOSACADOCANHOTO,
	[Description("Recibo de entrega do tipo canhoto padrão utilizado em boletos em formato de carnet")]
	RECIBOENTREGACANHOTO,
	[Description("Recibo de entrega de tamanho normal padrão utilizado em boletos que ocupam meia página")]
	RECIBOENTREGANORMAL,
	[Description("Recibo de entrega de tamanho reduzido padrão utilizado em boletos que ocupam meia página")]
	RECIBOENTREGAREDUZIDO,
	[Description("Recibo de entrega estreito sem demonstrativo utilizao em boletos que ocupa, meia página")]
	RECIBOENTREGASIMPLES,
	[Description("Ficha de compensação padrão para boletos")]
	FICHACOMPENSACAO,
	[Description("Traço de corte padrão utilizado nos boletos")]
	TRACO
}
