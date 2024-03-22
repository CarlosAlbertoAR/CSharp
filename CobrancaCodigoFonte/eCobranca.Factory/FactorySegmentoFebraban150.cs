using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban150.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactorySegmentoFebraban150
{
	private static FactorySegmentoFebraban150 uniqueInstance;

	private static object syncRoot = new object();

	private FactorySegmentoFebraban150()
	{
	}

	public static FactorySegmentoFebraban150 GetInstance()
	{
		try
		{
			Logger.Debug("Criando fábrica de Segmentos de Detalhe de arquivos FEBRABAN150...");
			if (uniqueInstance == null)
			{
				lock (syncRoot)
				{
					if (uniqueInstance == null)
					{
						uniqueInstance = new FactorySegmentoFebraban150();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoFabricaSegmentoDetalheFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return null;
		}
	}

	public SegmentoFebraban150 NovoSegmento(EnumCodigoBanco banco, EnumTipoSegmentoFebraban150 tipoSegmento, long sequenciaLote, long sequenciaSegmento)
	{
		SegmentoFebraban150 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento de detalhe [{tipoSegmento.ToString()}]");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoFebraban150.HEADER_ARQUIVO:
				result = new HeaderArquivoFebraban150Padrao();
				return result;
			case EnumTipoSegmentoFebraban150.SEGMENTO_DETALHE_G:
				result = new SegmentoDetalheGFebraban150Padrao();
				return result;
			case EnumTipoSegmentoFebraban150.TRAILLER_ARQUIVO:
				result = new TraillerArquivoFebraban150Padrao();
				return result;
			default:
				return result;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoSegmentoDetalheFebraban240(tipoSegmento.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
