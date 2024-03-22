using System;
using System.Diagnostics;
using eCobranca.Core;
using eCobranca.Core.Excecao;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactoryParametroConfiguracao
{
	public static ParametroConfiguracao CriarParametroConfiguracao(EnumParametrosAdicionaisConfiguracao valorEnum)
	{
		ParametroConfiguracao result = null;
		try
		{
			result = new ParametroConfiguracao(valorEnum);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse("CriarParametroConfiguracao", ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
