using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban748 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).TipoMovimento.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).CodigoBanco.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).CodigoBeneficiario.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[2] as DadoConfiguracao).Valor);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
