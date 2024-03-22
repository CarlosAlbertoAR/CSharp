using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerArquivoRemessaFebraban240Ban104 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarTraillerArquivoRemessaFebraban240Ban104()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).CodigoBancoCompensacao.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).LoteServico.Valor = "9999";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).UsoExclusivoFebraban1.Valor = "";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).QuantidadeLotesArquivo.Valor = base.Arquivo.Lotes.Count.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).QuantidadeRegistrosArquivo.Valor = base.Arquivo.TotalRegistros.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).UsoExclusivoFebraban2.Valor = "";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Ban104).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaFebraban240(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
