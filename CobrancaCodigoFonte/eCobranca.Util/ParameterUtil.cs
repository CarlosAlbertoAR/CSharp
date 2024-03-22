using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using eCobranca.Core;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Util;

public class ParameterUtil
{
	private static ParameterUtil uniqueInstance;

	private static object syncRoot = new object();

	private ParameterUtil()
	{
	}

	public static ParameterUtil GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de carteiras de cobrança...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new ParameterUtil();
					}
				}
			}
			return uniqueInstance;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaInstanciandoClasse(typeof(ParameterUtil).Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public string GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao parametro, ParametroConfiguracao parametroPadrao, ArrayList parametrosAdicionais)
	{
		return (from ParametroConfiguracao x in parametrosAdicionais
			where x.Nome == parametro.Descricao()
			select x).DefaultIfEmpty(parametroPadrao).FirstOrDefault().Valor;
	}
}
