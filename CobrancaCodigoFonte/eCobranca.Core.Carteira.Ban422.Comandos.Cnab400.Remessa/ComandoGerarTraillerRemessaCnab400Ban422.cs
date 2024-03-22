using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban422 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban422()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).Filler1.Valor = StringUtil.ObterStringComBrancos(367);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).QuantidadeTitulos.Valor = base.Arquivo.Lote.QuantidadeTotalTitulos.ToString();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).ValorTotalTitulos.Valor = (string)base.DoubleConverter.Convert(base.Arquivo.Lote.ValorTotalTitulos, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).NumeroSequencialRemessa.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban422).NumeroSequencialRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
