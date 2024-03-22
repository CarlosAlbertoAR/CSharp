using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban150.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Factory;

namespace eCobranca.Core.Automacao.Febraban150.Retorno;

public class LoteCobrancaRetornoFebraban150
{
	private IList<SegmentoDetalheFebraban150> segmentosDetalhe;

	private ArrayList linhasLote;

	private int totalRegistros;

	private long sequenciaLote;

	private EnumCodigoBanco banco;

	private FactorySegmentoFebraban150 factorySegmentoFebraban150;

	public FactorySegmentoFebraban150 FactorySegmentoFebraban150 => factorySegmentoFebraban150;

	public IList<SegmentoDetalheFebraban150> SegmentosDetalhe => segmentosDetalhe;

	public ArrayList LinhasLote => linhasLote;

	public long SequenciaLote => sequenciaLote;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (segmentosDetalhe != null)
			{
				totalRegistros += segmentosDetalhe.Count;
			}
			return totalRegistros;
		}
	}

	public LoteCobrancaRetornoFebraban150()
	{
		try
		{
			Logger.Debug("Criando lote de cobrança de retorno FEBRABAN150...");
			factorySegmentoFebraban150 = FactorySegmentoFebraban150.GetInstance();
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

	public SegmentoDetalheFebraban150 AdicionarSegmentoDetalhe(SegmentoDetalheFebraban150 segmento)
	{
		Logger.Debug("Adicionado segmento de detalhe de retorno FEBRABAN150...");
		if (segmentosDetalhe == null)
		{
			segmentosDetalhe = new List<SegmentoDetalheFebraban150>();
		}
		segmento.SequenciaLote = sequenciaLote;
		segmento.SequenciaSegmento = segmentosDetalhe.Count + 1;
		segmentosDetalhe.Add(segmento);
		return segmento;
	}

	public void Preparar(EnumCodigoBanco banco, long sequenciaLote, ArrayList linhasLote)
	{
		this.sequenciaLote = sequenciaLote;
		this.linhasLote = linhasLote;
		this.banco = banco;
	}
}
