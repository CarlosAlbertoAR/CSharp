using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Retorno;

public class ComandoCarregarHeaderRetornoCnab400Ban084 : ComandoCarregarSegmentoArquivoRetornoCnab400
{
	public ComandoCarregarHeaderRetornoCnab400Ban084()
	{
		Logger.Debug($"Criando comando para processar o HEADER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o HEADER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
			base.Arquivo.Header.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarHeaderArquivoRetornoFebraban240(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
