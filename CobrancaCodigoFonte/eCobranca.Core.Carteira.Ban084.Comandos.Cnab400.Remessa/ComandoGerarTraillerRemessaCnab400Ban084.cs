using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban084 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban084()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban084).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban084).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban084).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
