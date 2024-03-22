using System;
using System.Diagnostics;
using System.IO;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Modelo;

public class ModeloBoletoPersonalizado : ModeloBoleto
{
	public ModeloBoletoPersonalizado(CarteiraCobranca carteira)
	{
		try
		{
			Logger.Debug("Criando modelo de boleto PadraoSacadoPaginaInteira...");
			Init(carteira, (EnumFormatoModeloBoleto)(object)carteira.ConfiguracaoBoleto.FormatoBoletoPersonalizado.ToEnum<EnumFormatoModeloBoleto>(), EnumTipoModeloBoleto.BOLETO_PERSONALIZADO);
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
			Logger.Debug("Obtendo modelo personalizado do boleto...");
			string text = carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + carteira.ConfiguracaoBoleto.ModeloBoletoPersonalizado;
			if (File.Exists(text))
			{
				result = File.ReadAllBytes(text);
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoInformadoNaoExiste(text), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("Modelo Boleto Personalizado", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string[] GetModeloHtml()
	{
		string[] result = null;
		try
		{
			Logger.Debug("Obtendo modelo personalizado do boleto...");
			string text = carteira.ConfiguracaoBoleto.DiretorioModeloBoletoPersonalizado + carteira.ConfiguracaoBoleto.ModeloBoletoPersonalizado;
			if (File.Exists(text))
			{
				result = StringUtil.GetStringsFromStream(new MemoryStream(File.ReadAllBytes(text)));
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ArquivoInformadoNaoExiste(text), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaObtendoModeloBoleto("Modelo Boleto Personalizado", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
