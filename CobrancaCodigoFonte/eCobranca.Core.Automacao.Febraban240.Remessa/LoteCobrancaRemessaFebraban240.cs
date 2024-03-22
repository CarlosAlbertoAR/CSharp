using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Remessa;

public class LoteCobrancaRemessaFebraban240
{
	private HeaderLoteFebraban240 headerLote;

	private TraillerLoteFebraban240 traillerLote;

	private IList<SegmentoDetalheFebraban240> segmentosDetalhe;

	private EnumCodigoBanco banco;

	private ArrayList documentos;

	private int totalRegistros;

	private long sequenciaLote;

	private bool geraHeaderLote;

	private bool geraTraillerLote;

	private bool geraSegmentoDetalheP;

	private bool geraSegmentoDetalheQ;

	private bool geraSegmentoDetalheR;

	private EnumTipoCarteiraCobranca tipoCarteiraCobranca;

	private bool enviaSegmentosAdicionaisOutrasInstrucoesRemessa;

	public EnumTipoCarteiraCobranca TipoCarteiraCobranca => tipoCarteiraCobranca;

	public bool GeraSegmentoDetalheR => geraSegmentoDetalheR;

	public bool GeraSegmentoDetalheQ => geraSegmentoDetalheQ;

	public bool GeraSegmentoDetalheP => geraSegmentoDetalheP;

	public IList<SegmentoDetalheFebraban240> SegmentosDetalhe => segmentosDetalhe;

	public ArrayList Documentos => documentos;

	public long SequenciaLote => sequenciaLote;

	public bool GeraHeaderLote => geraHeaderLote;

	public bool GeraTraillerLote
	{
		get
		{
			return geraTraillerLote;
		}
		set
		{
			geraTraillerLote = value;
		}
	}

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (geraHeaderLote)
			{
				totalRegistros++;
			}
			if (geraTraillerLote)
			{
				totalRegistros++;
			}
			totalRegistros += segmentosDetalhe.Count;
			return totalRegistros;
		}
	}

	public double ValorTotalRegistros
	{
		get
		{
			double num = 0.0;
			foreach (DocumentoCobranca documento in Documentos)
			{
				num += documento.ValorDocumento;
			}
			return num;
		}
	}

	public HeaderLoteFebraban240 HeaderLote => headerLote;

	public TraillerLoteFebraban240 TraillerLote => traillerLote;

	public bool EnviaSegmentosAdicionaisOutrasInstrucoesRemessa => enviaSegmentosAdicionaisOutrasInstrucoesRemessa;

	public LoteCobrancaRemessaFebraban240(EnumCodigoBanco banco, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando lote de cobrança do arquivo de remessa FEBRABAN240...");
			this.banco = banco;
			this.tipoCarteiraCobranca = tipoCarteiraCobranca;
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoLoteCobrancaRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public SegmentoDetalheFebraban240 AdicionarSegmento(SegmentoDetalheFebraban240 segmento)
	{
		if (segmentosDetalhe == null)
		{
			segmentosDetalhe = new List<SegmentoDetalheFebraban240>();
		}
		segmento.SequenciaLote = sequenciaLote;
		segmento.SequenciaSegmento = segmentosDetalhe.Count + 1;
		SegmentosDetalhe.Add(segmento);
		return segmento;
	}

	public void Preparar(CarteiraCobranca carteira, long sequenciaLote, ArrayList documentos, bool geraHeaderLote, bool geraSegmentoDetalheP, bool geraSegmentoDetalheQ, bool geraSegmentoDetalheR, bool geraTraillerLote)
	{
		this.sequenciaLote = sequenciaLote;
		this.documentos = documentos;
		this.geraHeaderLote = geraHeaderLote;
		this.geraTraillerLote = geraTraillerLote;
		this.geraSegmentoDetalheP = geraSegmentoDetalheP;
		this.geraSegmentoDetalheQ = geraSegmentoDetalheQ;
		this.geraSegmentoDetalheR = geraSegmentoDetalheR;
		headerLote = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.HEADER_LOTE, sequenciaLote, 0L, segmentoDeRemessa: true) as HeaderLoteFebraban240;
		traillerLote = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.TRAILLER_LOTE, sequenciaLote, 0L, segmentoDeRemessa: true) as TraillerLoteFebraban240;
		enviaSegmentosAdicionaisOutrasInstrucoesRemessa = (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_ENVIA_SEGMENTOS_ADICIONAIS_OUTRAS_INSTRUCOES_REMESSA, carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.EnviaSegmentosAdicionaisOutrasInstrucoesRemessa(), carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
	}

	public int ObterQuantidadeTitulosPorModalidadeCobranca(EnumModalidadeCarteiraCobranca modalidade)
	{
		int num = 0;
		foreach (DocumentoCobranca documento in documentos)
		{
			if (documento.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Equals(modalidade))
			{
				num++;
			}
		}
		return num;
	}

	public double ObterValorTotalTitulosPorModalidadeCobranca(EnumModalidadeCarteiraCobranca modalidade)
	{
		double num = 0.0;
		foreach (DocumentoCobranca documento in documentos)
		{
			if (documento.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Equals(modalidade))
			{
				num += documento.ValorDocumento;
			}
		}
		return num;
	}
}
