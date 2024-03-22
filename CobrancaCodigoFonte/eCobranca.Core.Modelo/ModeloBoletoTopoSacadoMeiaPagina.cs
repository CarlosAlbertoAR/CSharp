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

public class ModeloBoletoTopoSacadoMeiaPagina : ModeloBoleto
{
	public ModeloBoletoTopoSacadoMeiaPagina(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando o modelo de boleto TopoSacadoMeiaPagina...");
			Init(carteira, EnumFormatoModeloBoleto.MEIA_PAGINA, EnumTipoModeloBoleto.BOLETO_TOPO_SACADO_MEIA_PAGINA);
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
			Logger.Debug("Obtendo o modelo PadraoTopoSacadoMeiaPaginaFrx...");
			result = Resources.TopoSacadoMeiaPaginaFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoTopoSacadoMeiaPaginaFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo TopoSacadoMeiaPagina...");
			result = StringUtil.GetStringsFromStream(new MemoryStream(Resources.TopoSacadoMeiaPagina));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("TopoSacadoMeiaPagina", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
