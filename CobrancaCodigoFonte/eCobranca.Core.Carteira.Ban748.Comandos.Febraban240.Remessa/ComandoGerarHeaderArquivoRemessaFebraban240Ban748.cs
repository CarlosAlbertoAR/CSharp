using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderArquivoRemessaFebraban240Ban748 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarHeaderArquivoRemessaFebraban240Ban748()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240  do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).LoteServico.Valor = "0000";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoConvenioBanco.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgencia.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgenciaContaCorrente.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeBanco.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Sigla();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoRemessaRetorno.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DataGeracaoArquivo.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).HoraGeracaoArquivo.Valor = (string)base.TimeConverter.Convert(DateTime.Now, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroSequencialArquivo.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroVersaoLayoutArquivo.Valor = "081";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DensidadeGravacaoArquivo.Valor = "01600";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoBanco.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoEmpresa.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
