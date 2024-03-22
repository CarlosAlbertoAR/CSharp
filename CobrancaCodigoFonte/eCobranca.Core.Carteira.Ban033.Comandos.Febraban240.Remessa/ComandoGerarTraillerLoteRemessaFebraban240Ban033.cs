using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerLoteRemessaFebraban240Ban033 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarTraillerLoteRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo();
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).UsoReservadoBanco1.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).QuantidadeRegistrosLote.Valor = base.Lote.TotalRegistros.ToString();
			(base.Lote.TraillerLote as TraillerLoteRemessaFebraban240Ban033).UsoReservadoBanco2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerLoteRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
