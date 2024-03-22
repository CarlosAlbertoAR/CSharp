using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban097 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarHeaderLoteRemessaFebraban240Ban097()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban1.Valor = StringUtil.ObterStringComBrancos(2);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroVersaoLayoutLote.Valor = "060";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban2.Valor = StringUtil.ObterStringComBrancos(1);
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			string text = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			if (text.Length == 14)
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroInscricaoEmpresa.Valor = text + StringUtil.ObterStringComBrancos(1);
			}
			else if (text.Length == 11)
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroInscricaoEmpresa.Valor = text + StringUtil.ObterStringComBrancos(4);
			}
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.ZerosLeft(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 20);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgencia.Valor = StringUtil.ObterStringComBrancos(1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgenciaContaCorrente.Valor = StringUtil.ObterStringComBrancos(1);
			if (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_EXIBIR_RAZAO_SOCIAL_BENEFICIARIO, base.Carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.ExibirRazaoSocialBeneficiario(), base.Carteira.ConfiguracaoBoleto.ParametrosAdicionais).Equals("S"))
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.RazaoSocialBeneficiario;
			}
			else
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			}
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem1.Valor = StringUtil.ObterStringComBrancos(40);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem2.Valor = StringUtil.ObterStringComBrancos(40);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroRemessaRetorno.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataGravacaoRemessaRetorno.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataCredito.Valor = StringUtil.ObterStringComBrancos(8);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban3.Valor = StringUtil.ObterStringComBrancos(33);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
