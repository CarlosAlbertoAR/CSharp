using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerLoteRemessaFebraban240Ban104 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarTraillerLoteRemessaFebraban240Ban104()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).CodigoBancoCompensacao.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).UsoExclusivoFebraban1.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).QuantidadeRegistrosLote.Valor = base.Lote.TotalRegistros.ToString();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).QuantidadeTitulosCobrancaSimples.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).ValorTotalTitulosCobrancaSimples.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).QuantidadeTitulosCobrancaCaucionada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).ValorTotalTitulosCobrancaCaucionada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).QuantidadeTitulosCobrancaDescontada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).ValorTotalTitulosCobrancaDescontada.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).UsoExclusivoFebraban2.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban104).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerLoteRemessaFebraban240(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
