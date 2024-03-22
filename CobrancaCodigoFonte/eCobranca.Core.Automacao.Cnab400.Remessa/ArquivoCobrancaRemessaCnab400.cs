using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Patterns.Observer;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Remessa;

public abstract class ArquivoCobrancaRemessaCnab400 : ArquivoCobranca
{
	protected ArrayList remessa;

	protected HeaderRemessaCnab400 header;

	protected LoteCobrancaRemessaCnab400 lote;

	protected TraillerRemessaCnab400 trailler;

	private int totalRegistros;

	private ConfiguracaoArquivoRemessa configuracao;

	private bool geraHeader;

	private bool geraTrailler;

	public ConfiguracaoArquivoRemessa Configuracao => configuracao;

	public int TotalRegistros
	{
		get
		{
			totalRegistros = 0;
			if (GeraHeader)
			{
				totalRegistros++;
			}
			if (GeraTrailler)
			{
				totalRegistros++;
			}
			totalRegistros += Lote.TotalRegistros;
			return totalRegistros;
		}
	}

	public bool GeraHeader => geraHeader;

	public bool GeraTrailler => geraTrailler;

	public HeaderRemessaCnab400 Header => header;

	public TraillerRemessaCnab400 Trailler => trailler;

	public LoteCobrancaRemessaCnab400 Lote => lote;

	public ArquivoCobrancaRemessaCnab400(Guid guid, HeaderRemessaCnab400 header, TraillerRemessaCnab400 trailler, EnumTipoCarteiraCobranca tipoCarteiraCobranca)
		: base(guid, tipoCarteiraCobranca)
	{
		try
		{
			Logger.Debug("Criando arquivo de remessa no layout CNAB400 a partir de uma configuração de remessa...");
			lote = CarregarLote();
			padrao = EnumPadraoArquivoCobranca.CNAB400;
			tipo = EnumTipoArquivoCobranca.REMESSA;
			this.header = header;
			this.trailler = trailler;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoArquivoCobrancaRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public abstract LoteCobrancaRemessaCnab400 CarregarLote();

	public void CriarLote(ArrayList documentos, params bool[] parametros)
	{
		lote.Preparar(configuracao, documentos, parametros);
	}

	public string GerarArquivoRemessa()
	{
		string empty = string.Empty;
		try
		{
			Logger.Debug("Gerando arquivo de remessa no padrão CNAB400...");
			remessa = new ArrayList();
			if (GeraHeader)
			{
				remessa.Add(Header.GerarRegistro());
			}
			remessa.AddRange(Lote.CarregarRegistrosLote());
			if (GeraTrailler)
			{
				remessa.Add(Trailler.GerarRegistro());
			}
			nomeArquivoRemessa = base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_NOME_ARQUIVO_REMESSA, configuracao.ParametrosDisponiveis.Remessa.NomeArquivoRemessa(), configuracao.ParametrosAdicionais);
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
			if ((EnumCodificacaoArquivoRemessa)(object)base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CODIFICACAO_ARQUIVO_REMESSA, configuracao.ParametrosDisponiveis.Remessa.CodificacaoArquivoRemessa(), configuracao.ParametrosAdicionais).ToEnum<EnumCodificacaoArquivoRemessa>() == EnumCodificacaoArquivoRemessa.ANSI)
			{
				using TextWriter textWriter = new StreamWriter(diretorio + base.NomeArquivoRemessa, append: false, Encoding.GetEncoding(1250));
				foreach (string item in remessa)
				{
					textWriter.WriteLine(item);
				}
			}
			else
			{
				using StreamWriter streamWriter = File.CreateText(diretorio + base.NomeArquivoRemessa);
				foreach (string item2 in remessa)
				{
					streamWriter.WriteLine(item2);
				}
			}
			empty = nomeArquivoRemessa;
			return empty;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return empty;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return empty;
		}
	}

	public void Preparar(ConfiguracaoArquivoRemessa configuracao)
	{
		this.configuracao = configuracao;
		RefreshNotifyEventHandler();
		if (remessa != null)
		{
			remessa.Clear();
		}
		if (this.configuracao != null)
		{
			sequencia = configuracao.SequenciaRemessa;
			diretorio = configuracao.DiretorioArquivoRemessa;
			geraHeader = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_HEADER_REMESSA_CNAB400, Configuracao.ParametrosDisponiveis.Remessa.GeraHeaderRemessaCnab400(), Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
			geraTrailler = (base.ParameterUtil.GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_GERA_TRAILLER_REMESSA_CNAB400, Configuracao.ParametrosDisponiveis.Remessa.GeraTraillerRemessaCnab400(), Configuracao.ParametrosAdicionais).Equals("S") ? true : false);
		}
	}
}
