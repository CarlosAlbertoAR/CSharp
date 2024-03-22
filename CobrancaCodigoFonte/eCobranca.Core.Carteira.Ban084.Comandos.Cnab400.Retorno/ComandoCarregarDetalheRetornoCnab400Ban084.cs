using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Retorno;

public class ComandoCarregarDetalheRetornoCnab400Ban084 : ComandoCarregarSegmentoDetalheRetornoCnab400
{
	public ComandoCarregarDetalheRetornoCnab400Ban084()
	{
		Logger.Debug($"Criando comando para processar o TRANSAÇÃO TIPO 1 do retorno CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar DETALHE do retorno CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
