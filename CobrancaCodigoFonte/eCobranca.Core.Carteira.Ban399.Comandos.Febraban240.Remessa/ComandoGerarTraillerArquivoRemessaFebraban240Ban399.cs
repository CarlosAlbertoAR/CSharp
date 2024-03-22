using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Febraban240.Remessa;

public class ComandoGerarTraillerArquivoRemessaFebraban240Ban399 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarTraillerArquivoRemessaFebraban240Ban399()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).LoteServico.Valor = "9999";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.TRAILLER_DE_ARQUIVO.Codigo();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).QuantidadeLotesArquivo.Valor = base.Arquivo.Lotes.Count.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).QuantidadeRegistrosArquivo.Valor = base.Arquivo.TotalRegistros.ToString();
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).QuantidadeContasConciliacao.Valor = "0";
			(base.Arquivo.TraillerArquivo as TraillerArquivoFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaFebraban240(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
