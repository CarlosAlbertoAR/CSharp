using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Retorno;

public class ComandoCarregarSegmentoURetornoFebraban240Ban237 : ComandoCarregarSegmentoDetalheRetornoFebraban240
{
	public ComandoCarregarSegmentoURetornoFebraban240Ban237()
	{
		Logger.Debug($"Criando comando para carregar o SEGMENTO U do arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando do SEGMENTO U do arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			base.Segmento.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarSegmentoURetornoFebraban240(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
