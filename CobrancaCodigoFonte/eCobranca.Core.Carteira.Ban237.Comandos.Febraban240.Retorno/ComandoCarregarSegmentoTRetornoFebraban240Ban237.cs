using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Retorno;

public class ComandoCarregarSegmentoTRetornoFebraban240Ban237 : ComandoCarregarSegmentoDetalheRetornoFebraban240
{
	public ComandoCarregarSegmentoTRetornoFebraban240Ban237()
	{
		Logger.Debug("Criando comando para carregar SEGMENTO T do arquivo de retorno FEBRABAN240 da carteira de cobrança BAN001_17_7...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o SEGMENTO T do arquivo de retorno FEBRABAN240 da carteira do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarSegmentoDetalheRetornoCNAB400(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
