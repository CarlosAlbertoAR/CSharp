using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Cnab400.Remessa;

public class ComandoGerarTraillerRemessaCnab400Ban033 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarTraillerRemessaCnab400Ban033()
	{
		Logger.Debug($"Criando comando para gerar o TRAILLER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o TRAILLER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban033).CodigoRegistro.Valor = EnumTipoRegistroCnab400.TRAILLER.Codigo();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban033).QuantidadeTitulosArquivo.Valor = base.Arquivo.Lote.QuantidadeTotalTitulos.ToString();
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban033).ValorTotalTitulos.Valor = (string)base.DoubleConverter.Convert(base.Arquivo.Lote.ValorTotalTitulos, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban033).Filler1.Valor = "0";
			(base.Arquivo.Trailler as TraillerRemessaCnab400Ban033).NumeroSequenciaRegistro.Valor = base.Arquivo.Trailler.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarTraillerArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
