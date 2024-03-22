using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban097 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban097()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).TipoArquivo.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).TipoArquivoLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).TipoServicoLiteral.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).DigitoContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).Filler3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).NomeBanco.Valor = EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Codigo() + EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).SequencialRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).Filler4.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban097).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
