using System;
using System.Diagnostics;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Repositorio;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactoryRepositorioCodigosCobranca
{
	private static FactoryRepositorioCodigosCobranca uniqueInstance;

	private static object syncRoot = new object();

	private FactoryRepositorioCodigosCobranca()
	{
	}

	public static FactoryRepositorioCodigosCobranca GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de repositótios de códigos de cobrança...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new FactoryRepositorioCodigosCobranca();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FalhaCriandoFabricaRepositorioCodigosCobranca(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return null;
	}

	public RepositorioCodigosCobranca GetRepositorio(EnumCodigoBanco banco, EnumTipoCarteiraCobranca tipoCarteira = EnumTipoCarteiraCobranca.CARTEIRA_NAO_INFORMADA)
	{
		return banco switch
		{
			EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL => new RepositorioCodigosCobrancaBan756(tipoCarteira), 
			EnumCodigoBanco.BANCO_BRADESCO => new RepositorioCodigosCobrancaBan237(tipoCarteira), 
			_ => new RepositorioCodigosCobranca(banco, tipoCarteira), 
		};
	}
}
