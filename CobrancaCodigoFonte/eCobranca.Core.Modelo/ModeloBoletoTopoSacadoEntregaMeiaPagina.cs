using System;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Properties;
using eCobranca.Util;

namespace eCobranca.Core.Modelo;

public class ModeloBoletoTopoSacadoEntregaMeiaPagina : ModeloBoleto
{
	public ModeloBoletoTopoSacadoEntregaMeiaPagina(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto TopoSacadoEntregaMeiaPagina...");
			Init(carteira, EnumFormatoModeloBoleto.MEIA_PAGINA, EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_ENTREGA_MEIA_PAGINA);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected override byte[] GetModeloFastReports()
	{
		byte[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo PadraoTopoSacadoEntregaMeiaPaginaFrx...");
			result = Resources.TopoSacadoEntregaMeiaPaginaFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoTopoSacadoEntregaMeiaPaginaFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo TopoSacadoEntregaMeiaPagina...");
			result = StringUtil.GetStringsFromStream(new MemoryStream(Resources.TopoSacadoEntregaMeiaPagina));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("TopoSacadoEntregaMeiaPagina", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
