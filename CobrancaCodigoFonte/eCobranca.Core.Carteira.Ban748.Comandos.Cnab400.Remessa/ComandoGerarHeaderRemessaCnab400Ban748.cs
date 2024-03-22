using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban748 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).TipoOperacao.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).TipoOperacaoLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).TipoServicoLiteral.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).CodigoBeneficiario.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[2] as DadoConfiguracao).Valor);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).CodigoBanco.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).NomeBanco.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.AAAAMMDD, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).NumeroRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).Filler3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).VersaoSistema.Valor = "2.00";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
