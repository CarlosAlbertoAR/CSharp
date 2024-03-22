using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public abstract class LoteCobrancaRemessaCnab400
{
	[NonSerialized]
	protected IList<SegmentoCnab400> segmentos;

	[NonSerialized]
	protected ConfiguracaoArquivoRemessa configuracao;

	[NonSerialized]
	private ArrayList documentos;

	[NonSerialized]
	private int totalRegistros;

	private ParameterUtil parameterUtil;

	public ParameterUtil ParameterUtil => parameterUtil;

	public ConfiguracaoArquivoRemessa Configuracao => configuracao;

	public IList<SegmentoCnab400> Segmentos => segmentos;

	public ArrayList Documentos => documentos;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			totalRegistros += segmentos.Count;
			return totalRegistros;
		}
	}

	public int QuantidadeTotalTitulos => documentos.Count;

	public double ValorTotalTitulos
	{
		get
		{
			double num = 0.0;
			foreach (DocumentoCobranca documento in documentos)
			{
				num += documento.ValorDocumento;
			}
			return num;
		}
	}

	public LoteCobrancaRemessaCnab400()
	{
		try
		{
			parameterUtil = ParameterUtil.GetInstance();
			segmentos = new List<SegmentoCnab400>();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoLoteCobrancaRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public abstract ArrayList CarregarRegistrosLote();

	public SegmentoCnab400 AdicionarSegmento(SegmentoCnab400 segmento)
	{
		try
		{
			Logger.Debug("Criando novo segmento de detalhe no arquivo de lote...");
			if (segmentos == null)
			{
				segmentos = new List<SegmentoCnab400>();
			}
			segmento.Sequencia = segmentos.Count + 2;
			if (!segmentos.Contains(segmento))
			{
				segmentos.Add(segmento);
				return segmento;
			}
			return segmento;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return segmento;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoNovoSegmentoDetalheRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return segmento;
		}
	}

	public virtual void Preparar(ConfiguracaoArquivoRemessa configuracaoRemessa, ArrayList documentos, params bool[] parametros)
	{
		configuracao = configuracaoRemessa;
		this.documentos = documentos;
		if (segmentos != null)
		{
			segmentos.Clear();
		}
	}
}
