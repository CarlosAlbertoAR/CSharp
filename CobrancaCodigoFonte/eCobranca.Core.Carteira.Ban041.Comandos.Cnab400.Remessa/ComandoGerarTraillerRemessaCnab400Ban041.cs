using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban041 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban041).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban041).Filler1.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban041).TotalGeralTitulos.Valor = (string)base.DoubleConverter.Convert(base.Arquivo.Lote.ValorTotalTitulos, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban041).Filler2.Valor = "";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban041).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
