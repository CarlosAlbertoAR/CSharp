using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban341 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban341).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban341).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban341).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_ITAU, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
