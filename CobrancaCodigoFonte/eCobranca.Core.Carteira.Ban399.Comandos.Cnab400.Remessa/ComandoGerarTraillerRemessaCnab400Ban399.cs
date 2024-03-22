using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban399 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban399()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban399).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban399).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban399).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
