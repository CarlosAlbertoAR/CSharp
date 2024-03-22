using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderArquivoRemessaFebraban240Ban104 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarHeaderArquivoRemessaFebraban240Ban104()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240  do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
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
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.ZerosLeft("0", 20);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 1), 7) + StringUtil.ZerosLeft("0", 5);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVContaCorrente.Valor = "0";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgenciaContaCorrente.Valor = "0";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeBanco.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Sigla();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoRemessaRetorno.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DataGeracaoArquivo.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).HoraGeracaoArquivo.Valor = (string)base.TimeConverter.Convert(DateTime.Now, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroSequencialArquivo.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroVersaoLayoutArquivo.Valor = "107";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DensidadeGravacaoArquivo.Valor = "0";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoBanco.Valor = "";
			if (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_MODO_HOMOLOGACAO, base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa.ModoHomologacao(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoEmpresa.Valor = "REMESSA-TESTE";
			}
			else
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoReservadoEmpresa.Valor = "REMESSA-PRODUCAO";
			}
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
