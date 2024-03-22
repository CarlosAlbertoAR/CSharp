using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Remessa;

public class ArquivoCobrancaRemessaFebraban240 : ArquivoCobranca
{
	private CarteiraCobranca carteira;

	private ArrayList remessa;

	private HeaderArquivoFebraban240 headerArquivo;

	private IList<LoteCobrancaRemessaFebraban240> lotes;

	private TraillerArquivoFebraban240 traillerArquivo;

	private int totalRegistros;

	private EnumCodigoBanco banco;

	private bool geraHeaderArquivo;

	private bool geraTraillerArquivo;

	private bool geraHeaderLote;

	private bool geraSegmentoDetalheP;

	private bool geraSegmentoDetalheQ;

	private bool geraSegmentoDetalheR;

	private bool geraTraillerLote;

	public CarteiraCobranca Carteira => carteira;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (GeraHeaderArquivo)
			{
				totalRegistros++;
			}
			if (GeraTraillerArquivo)
			{
				totalRegistros++;
			}
			foreach (LoteCobrancaRemessaFebraban240 lote in lotes)
			{
				totalRegistros += lote.TotalRegistros;
			}
			return totalRegistros;
		}
	}

	public IList<LoteCobrancaRemessaFebraban240> Lotes => lotes;

	public HeaderArquivoFebraban240 HeaderArquivo => headerArquivo;

	public TraillerArquivoFebraban240 TraillerArquivo => traillerArquivo;

	public bool GeraSegmentoDetalheR => geraSegmentoDetalheR;

	public bool GeraSegmentoDetalheQ => geraSegmentoDetalheQ;

	public bool GeraSegmentoDetalheP => geraSegmentoDetalheP;

	public bool GeraTraillerLote => geraTraillerLote;

	public bool GeraHeaderLote => geraHeaderLote;

	public bool GeraTraillerArquivo => geraTraillerArquivo;

	public bool GeraHeaderArquivo => geraHeaderArquivo;

	public ArquivoCobrancaRemessaFebraban240(Guid guid, EnumTipoCarteiraCobranca tipoCarteiraCobranca, EnumCodigoBanco banco)
		: base(guid, tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando arquivo de remessa no layout FEBRABAN240 a partir de uma configuração de remessa...");
			this.banco = banco;
			padrao = EnumPadraoArquivoCobranca.FEBRABAN240;
			tipo = EnumTipoArquivoCobranca.REMESSA;
			base.tipoCarteiraCobranca = tipoCarteiraCobranca;
			lotes = new List<LoteCobrancaRemessaFebraban240>();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoArquivoCobrancaRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public LoteCobrancaRemessaFebraban240 NovoLote(ArrayList documentos)
	{
		LoteCobrancaRemessaFebraban240 loteCobrancaRemessaFebraban = null;
		try
		{
			Logger.Debug("Criando novo lote no arquivo de remessa FEBRABAN240...");
			if (lotes == null)
			{
				lotes = new List<LoteCobrancaRemessaFebraban240>();
			}
			loteCobrancaRemessaFebraban = new LoteCobrancaRemessaFebraban240(banco, tipoCarteiraCobranca);
			loteCobrancaRemessaFebraban.Preparar(carteira, lotes.Count + 1, documentos, geraHeaderLote, geraSegmentoDetalheP, geraSegmentoDetalheQ, geraSegmentoDetalheR, geraTraillerLote);
			lotes.Add(loteCobrancaRemessaFebraban);
			return loteCobrancaRemessaFebraban;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return loteCobrancaRemessaFebraban;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoNovoLoteRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return loteCobrancaRemessaFebraban;
		}
	}

	public void Preparar(CarteiraCobranca carteira)
	{
		this.carteira = carteira;
		headerArquivo = null;
		lotes = new List<LoteCobrancaRemessaFebraban240>();
		traillerArquivo = null;
		RefreshNotifyEventHandler();
		if (this.carteira.ConfiguracaoArquivoRemessa != null)
		{
			sequencia = carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa;
			diretorio = carteira.ConfiguracaoArquivoRemessa.DiretorioArquivoRemessa;
			headerArquivo = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.HEADER_ARQUIVO, 1L, 1L, segmentoDeRemessa: true) as HeaderArquivoFebraban240;
			traillerArquivo = carteira.FactorySegmentoFebraban240.NovoSegmento(EnumTipoSegmentoFebraban240.TRAILLER_ARQUIVO, 1L, 1L, segmentoDeRemessa: true) as TraillerArquivoFebraban240;
			geraHeaderArquivo = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_ARQUIVO_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraHeaderArquivoFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraHeaderLote = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_LOTE_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraHeaderLoteFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheP = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_P_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraSegmentoDetalhePFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheQ = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_Q_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraSegmentoDetalheQFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraSegmentoDetalheR = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_SEGMENTO_DETALHE_R_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraSegmentoDetalheRFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraTraillerLote = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_LOTE_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraTraillerLoteFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			geraTraillerArquivo = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_ARQUIVO_REMESSA_FEBRABAN240, this.carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.GeraTraillerArquivoFebraban240(), this.carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false);
			if (tipoCarteiraCobranca == EnumTipoCarteiraCobranca.BAN756_CARTEIRA_17_CORRESPONDENTE_BANCO_BRASIL)
			{
				geraHeaderArquivo = false;
				geraTraillerArquivo = false;
			}
		}
	}

	public string GerarArquivoRemessa()
	{
		string empty = string.Empty;
		try
		{
			Logger.Debug("Gerando arquivo de remessa no padrão FEBRABAN240...");
			remessa = new ArrayList();
			if (GeraHeaderArquivo)
			{
				remessa.Add(headerArquivo.GerarRegistro());
			}
			foreach (LoteCobrancaRemessaFebraban240 lote in Lotes)
			{
				if (GeraHeaderLote)
				{
					remessa.Add(lote.HeaderLote.GerarRegistro());
				}
				foreach (SegmentoDetalheFebraban240 item in lote.SegmentosDetalhe)
				{
					if (item is SegmentoDetalhePFebraban240)
					{
						if (GeraSegmentoDetalheP)
						{
							remessa.Add(item.GerarRegistro());
						}
					}
					else if (item is SegmentoDetalheQFebraban240)
					{
						if (GeraSegmentoDetalheQ)
						{
							remessa.Add(item.GerarRegistro());
						}
					}
					else if (item is SegmentoDetalheRFebraban240 && GeraSegmentoDetalheR)
					{
						remessa.Add(item.GerarRegistro());
					}
				}
				if (GeraTraillerLote)
				{
					remessa.Add(lote.TraillerLote.GerarRegistro());
				}
			}
			if (GeraTraillerArquivo)
			{
				remessa.Add(traillerArquivo.GerarRegistro());
			}
			nomeArquivoRemessa = base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_NOME_ARQUIVO_REMESSA, carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.NomeArquivoRemessa(), carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (string.IsNullOrEmpty(base.NomeArquivoRemessa))
			{
				NotifyEventInterceptor.GetInstance().AddObserver(this);
				TriggerNotifyEvent(this, new NotifyEvent(GetGuid(), EnumTipoNotificacao.GET_NOME_ARQUIVO_REMESSA));
				NotifyEventInterceptor.GetInstance().RemoveObserver(this);
			}
			if (string.IsNullOrEmpty(base.NomeArquivoRemessa))
			{
				throw ExcecaoECobranca.Remessa.NomeDoArquivoDeRemessaNuloOuVazio();
			}
			if (string.IsNullOrEmpty(diretorio))
			{
				throw ExcecaoECobranca.Remessa.DiretorioArquivoRemessaNuloOuVazio();
			}
			if ((EnumCodificacaoArquivoRemessa)(object)base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CODIFICACAO_ARQUIVO_REMESSA, carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.CodificacaoArquivoRemessa(), carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).ToEnum<EnumCodificacaoArquivoRemessa>() == EnumCodificacaoArquivoRemessa.ANSI)
			{
				Directory.CreateDirectory(diretorio);
				using TextWriter textWriter = new StreamWriter(diretorio + base.NomeArquivoRemessa, append: false, Encoding.GetEncoding(1250));
				foreach (string item2 in remessa)
				{
					textWriter.WriteLine(item2);
				}
			}
			else
			{
				Directory.CreateDirectory(diretorio);
				using StreamWriter streamWriter = File.CreateText(diretorio + base.NomeArquivoRemessa);
				foreach (string item3 in remessa)
				{
					streamWriter.WriteLine(item3);
				}
			}
			empty = base.NomeArquivoRemessa;
			return empty;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoRemessaFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
			return empty;
		}
	}
}
