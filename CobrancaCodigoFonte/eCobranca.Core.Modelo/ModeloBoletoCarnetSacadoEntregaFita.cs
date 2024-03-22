using System;
using System.Diagnostics;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Properties;

namespace eCobranca.Core.Modelo;

public class ModeloBoletoCarnetSacadoEntregaFita : ModeloBoleto
{
	public ModeloBoletoCarnetSacadoEntregaFita(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto CarnetSacadoEntregaFita...");
			Init(carteira, EnumFormatoModeloBoleto.PAGINA_INTEIRA, EnumTipoModeloBoleto.BOLETO_CARNET_SACADO_ENTREGA_FITA);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse("ModeloBoletoCarnetSacadoEntregaFita", ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	protected override byte[] GetModeloFastReports()
	{
		byte[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo CarnetSacadoEntregaFitaFrx...");
			result = Resources.CarnetSacadoEntregaFitaFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("CarnetSacadoEntregaFitaFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		return null;
	}
}
