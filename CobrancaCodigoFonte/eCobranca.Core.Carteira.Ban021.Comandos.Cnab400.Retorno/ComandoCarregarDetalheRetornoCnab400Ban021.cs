using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban021.Comandos.Cnab400.Retorno;

public class ComandoCarregarDetalheRetornoCnab400Ban021 : ComandoCarregarSegmentoDetalheRetornoCnab400
{
	public ComandoCarregarDetalheRetornoCnab400Ban021()
	{
		Logger.Debug($"Criando comando para processar o TRANSAÇÃO TIPO 1 do retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar DETALHE do retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarTraillerArquivoRetornoCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
