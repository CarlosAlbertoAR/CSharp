using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactorySegmentoFebraban240Ban033 : FactorySegmentoFebraban240
{
	public override SegmentoFebraban240 NovoSegmento(EnumTipoSegmentoFebraban240 tipoSegmento, long sequenciaLote, long sequenciaSegmento, bool segmentoDeRemessa)
	{
		SegmentoFebraban240 segmentoFebraban = null;
		try
		{
			Logger.Debug($"Obtendo instância de segmento de detalhe [{tipoSegmento.ToString()}]");
			switch (tipoSegmento)
			{
			case EnumTipoSegmentoFebraban240.HEADER_ARQUIVO:
				if (segmentoDeRemessa)
				{
					segmentoFebraban = new HeaderArquivoRemessaFebraban240Ban033();
					return segmentoFebraban;
				}
				segmentoFebraban = new HeaderArquivoRetornoFebraban240Ban033();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.HEADER_LOTE:
				if (segmentoDeRemessa)
				{
					segmentoFebraban = new HeaderLoteRemessaFebraban240Ban033();
					return segmentoFebraban;
				}
				segmentoFebraban = new HeaderLoteRetornoFebraban240Ban033();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_P:
				segmentoFebraban = new SegmentoDetalhePFebraban240Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_Q:
				segmentoFebraban = new SegmentoDetalheQFebraban240Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_R:
				segmentoFebraban = new SegmentoDetalheRFebraban240Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_S_IMPRESSAO_TIPO_1_E_2:
				segmentoFebraban = new SegmentoDetalheSFebraban240ImpressaoTipo1e2Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_S_IMPRESSAO_TIPO_3:
				segmentoFebraban = new SegmentoDetalheSFebraban240ImpressaoTipo3Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_T:
				segmentoFebraban = new SegmentoDetalheTFebraban240Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_U:
				segmentoFebraban = new SegmentoDetalheUFebraban240Ban033(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.TRAILLER_LOTE:
				if (segmentoDeRemessa)
				{
					segmentoFebraban = new TraillerLoteRemessaFebraban240Ban033();
					return segmentoFebraban;
				}
				segmentoFebraban = new TraillerLoteRetornoFebraban240Ban033();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.TRAILLER_ARQUIVO:
				if (segmentoDeRemessa)
				{
					segmentoFebraban = new TraillerArquivoRemessaFebraban240Ban033();
					return segmentoFebraban;
				}
				segmentoFebraban = new TraillerArquivoRetornoFebraban240Ban033();
				return segmentoFebraban;
			default:
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_Y01:
			case EnumTipoSegmentoFebraban240.SEGMENTO_Y04:
			case EnumTipoSegmentoFebraban240.SEGMENTO_Y05:
			case EnumTipoSegmentoFebraban240.SEGMENTO_Y50:
			case EnumTipoSegmentoFebraban240.SEGMENTO_Y51:
				return segmentoFebraban;
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return segmentoFebraban;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoSegmentoDetalheFebraban240(tipoSegmento.ToString(), ex), new StackTrace().GetFrame(1).GetMethod());
			return segmentoFebraban;
		}
	}
}
