using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Carteira;
using eCobranca.Core.Excecao;
using eCobranca.Core.Modelo;
using eCobranca.Core.Patterns.Command;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Comando;

public class ComandoImprimirBoletos : ICommand
{
	private List<string> filaImpressao;

	private CarteiraCobranca carteira;

	private ArrayList dadosImpressao;

	private ModeloBoleto modeloBoleto;

	public void Execute()
	{
		try
		{
			if (!carteira.ConfiguracaoImpressao.ImpressaoAtiva || !carteira.ConfiguracaoImpressao.ImpressoraValida)
			{
				return;
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoImpressao.ModoImpressao))
			{
				if (!carteira.ConfiguracaoImpressao.ModoImpressao.ExisteNaEnum<EnumModoImpressao>())
				{
					return;
				}
				switch ((EnumModoImpressao)(object)carteira.ConfiguracaoImpressao.ModoImpressao.ToEnum<EnumModoImpressao>())
				{
				case EnumModoImpressao.IMPRESSAO_COM_PREVIEW:
				{
					foreach (string item in filaImpressao)
					{
						Process.Start(item);
					}
					break;
				}
				case EnumModoImpressao.IMPRESSAO_SEM_PREVIEW:
					PrintUtil.ImprimirDocumentoFastReport(modeloBoleto, dadosImpressao, carteira.ConfiguracaoImpressao);
					break;
				}
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.ValorNuloInformadoParaPropriedade("ModoImpressao", new ArgumentException()), new StackTrace().GetFrame(1).GetMethod());
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoBoletos(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	public void Preparar(CarteiraCobranca carteira, List<string> filaImpressao, ArrayList dadosImpressao, ModeloBoleto modelo)
	{
		this.carteira = carteira;
		this.filaImpressao = filaImpressao;
		this.dadosImpressao = dadosImpressao;
		modeloBoleto = modelo;
	}
}
