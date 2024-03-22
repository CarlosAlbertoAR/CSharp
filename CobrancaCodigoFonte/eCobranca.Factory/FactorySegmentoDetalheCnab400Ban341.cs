using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public static class FactorySegmentoDetalheCnab400Ban341
{
	public static SegmentoCnab400 NovoSegmentoDetalheRemessa(EnumTipoSegmentoDetalheCnab400Ban341 tipoSegmento, long sequenciaSegmento)
	{
		SegmentoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de remessa CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban341.DETALHE:
				result = new DetalheRemessaCnab400Ban341(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban341.DETALHE_OPCIONAL:
				result = new DetalheOpcionalRemessaCnab400Ban341(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban341.MENSAGEM_FRENTE:
				result = new RegistroMensagemFrenteRemessaCnab400Ban341(sequenciaSegmento);
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban341.MENSAGEM_VERSO:
				result = new RegistroMensagemVersoRemessaCnab400Ban341(sequenciaSegmento);
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

	public static DetalheRetornoCnab400 NovoSegmentoDetalheRetorno(EnumTipoSegmentoDetalheCnab400Ban341 tipoSegmento)
	{
		DetalheRetornoCnab400 result = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento [{tipoSegmento.ToString()}] do arquivo de retorno CNAB400");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoDetalheCnab400Ban341.DETALHE:
				result = new DetalheRetornoCnab400Ban341();
				return result;
			default:
				return result;
			case EnumTipoSegmentoDetalheCnab400Ban341.DETALHE_OPCIONAL:
			case EnumTipoSegmentoDetalheCnab400Ban341.MENSAGEM_FRENTE:
			case EnumTipoSegmentoDetalheCnab400Ban341.MENSAGEM_VERSO:
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
