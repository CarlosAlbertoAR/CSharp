using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban099.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban099 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban099()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban099).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban099).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban099).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
