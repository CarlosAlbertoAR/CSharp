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

public class ModeloBoletoCarnetSacadoEntrega : ModeloBoleto
{
	public ModeloBoletoCarnetSacadoEntrega(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto CarnetSacadoEntrega...");
			Init(carteira, EnumFormatoModeloBoleto.MEIA_PAGINA, EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA);
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
			Logger.Debug("Obtendo o modelo PadraoCarnetSacadoEntregaFrx...");
			result = Resources.CarnetSacadoEntregaFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoCarnetSacadoEntregaFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo modelo CarnetSacadoEntrega...");
			result = StringUtil.GetStringsFromStream(new MemoryStream(Resources.CarnetSacadoEntrega));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("CarnetSacadoEntrega", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
