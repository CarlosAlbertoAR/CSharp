using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public class SegmentoFebraban150 : ISegmentoFebraban150
{
	protected List<CampoLayoutArquivoCobranca> campos;

	public SegmentoFebraban150()
	{
		campos = new List<CampoLayoutArquivoCobranca>();
	}

	public virtual string GerarRegistro()
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			foreach (CampoLayoutArquivoCobranca campo in campos)
			{
				stringBuilder.Append(campo.GetValorFormatado());
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoSegmentoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return stringBuilder.ToString();
	}

	public virtual void CarregarRegistro(string linhaDados)
	{
		try
		{
			if (linhaDados.Length == 150)
			{
				foreach (CampoLayoutArquivoCobranca campo in campos)
				{
					campo.Valor = linhaDados.Substring(campo.PosicaoInicial - 1, campo.QuantidadeDigitos + campo.QuantidadeDecimais);
				}
				return;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.RegistroNaoAtendeAoLayoutFebraban240(), new StackTrace().GetFrame(1).GetMethod());
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaGerandoSegmentoFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public virtual string[] GerarManual()
	{
		Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.FuncionalidadeNaoImplementadaAinda("GerarManual"), new StackTrace().GetFrame(1).GetMethod());
		return null;
	}
}
