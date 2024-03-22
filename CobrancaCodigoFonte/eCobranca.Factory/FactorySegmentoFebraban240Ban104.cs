using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Factory;

public class FactorySegmentoFebraban240Ban104 : FactorySegmentoFebraban240
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
				segmentoFebraban = new HeaderArquivoFebraban240Padrao();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.HEADER_LOTE:
				segmentoFebraban = new HeaderLoteFebraban240Padrao();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_P:
				segmentoFebraban = new SegmentoDetalhePFebraban240Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_Q:
				segmentoFebraban = new SegmentoDetalheQFebraban240Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_R:
				segmentoFebraban = new SegmentoDetalheRFebraban240Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_S_IMPRESSAO_TIPO_1_E_2:
				segmentoFebraban = new SegmentoDetalheSFebraban240ImpressaoTipo1e2Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_S_IMPRESSAO_TIPO_3:
				segmentoFebraban = new SegmentoDetalheSFebraban240ImpressaoTipo3Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_T:
				segmentoFebraban = new SegmentoDetalheTFebraban240Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.SEGMENTO_U:
				segmentoFebraban = new SegmentoDetalheUFebraban240Padrao(0L, 0L);
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaLote = sequenciaLote;
				(segmentoFebraban as SegmentoDetalheFebraban240).SequenciaSegmento = sequenciaSegmento;
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.TRAILLER_LOTE:
				segmentoFebraban = new TraillerLoteFebraban240Ban104();
				return segmentoFebraban;
			case EnumTipoSegmentoFebraban240.TRAILLER_ARQUIVO:
				segmentoFebraban = new TraillerArquivoFebraban240Ban104();
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
