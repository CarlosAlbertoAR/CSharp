using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban136 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban136()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNICRED}]...");
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).CodigoBeneficiario.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).CodigoBanco.Valor = EnumCodigoBanco.UNICRED.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).NomeBanco.Valor = EnumCodigoBanco.UNICRED.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).Filler1.Valor = "";
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).CodigoVariacao.Valor = StringUtil.ZerosLeft(string.Empty, 4);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).NumeroSequencialArquivo.Valor = StringUtil.ZerosLeft((string)base.IntConverter.Convert(base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa + 1, typeof(int), null, CultureInfo.CurrentCulture), 7);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).Filler2.Valor = "";
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban136).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
