using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban133.Comandos.Cnab400.Retorno;

public class ComandoCarregarTraillerRetornoCnab400Ban133 : ComandoCarregarSegmentoArquivoRetornoCnab400
{
	public ComandoCarregarTraillerRetornoCnab400Ban133()
	{
		Logger.Debug($"Criando comando para processar o TRAILLER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o TRAILLER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
			base.Arquivo.Trailler.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.CRESOL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
