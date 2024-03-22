using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarTraillerLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o TRAILLER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler1.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_LOTE.Codigo();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler2.Valor = "";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).QuantidadeRegistrosLote.Valor = base.Lote.TotalRegistros.ToString();
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).ValorTitulosLote.Valor = (string)base.DoubleConverter.Convert(base.Lote.ValorTotalRegistros, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler3.Valor = "0";
			(base.Lote.TraillerLote as TraillerLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler4.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerLoteRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
