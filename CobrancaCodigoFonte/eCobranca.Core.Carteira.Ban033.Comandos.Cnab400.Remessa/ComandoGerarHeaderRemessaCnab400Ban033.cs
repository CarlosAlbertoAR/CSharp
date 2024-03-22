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

public class ComandoGerarHeaderRemessaCnab400Ban033 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban033()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).CodigoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).CodigoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).LiteralTransmissao.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).CodigoTransmissao.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).CodigoBanco.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).NomeBanco.Valor = EnumCodigoBanco.BANCO_SANTANDER.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Filler1.Valor = "0";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem4.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem5.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).Mensagem6.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).NumeroVersao.Valor = "001";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban033).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
