using System;
using System.Diagnostics;
using eCobranca.Core.Excecao;

namespace eCobranca.Util;

public static class MathUtil
{
	public static double ConverterTaxaJurosDiarioParaMensal(double taxaDiaria)
	{
		double result = 0.0;
		try
		{
			if (taxaDiaria < 0.0)
			{
				taxaDiaria *= -1.0;
			}
			result = taxaDiaria * 30.0;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaConvertendoTaxaDeJurosDiariaParaMensal(ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
