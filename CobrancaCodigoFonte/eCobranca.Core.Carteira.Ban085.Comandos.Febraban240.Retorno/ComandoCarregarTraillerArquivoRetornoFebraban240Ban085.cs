using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Retorno;

public class ComandoCarregarTraillerArquivoRetornoFebraban240Ban085 : ComandoCarregarSegmentoArquivoRetornoFebraban240
{
	public ComandoCarregarTraillerArquivoRetornoFebraban240Ban085()
	{
		Logger.Debug($"Criando comando para carregar TRAILLER DE ARQUIVO do retorno FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar TRAILLER DE ARQUIVO do retorno FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoFebraban240(EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
