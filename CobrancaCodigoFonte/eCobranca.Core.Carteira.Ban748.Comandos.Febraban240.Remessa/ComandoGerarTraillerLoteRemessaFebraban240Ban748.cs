using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerLoteRemessaFebraban240Ban748 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarTraillerLoteRemessaFebraban240Ban748()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Codigo();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).QuantidadeRegistrosLote.Valor = base.Lote.TotalRegistros.ToString();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).QuantidadeTitulosCobrancaSimples.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).ValorTotalTitulosCobrancaSimples.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).QuantidadeTitulosCobrancaVinculada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).ValorTotalTitulosCobrancaVinculada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).QuantidadeTitulosCobrancaCaucionada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).ValorTotalTitulosCobrancaCaucionada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).QuantidadeTitulosCobrancaDescontada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).ValorTotalTitulosCobrancaDescontada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).NumeroAvisoLancamento.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerLoteRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
