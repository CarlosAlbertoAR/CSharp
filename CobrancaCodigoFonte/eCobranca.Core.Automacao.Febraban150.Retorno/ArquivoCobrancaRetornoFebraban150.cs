using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using eCobranca.Core.Automacao.Converter;
using eCobranca.Core.Automacao.Febraban150.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Factory;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban150.Retorno;

public class ArquivoCobrancaRetornoFebraban150 : ArquivoCobranca
{
	private HeaderArquivoFebraban150 headerArquivo;

	private IList<LoteCobrancaRetornoFebraban150> lotes;

	private TraillerArquivoFebraban150 traillerArquivo;

	private StreamReader retorno;

	private int totalRegistros;

	private ConverterDateToString dateToStringConverter;

	private ConverterDoubleToString doubleToStringConverter;

	private ConverterIntToString intToStringConverter;

	private ConverterTimeToString timeToStringConverter;

	private EnumCodigoBanco banco;

	protected string nomeArquivoRetorno;

	private FactorySegmentoFebraban150 factorySegmentoFebraban150;

	public FactorySegmentoFebraban150 FactorySegmentoFebraban150 => factorySegmentoFebraban150;

	public HeaderArquivoFebraban150 HeaderArquivo => headerArquivo;

	public TraillerArquivoFebraban150 TraillerArquivo => traillerArquivo;

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
			foreach (LoteCobrancaRetornoFebraban150 lote in lotes)
			{
				totalRegistros += lote.TotalRegistros;
			}
			return totalRegistros;
		}
	}

	public StreamReader Retorno => retorno;

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

	public IList<LoteCobrancaRetornoFebraban150> Lotes => lotes;

	public ArquivoCobrancaRetornoFebraban150(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
		: base(guid, tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando arquivo de cobrança de retorno FEBRABAN150...");
			factorySegmentoFebraban150 = FactorySegmentoFebraban150.GetInstance();
			headerArquivo = FactorySegmentoFebraban150.NovoSegmento(banco, EnumTipoSegmentoFebraban150.HEADER_ARQUIVO, 0L, 0L) as HeaderArquivoFebraban150;
			traillerArquivo = FactorySegmentoFebraban150.NovoSegmento(banco, EnumTipoSegmentoFebraban150.TRAILLER_ARQUIVO, 0L, 0L) as TraillerArquivoFebraban150;
			lotes = new List<LoteCobrancaRetornoFebraban150>();
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

	public LoteCobrancaRetornoFebraban150 NovoLote(ArrayList linhasLote)
	{
		if (lotes == null)
		{
			lotes = new List<LoteCobrancaRetornoFebraban150>();
		}
		LoteCobrancaRetornoFebraban150 loteCobrancaRetornoFebraban = new LoteCobrancaRetornoFebraban150();
		loteCobrancaRetornoFebraban.Preparar(banco, lotes.Count + 1, linhasLote);
		lotes.Add(loteCobrancaRetornoFebraban);
		return loteCobrancaRetornoFebraban;
	}

	public ArrayList CarregarArquivoRetornoFebraban150()
	{
		ArrayList arrayList = new ArrayList();
		try
		{
			if (TotalRegistros > 0)
			{
				Logger.Debug("Carregando arquivo de retorno...");
				OcorrenciaCobranca ocorrenciaCobranca = null;
				{
					foreach (LoteCobrancaRetornoFebraban150 lote in lotes)
					{
						foreach (SegmentoDetalheFebraban150 item in lote.SegmentosDetalhe)
						{
							if (item.CodigoRegistro.Valor == EnumTipoSegmentoFebraban150.SEGMENTO_DETALHE_G.Codigo())
							{
								ocorrenciaCobranca = new OcorrenciaCobranca();
								ocorrenciaCobranca.NumeroSequencialRetorno = (int)intToStringConverter.ConvertBack((headerArquivo as HeaderArquivoFebraban150Padrao).NumeroSequencialArquivo.Valor.Trim(), typeof(int), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.CodigoBanco = (headerArquivo as HeaderArquivoFebraban150Padrao).CodigoBanco.Valor.Trim();
								ocorrenciaCobranca.CodigoAgencia = (item as SegmentoDetalheGFebraban150Padrao).CodigoBarras.Valor.Trim().Substring(19, 4);
								ocorrenciaCobranca.NumeroContaCorrente = (item as SegmentoDetalheGFebraban150Padrao).IdentificacaoBeneficiarioNoBanco.Valor.Trim().Substring(3, 7);
								ocorrenciaCobranca.Nossonumero = (item as SegmentoDetalheGFebraban150Padrao).CodigoBarras.Valor.Trim().Substring(27, 16);
								ocorrenciaCobranca.ValorTarifa = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheGFebraban150Padrao).ValorTarifa.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.DataCredito = (DateTime?)dateToStringConverter.ConvertBack((item as SegmentoDetalheGFebraban150Padrao).DataCredito.Valor.Trim(), typeof(DateTime?), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorPago = (double)doubleToStringConverter.ConvertBack((item as SegmentoDetalheGFebraban150Padrao).ValorRecebido.Valor.Trim(), typeof(double), null, CultureInfo.CurrentCulture);
								ocorrenciaCobranca.ValorLiquido = (double)doubleToStringConverter.ConvertBack(ocorrenciaCobranca.ValorPago - ocorrenciaCobranca.ValorTarifa, typeof(double), null, CultureInfo.CurrentCulture);
								if (ocorrenciaCobranca.ValorPago > 0.0)
								{
									ocorrenciaCobranca.OcorreuPagamento = true;
								}
								else
								{
									ocorrenciaCobranca.OcorreuPagamento = false;
								}
							}
							if (!arrayList.Contains(ocorrenciaCobranca) && ocorrenciaCobranca != null)
							{
								arrayList.Add(ocorrenciaCobranca);
							}
						}
					}
					return arrayList;
				}
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return arrayList;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCarregandoArquivoRetornoFebraban150(ex), new StackTrace().GetFrame(1).GetMethod());
			return arrayList;
		}
	}

	public void Preparar(string diretorioArquivo, string nomeArquivo)
	{
		lotes.Clear();
		diretorio = diretorioArquivo;
		nomeArquivoRetorno = nomeArquivo;
		if (File.Exists(diretorio + nomeArquivoRetorno))
		{
			retorno = new StreamReader(diretorio + nomeArquivoRetorno);
		}
	}
}
