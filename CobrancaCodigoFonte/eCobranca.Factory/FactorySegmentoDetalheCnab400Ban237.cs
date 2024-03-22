using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban237;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactorySegmentoDetalheCnab400Ban237
{
	public static SegmentoCnab400 NovoSegmentoDetalheRemessa(EnumTipoSegmentoDetalheCnab400Ban237 tipoSegmento, long sequenciaSegmento)
	{
		SegmentoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de remessa CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_1:
				result = new RegistroTransacaoTipo1RemessaCnab400Ban237(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_2:
				result = new RegistroTransacaoTipo2RemessaCnab400Ban237(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_3:
				result = new RegistroTransacaoTipo3RemessaCnab400Ban237(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_7:
				result = new RegistroTransacaoTipo7RemessaCnab400Ban237(sequenciaSegmento);
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

	public static DetalheRetornoCnab400 NovoSegmentoDetalheRetorno(EnumTipoSegmentoDetalheCnab400Ban237 tipoSegmento)
	{
		DetalheRetornoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de retorno CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_1:
				result = new RegistroTransacaoTipo1RetornoCnab400Ban237();
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_3:
				result = new RegistroTransacaoTipo3RetornoCnab400Ban237();
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
}
