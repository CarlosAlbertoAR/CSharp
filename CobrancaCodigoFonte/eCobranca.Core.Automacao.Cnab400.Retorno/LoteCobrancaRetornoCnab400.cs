using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Factory;

namespace eCobranca.Core.Automacao.Cnab400.Retorno;

public class LoteCobrancaRetornoCnab400
{
	[NonSerialized]
	protected IList<DetalheRetornoCnab400> segmentosDetalhe;

	[NonSerialized]
	private IList<string> linhasLote;

	[NonSerialized]
	private int totalRegistros;

	protected Guid guid;

	public IList<DetalheRetornoCnab400> SegmentosDetalhe
	{
		get
		{
			if (segmentosDetalhe == null)
			{
				segmentosDetalhe = new List<DetalheRetornoCnab400>();
			}
			return segmentosDetalhe;
		}
	}

	public IList<string> LinhasLote => linhasLote;

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

	public LoteCobrancaRetornoCnab400()
	{
		try
		{
			Logger.Debug("Criando lote de cobrança de retorno CNAB400...");
			segmentosDetalhe = new List<DetalheRetornoCnab400>();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoLoteCobrancaRetornoCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public DetalheRetornoCnab400 NovoSegmentoDetalhe<T>(string valorEnumerado) where T : struct
	{
		DetalheRetornoCnab400 detalheRetornoCnab = null;
		try
		{
			Logger.Debug("Criando novo segmento de detalhe no arquivo de lote...");
			if (segmentosDetalhe == null)
			{
				segmentosDetalhe = new List<DetalheRetornoCnab400>();
			}
			if (typeof(T).IsEnum)
			{
				if (Enum.IsDefined(typeof(T), valorEnumerado))
				{
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban001)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban001.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban001)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban033)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban033.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban033)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban041)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban041.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban041)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban104)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban104.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban104)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban237)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban237.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban237)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban341)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban341.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban341)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban399)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban399.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban399)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban748)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban748.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban748)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					if (((T)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true)) is EnumTipoSegmentoDetalheCnab400Ban756)
					{
						detalheRetornoCnab = FactorySegmentoDetalheCnab400Ban756.NovoSegmentoDetalheRetorno((EnumTipoSegmentoDetalheCnab400Ban756)Enum.Parse(typeof(T), valorEnumerado, ignoreCase: true));
						segmentosDetalhe.Add(detalheRetornoCnab);
						return detalheRetornoCnab;
					}
					return detalheRetornoCnab;
				}
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInformadoDeEnumeradoInvalido(valorEnumerado, typeof(T).Name), new StackTrace().GetFrame(1).GetMethod());
				return detalheRetornoCnab;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorInformadoNaoEEnumeradoValido(typeof(T).Name), new StackTrace().GetFrame(1).GetMethod());
			return detalheRetornoCnab;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return detalheRetornoCnab;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCriandoNovoSegmentoDetalheRemessaCnab400(ex), new StackTrace().GetFrame(1).GetMethod());
			return detalheRetornoCnab;
		}
	}

	public DetalheRetornoCnab400 AdicionarSegmento(DetalheRetornoCnab400 segmento)
	{
		if (segmentosDetalhe == null)
		{
			segmentosDetalhe = new List<DetalheRetornoCnab400>();
		}
		SegmentosDetalhe.Add(segmento);
		return segmento;
	}

	public virtual void Preparar(Guid guid, List<string> linhasLote)
	{
		this.guid = guid;
		this.linhasLote = linhasLote;
		if (segmentosDetalhe != null)
		{
			segmentosDetalhe.Clear();
		}
	}
}
