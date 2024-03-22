using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Retorno;

public class ComandoCarregarTraillerLoteRetornoFebraban240Ban085 : ComandoCarregarSegmentoLoteRetornoFebraban240
{
	public ComandoCarregarTraillerLoteRetornoFebraban240Ban085()
	{
		Logger.Debug($"Criando comando para carregar TRAILLER DE LOTE do retorno FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o TRAILLER DE LOTE do retorno FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
			base.Lote.TraillerLote.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerLoteRetornoFebraban240(EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
