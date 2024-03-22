using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Automacao.Converter;
using eCobranca.Core.Excecao;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public abstract class ArquivoCobrancaRetornoCnab400 : ArquivoCobranca
{
	protected HeaderRetornoCnab400 header;

	private LoteCobrancaRetornoCnab400 lote;

	protected TraillerRetornoCnab400 trailler;

	[NonSerialized]
	private int totalRegistros;

	protected ConverterDateToString dateToStringConverter;

	protected ConverterDoubleToString doubleToStringConverter;

	protected ConverterIntToString intToStringConverter;

	protected ConverterTimeToString timeToStringConverter;

	[NonSerialized]
	protected string nomeArquivoRetorno;

	public HeaderRetornoCnab400 Header => header;

	public TraillerRetornoCnab400 Trailler => trailler;

	public LoteCobrancaRetornoCnab400 Lote => lote;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (header != null)
			{
				totalRegistros++;
			}
			if (trailler != null)
			{
				totalRegistros++;
			}
			totalRegistros += lote.TotalRegistros;
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

	public ArquivoCobrancaRetornoCnab400(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		try
		{
			lote = new LoteCobrancaRetornoCnab400();
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoArquivoCobrancaRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public abstract ArrayList CarregarArquivoRetornoCnab400();

	public LoteCobrancaRetornoCnab400 NovoLote(List<string> linhasLote)
	{
		lote.Preparar(GetGuid(), linhasLote);
		return lote;
	}

	public void Preparar(string diretorioArquivo, string nomeArquivo)
	{
		diretorio = diretorioArquivo;
		nomeArquivoRetorno = nomeArquivo;
	}
}
