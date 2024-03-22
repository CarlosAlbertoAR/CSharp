using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Retorno;

public class ComandoCarregarRegistroTipo1RetornoCnab400Ban136 : ComandoCarregarSegmentoDetalheRetornoCnab400
{
	public ComandoCarregarRegistroTipo1RetornoCnab400Ban136()
	{
		Logger.Debug($"Criando comando para processar o REGISTRO TIPO 1 do retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar REGISTRO TIPO 1 do retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
