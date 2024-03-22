using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban084;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactorySegmentoDetalheCnab400Ban084
{
	public static SegmentoCnab400 NovoSegmentoDetalheRemessa(EnumTipoSegmentoDetalheCnab400Ban084 tipoSegmento, long sequenciaSegmento)
	{
		SegmentoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de remessa CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban084.DETALHE:
				result = new RegistroTransacaoTipo1RemessaCnab400Ban084(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban084.MENSAGEM:
				result = new RegistroTransacaoTipo2RemessaCnab400Ban084(sequenciaSegmento);
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
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoSegmentoDetalheCnab400(tipoSegmento.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	public static DetalheRetornoCnab400 NovoSegmentoDetalheRetorno(EnumTipoSegmentoDetalheCnab400Ban084 tipoSegmento)
	{
		DetalheRetornoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de retorno CNAB400");
			if (tipoSegmento == EnumTipoSegmentoDetalheCnab400Ban084.DETALHE)
			{
				result = new RegistroTransacaoTipo1RetornoCnab400Ban084();
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
