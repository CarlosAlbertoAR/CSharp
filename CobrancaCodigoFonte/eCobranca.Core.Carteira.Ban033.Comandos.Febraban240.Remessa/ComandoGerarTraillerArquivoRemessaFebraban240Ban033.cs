using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerArquivoRemessaFebraban240Ban033 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarTraillerArquivoRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).LoteServico.Valor = "9999";
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).UsoReservadoBanco1.Valor = "";
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).QuantidadeLotesArquivo.Valor = base.Arquivo.Lotes.Count.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).QuantidadeRegistrosArquivo.Valor = base.Arquivo.TotalRegistros.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoRemessaFebraban240Ban033).UsoReservadobanco2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
