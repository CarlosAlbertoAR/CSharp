using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Retorno;

public class ComandoCarregarRegistroDetalheTipo1RemessaCnab400Ban399 : ComandoCarregarSegmentoDetalheRetornoCnab400
{
	public ComandoCarregarRegistroDetalheTipo1RemessaCnab400Ban399()
	{
		Logger.Debug($"Criando comando para processar o SEGMENTO DE DETALHE do retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar o DETALHE do retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
