using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Converter;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Dicionario;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Retorno;

public abstract class ArquivoCobrancaRetornoFebraban240 : ArquivoCobranca
{
	private CarteiraCobranca carteira;

	protected HeaderArquivoFebraban240 headerArquivo;

	protected IList<LoteCobrancaRetornoFebraban240> lotes;

	protected TraillerArquivoFebraban240 traillerArquivo;

	protected int totalRegistros;

	protected ConverterDateToString dateToStringConverter;

	protected ConverterDoubleToString doubleToStringConverter;

	protected ConverterIntToString intToStringConverter;

	protected ConverterTimeToString timeToStringConverter;

	protected EnumCodigoBanco banco;

	protected string nomeArquivoRetorno;

	public HeaderArquivoFebraban240 HeaderArquivo => headerArquivo;

	public TraillerArquivoFebraban240 TraillerArquivo => traillerArquivo;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (headerArquivo != null)
			{
				totalRegistros++;
			}
			if (traillerArquivo != null)
			{
				totalRegistros++;
			}
			if (lotes == null)
			{
				lotes = new List<LoteCobrancaRetornoFebraban240>();
			}
			foreach (LoteCobrancaRetornoFebraban240 lote in lotes)
			{
				totalRegistros += lote.TotalRegistros;
			}
			return totalRegistros;
		}
	}

	public string NomeArquivoRetorno
	{
		get
		{
			return nomeArquivoRetorno;
		}
		set
		{
			nomeArquivoRetorno = value;
		}
	}

	public CarteiraCobranca Carteira => carteira;

	public ArquivoCobrancaRetornoFebraban240(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
		: base(guid, tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando arquivo de cobrança de retorno FEBRABAN240...");
			lotes = new List<LoteCobrancaRetornoFebraban240>();
			this.banco = banco;
			dateToStringConverter = new ConverterDateToString(GetGuid(), EnumTipoData.DDMMAAAA);
			doubleToStringConverter = new ConverterDoubleToString(GetGuid());
			intToStringConverter = new ConverterIntToString(GetGuid());
			timeToStringConverter = new ConverterTimeToString(GetGuid());
			totalRegistros = 0;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoArquivoCobrancaRetornoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public LoteCobrancaRetornoFebraban240 NovoLote(ArrayList linhasLote)
	{
		if (lotes == null)
		{
			lotes = new List<LoteCobrancaRetornoFebraban240>();
		}
		LoteCobrancaRetornoFebraban240 loteCobrancaRetornoFebraban = new LoteCobrancaRetornoFebraban240(banco, tipoCarteiraCobranca);
		loteCobrancaRetornoFebraban.Preparar(carteira, lotes.Count + 1, linhasLote);
		lotes.Add(loteCobrancaRetornoFebraban);
		return loteCobrancaRetornoFebraban;
	}

	public abstract ArrayList CarregarArquivoRetornoFebraban240();

	public void Preparar(CarteiraCobranca carteira, string diretorioRetorno, string nomeArquivoRetorno)
	{
		if (lotes != null)
		{
			lotes.Clear();
		}
		this.carteira = carteira;
		diretorio = diretorioRetorno;
		this.nomeArquivoRetorno = nomeArquivoRetorno;
		headerArquivo = this.carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.HEADER_ARQUIVO, 0L, 0L, segmentoDeRemessa: false) as HeaderArquivoFebraban240;
		traillerArquivo = this.carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.TRAILLER_ARQUIVO, 0L, 0L, segmentoDeRemessa: false) as TraillerArquivoFebraban240;
	}

	protected ArrayList ObterMotivosOcorrencia(OcorrenciaCobranca ocorrencia, string motivos)
	{
		ArrayList arrayList = new ArrayList();
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		while (motivos.Length >= 2)
		{
			MotivoOcorrenciaCobranca motivoOcorrencia = RepositorioDetalhesOcorrencia.GetInstance().GetMotivoOcorrencia(DicionarioChaveByBancoLayoutCobranca.GetInstance().GetValor(new Tuple<EnumCodigoBanco, EnumLayoutCobranca>(banco, EnumLayoutCobranca.FEBRABAN240)), ocorrencia.CodigoMovimentoRetorno, motivos.Substring(0, 2));
			if (motivoOcorrencia != null && !dictionary.ContainsKey(motivoOcorrencia.Codigo))
			{
				dictionary.Add(motivoOcorrencia.Codigo, motivoOcorrencia.Descricao);
				arrayList.Add(motivoOcorrencia);
			}
			if (motivos.Length >= 2)
			{
				motivos = motivos.Substring(2);
			}
		}
		return arrayList;
	}
}
