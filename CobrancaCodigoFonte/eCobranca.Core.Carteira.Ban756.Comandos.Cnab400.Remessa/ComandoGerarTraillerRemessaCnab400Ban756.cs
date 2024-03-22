using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban756 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban756()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Mensagem1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Mensagem2.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Mensagem3.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Mensagem4.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).Mensagem5.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban756).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
