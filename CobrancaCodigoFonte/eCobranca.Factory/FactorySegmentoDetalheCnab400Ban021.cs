using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban021;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactorySegmentoDetalheCnab400Ban021
{
	public static SegmentoCnab400 NovoSegmentoDetalheRemessa(EnumTipoSegmentoDetalheCnab400Ban021 tipoSegmento, long sequenciaSegmento)
	{
		SegmentoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de remessa CNAB400");
			if (tipoSegmento == EnumTipoSegmentoDetalheCnab400Ban021.REGISTRO_TRANSACAO)
			{
				result = new RegistroTransacaoRemessaCnab400Ban021(sequenciaSegmento);
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoSegmentoDetalheCnab400(tipoSegmento.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static DetalheRetornoCnab400 NovoSegmentoDetalheRetorno(EnumTipoSegmentoDetalheCnab400Ban021 tipoSegmento)
	{
		DetalheRetornoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de retorno CNAB400");
			if (tipoSegmento == EnumTipoSegmentoDetalheCnab400Ban021.REGISTRO_TRANSACAO)
			{
				result = new RegistroTransacaoRetornoCnab400Ban021();
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoSegmentoDetalheCnab400(tipoSegmento.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
