using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Cnab400.Retorno;

public class ComandoCarregarHeaderRetornoCnab400Ban033 : ComandoCarregarSegmentoArquivoRetornoCnab400
{
	public ComandoCarregarHeaderRetornoCnab400Ban033()
	{
		Logger.Debug($"Criando comando para processar o HEADER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o HEADER DE ARQUIVO do retorno CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarHeaderArquivoRetornoFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
