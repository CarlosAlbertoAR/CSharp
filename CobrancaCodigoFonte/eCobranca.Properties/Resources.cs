using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace eCobranca.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("eCobranca.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] CarnetSacado => (byte[])ResourceManager.GetObject("CarnetSacado", resourceCulture);

	internal static byte[] CarnetSacadoEntrega => (byte[])ResourceManager.GetObject("CarnetSacadoEntrega", resourceCulture);

	internal static byte[] CarnetSacadoEntregaFitaFrx => (byte[])ResourceManager.GetObject("CarnetSacadoEntregaFitaFrx", resourceCulture);

	internal static byte[] CarnetSacadoEntregaFrx => (byte[])ResourceManager.GetObject("CarnetSacadoEntregaFrx", resourceCulture);

	internal static byte[] CarnetSacadoEntregaZebra => (byte[])ResourceManager.GetObject("CarnetSacadoEntregaZebra", resourceCulture);

	internal static byte[] CarnetSacadoEntregaZebraFrx => (byte[])ResourceManager.GetObject("CarnetSacadoEntregaZebraFrx", resourceCulture);

	internal static byte[] CarnetSacadoFrx => (byte[])ResourceManager.GetObject("CarnetSacadoFrx", resourceCulture);

	internal static byte[] log4netApp => (byte[])ResourceManager.GetObject("log4netApp", resourceCulture);

	internal static byte[] PadraoSacadoEntregaPaginaInteira => (byte[])ResourceManager.GetObject("PadraoSacadoEntregaPaginaInteira", resourceCulture);

	internal static byte[] PadraoSacadoEntregaPaginaInteiraFrx => (byte[])ResourceManager.GetObject("PadraoSacadoEntregaPaginaInteiraFrx", resourceCulture);

	internal static byte[] PadraoSacadoPaginaInteira => (byte[])ResourceManager.GetObject("PadraoSacadoPaginaInteira", resourceCulture);

	internal static byte[] PadraoSacadoPaginaInteiraDemonstrativoComInformacoesExtrasFrx => (byte[])ResourceManager.GetObject("PadraoSacadoPaginaInteiraDemonstrativoComInformacoesExtrasFrx", resourceCulture);

	internal static byte[] PadraoSacadoPaginaInteiraFrx => (byte[])ResourceManager.GetObject("PadraoSacadoPaginaInteiraFrx", resourceCulture);

	internal static byte[] TEMPLATE_EstilosPadraoHtml => (byte[])ResourceManager.GetObject("TEMPLATE_EstilosPadraoHtml", resourceCulture);

	internal static byte[] TEMPLATE_EstilosPadraoPdf => (byte[])ResourceManager.GetObject("TEMPLATE_EstilosPadraoPdf", resourceCulture);

	internal static byte[] TEMPLATE_FichaCompensacaoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_FichaCompensacaoPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboEntregaCanhotoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboEntregaCanhotoPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboEntregaNormalPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboEntregaNormalPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboEntregaReduzidoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboEntregaReduzidoPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboEntregaSimplesPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboEntregaSimplesPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboSacadoCanhotoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboSacadoCanhotoPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboSacadoGrandePadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboSacadoGrandePadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboSacadoNormalPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboSacadoNormalPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboSacadoReduzidoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboSacadoReduzidoPadrao", resourceCulture);

	internal static byte[] TEMPLATE_ReciboSacadoSimplesPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_ReciboSacadoSimplesPadrao", resourceCulture);

	internal static byte[] TEMPLATE_TracoPadrao => (byte[])ResourceManager.GetObject("TEMPLATE_TracoPadrao", resourceCulture);

	internal static byte[] TopoSacadoEntregaMeiaPagina => (byte[])ResourceManager.GetObject("TopoSacadoEntregaMeiaPagina", resourceCulture);

	internal static byte[] TopoSacadoEntregaMeiaPaginaFrx => (byte[])ResourceManager.GetObject("TopoSacadoEntregaMeiaPaginaFrx", resourceCulture);

	internal static byte[] TopoSacadoMeiaPagina => (byte[])ResourceManager.GetObject("TopoSacadoMeiaPagina", resourceCulture);

	internal static byte[] TopoSacadoMeiaPaginaFrx => (byte[])ResourceManager.GetObject("TopoSacadoMeiaPaginaFrx", resourceCulture);

	internal Resources()
	{
	}
}
