using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura;

public abstract class SegmentoCnab400 : ISegmentoCnab400
{
	protected List<CampoLayoutArquivoCobranca> campos;

	protected long sequencia;

	protected Guid guid;

	public List<CampoLayoutArquivoCobranca> Campos => campos;

	public long Sequencia
	{
		get
		{
			return sequencia;
		}
		set
		{
			sequencia = value;
		}
	}

	public SegmentoCnab400()
	{
		CarregarCampos();
	}

	public SegmentoCnab400(long sequenciaSegmento)
		: this()
	{
		sequencia = sequenciaSegmento;
	}

	public string GerarRegistro()
	{
		string text = "";
		try
		{
			Logger.Debug("Gerando registro HEADER DE ARQUIVO de remessa no layout CNAB400...");
			foreach (CampoLayoutArquivoCobranca campo in Campos)
			{
				text += campo.GetValorFormatado();
			}
			return text;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return text;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoRegistroHeaderArquivoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			return text;
		}
	}

	public void CarregarRegistro(string linhaDados)
	{
		try
		{
			if (linhaDados.Length == 400)
			{
				Logger.Debug($"Carregando [{GetType().Name}] a partir do retorno...");
				{
					foreach (CampoLayoutArquivoCobranca campo in Campos)
					{
						campo.Valor = linhaDados.Substring(campo.PosicaoInicial - 1, campo.QuantidadeDigitos + campo.QuantidadeDecimais);
					}
					return;
				}
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.RegistroHeaderArquivoRemessaNaoAtendeAoPadraoCnab400(), new StackTrace().GetFrame(1).GetMethod());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaCarregandoRegistroSegmentoCnab400(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public string[] GerarManual()
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FuncionalidadeNaoImplementadaAinda("GerarManual"), new StackTrace().GetFrame(1).GetMethod());
		return null;
	}

	protected abstract void CarregarCampos();
}
