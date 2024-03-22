using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderArquivoRemessaFebraban240Ban237Unicred : ComandoGerarHeaderArquivoRemessaFebraban240Ban237
{
	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_BRADESCO.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).LoteServico.Valor = "0000";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.ZerosLeft(((DadoConfiguracao)base.Carteira.DadosConfiguracao[14]).Valor, 20);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeEmpresa.Valor = (base.Carteira.DadosConfiguracao[7] as DadoConfiguracao).Valor;
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NomeBanco.Valor = EnumCodigoBanco.BANCO_BRADESCO.Sigla();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).CodigoRemessaRetorno.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DataGeracaoArquivo.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).HoraGeracaoArquivo.Valor = (string)base.TimeConverter.Convert(DateTime.Now, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroSequencialArquivo.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).NumeroVersaoLayoutArquivo.Valor = "082";
			(base.Arquivo.HeaderArquivo as HeaderArquivoFebraban240Padrao).DensidadeGravacaoArquivo.Valor = "0";
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
