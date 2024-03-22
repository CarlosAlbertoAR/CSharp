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

public class ModeloBoletoCarnetSacadoEntregaZebra : ModeloBoleto
{
	public ModeloBoletoCarnetSacadoEntregaZebra(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto CarnetSacadoEntregaZebra...");
			Init(carteira, EnumFormatoModeloBoleto.PAGINA_INTEIRA, EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_ZEBRA);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse("ModeloBoletoCarnetSacadoEntregaZebra", ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected override byte[] GetModeloFastReports()
	{
		byte[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo PadraoCarnetSacadoEntregaZebraFrx...");
			result = Resources.CarnetSacadoEntregaZebraFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoCarnetSacadoEntregaZebraFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo modelo CarnetSacado...");
			result = StringUtil.GetStringsFromStream(new MemoryStream(Resources.CarnetSacadoEntregaZebra));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("CarnetSacado", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
