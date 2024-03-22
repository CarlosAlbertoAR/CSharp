using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban001;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactorySegmentoDetalheCnab400Ban001
{
	public static SegmentoCnab400 NovoSegmentoDetalheRemessa(EnumTipoSegmentoDetalheCnab400Ban001 tipoSegmento, long sequenciaSegmento)
	{
		SegmentoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de remessa CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban001.DETALHE:
				result = new DetalheRemessaCnab400Ban001(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_EMAIL:
				result = new MensagemRemessaCnab400Ban001Email(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_MULTA:
				result = new MensagemRemessaCnab400Ban001Multa(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_NUMERO_CEDENTE:
				result = new MensagemRemessaCnab400Ban001NumeroCedente(sequenciaSegmento);
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

	public static DetalheRetornoCnab400 NovoSegmentoDetalheRetorno(EnumTipoSegmentoDetalheCnab400Ban001 tipoSegmento)
	{
		DetalheRetornoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de retorno CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban001.DETALHE:
				result = new DetalheRetornoCnab400Ban001();
				return result;
			default:
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_EMAIL:
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_MULTA:
			case EnumTipoSegmentoDetalheCnab400Ban001.MENSAGEM_NUMERO_CEDENTE:
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
