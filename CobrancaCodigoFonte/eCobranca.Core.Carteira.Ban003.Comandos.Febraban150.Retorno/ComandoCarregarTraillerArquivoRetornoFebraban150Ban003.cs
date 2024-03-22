using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban150.Retorno;

public class ComandoCarregarTraillerArquivoRetornoFebraban150Ban003 : ComandoCarregarSegmentoArquivoRetornoFebraban150
{
	public ComandoCarregarTraillerArquivoRetornoFebraban150Ban003()
	{
		Logger.Debug($"Criando comando para carregar TRAILLER DE ARQUIVO do retorno FEBRABAN150 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar TRAILLER DE ARQUIVO do retorno FEBRABAN150 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
			base.Arquivo.TraillerArquivo.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoFebraban150(EnumCodigoBanco.BANCO_DA_AMAZONIA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
