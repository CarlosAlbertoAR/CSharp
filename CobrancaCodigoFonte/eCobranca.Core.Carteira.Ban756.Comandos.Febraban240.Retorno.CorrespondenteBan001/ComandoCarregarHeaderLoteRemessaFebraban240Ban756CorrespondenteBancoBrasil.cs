using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno.CorrespondenteBan001;

public class ComandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil : ComandoCarregarSegmentoLoteRetornoFebraban240
{
	public ComandoCarregarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil()
	{
		Logger.Debug($"Criando comando para carregar HEADER DE LOTE de arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar HEADER DE LOTE de arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			base.Lote.HeaderLote.CarregarRegistro(base.LinhaDadosRetorno);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarHeaderLoteRetornoFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
