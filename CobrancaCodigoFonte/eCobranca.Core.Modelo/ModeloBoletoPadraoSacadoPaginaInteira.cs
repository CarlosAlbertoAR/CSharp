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

public class ModeloBoletoPadraoSacadoPaginaInteira : ModeloBoleto
{
	public ModeloBoletoPadraoSacadoPaginaInteira(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto PadraoSacadoPaginaInteira...");
			Init(carteira, EnumFormatoModeloBoleto.PAGINA_INTEIRA, EnumTipoModeloBoleto.BOLETO_PADRAO_SACADO_PAGINA_INTEIRA);
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
			Logger.Debug("Obtendo o modelo PadraoSacadoPaginaInteira...");
			result = Resources.PadraoSacadoPaginaInteiraFrx;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoSacadoPaginaInteiraFrx", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo o modelo PadraoSacadoPaginaInteira...");
			result = StringUtil.GetStringsFromStream(new MemoryStream(Resources.PadraoSacadoPaginaInteira));
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("PadraoSacadoPaginaInteira", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
