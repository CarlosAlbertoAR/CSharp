using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Retorno;

public class ComandoCarregarHeaderLoteRetornoFebrabab240Ban104 : ComandoCarregarSegmentoLoteRetornoFebraban240
{
	public ComandoCarregarHeaderLoteRetornoFebrabab240Ban104()
	{
		Logger.Debug($"Criando comando para carregar HEADER DE LOTE de arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para carregar HEADER DE LOTE de arquivo de retorno FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoCarregarHeaderLoteRetornoFebraban240(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
