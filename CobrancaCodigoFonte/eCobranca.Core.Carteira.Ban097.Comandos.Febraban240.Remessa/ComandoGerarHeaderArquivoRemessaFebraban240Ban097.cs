using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderArquivoRemessaFebraban240Ban097 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	private const string IDENTIFICACAO_BANCO = "097CENTRALCREDI";

	public ComandoGerarHeaderArquivoRemessaFebraban240Ban097()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240  do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).LoteServico.Valor = "0000";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban1.Valor = StringUtil.ObterStringComBrancos(9);
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			string text = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			if (text.Length == 14)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroInscricaoEmpresa.Valor = text + StringUtil.ObterStringComBrancos(1);
			}
			else if (text.Length == 11)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroInscricaoEmpresa.Valor = text + StringUtil.ObterStringComBrancos(4);
			}
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.ZerosLeft(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 20);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgencia.Valor = StringUtil.ObterStringComBrancos(1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgenciaContaCorrente.Valor = StringUtil.ObterStringComBrancos(1);
			if (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBIR_RAZAO_SOCIAL_BENEFICIARIO, base.Carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibirRazaoSocialBeneficiario(), base.Carteira.ConfiguracaoBoleto.ParametrosAdicionais).Equals("S"))
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.RazaoSocialBeneficiario;
			}
			else
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			}
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeBanco.Valor = "097CENTRALCREDI";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban2.Valor = StringUtil.ObterStringComBrancos(10);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoRemessaRetorno.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DataGeracaoArquivo.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).HoraGeracaoArquivo.Valor = (string)base.TimeConverter.Convert(DateTime.Now, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroSequencialArquivo.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroVersaoLayoutArquivo.Valor = "101";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DensidadeGravacaoArquivo.Valor = StringUtil.ObterStringComBrancos(5);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoBanco.Valor = StringUtil.ObterStringComBrancos(20);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoEmpresa.Valor = StringUtil.ObterStringComBrancos(20);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban3.Valor = StringUtil.ObterStringComBrancos(29);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
