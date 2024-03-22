using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Retorno;

public class LoteCobrancaRetornoFebraban240
{
	private HeaderLoteFebraban240 headerLote;

	private TraillerLoteFebraban240 traillerLote;

	private IList<SegmentoDetalheFebraban240> segmentosDetalhe;

	private ArrayList linhasLote;

	private int totalRegistros;

	private long sequenciaLote;

	private EnumCodigoBanco banco;

	private EnumTipoCarteiraCobranca tipoCarteiraCobranca;

	public EnumTipoCarteiraCobranca TipoCarteiraCobranca => tipoCarteiraCobranca;

	public IList<SegmentoDetalheFebraban240> SegmentosDetalhe
	{
		get
		{
			if (segmentosDetalhe == null)
			{
				segmentosDetalhe = new List<SegmentoDetalheFebraban240>();
			}
			return segmentosDetalhe;
		}
	}

	public ArrayList LinhasLote => linhasLote;

	public long SequenciaLote => sequenciaLote;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (headerLote != null)
			{
				totalRegistros++;
			}
			if (traillerLote != null)
			{
				totalRegistros++;
			}
			if (segmentosDetalhe != null)
			{
				totalRegistros += segmentosDetalhe.Count;
			}
			return totalRegistros;
		}
	}

	public HeaderLoteFebraban240 HeaderLote => headerLote;

	public TraillerLoteFebraban240 TraillerLote => traillerLote;

	public LoteCobrancaRetornoFebraban240(EnumCodigoBanco banco, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando lote de cobrança de retorno FEBRABAN240...");
			this.tipoCarteiraCobranca = tipoCarteiraCobranca;
			this.banco = banco;
			segmentosDetalhe = new List<SegmentoDetalheFebraban240>();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoLoteCobrancaRetornoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public SegmentoDetalheFebraban240 AdicionarSegmento(SegmentoDetalheFebraban240 segmento)
	{
		if (segmentosDetalhe == null)
		{
			segmentosDetalhe = new List<SegmentoDetalheFebraban240>();
		}
		segmento.SequenciaLote = 1L;
		segmento.SequenciaSegmento = segmentosDetalhe.Count + 1;
		segmentosDetalhe.Add(segmento);
		return segmento;
	}

	public void Preparar(CarteiraCobranca carteira, long sequenciaLote, ArrayList linhasLote)
	{
		this.sequenciaLote = sequenciaLote;
		this.linhasLote = linhasLote;
		headerLote = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.HEADER_LOTE, sequenciaLote, 0L, segmentoDeRemessa: false) as HeaderLoteFebraban240;
		traillerLote = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.TRAILLER_LOTE, sequenciaLote, 0L, segmentoDeRemessa: false) as TraillerLoteFebraban240;
	}
}
