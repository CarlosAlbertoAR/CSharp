using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban237Unicred : ComandoGerarHeaderLoteRemessaFebraban240Ban237
{
	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_BRADESCO.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroVersaoLayoutLote.Valor = "041";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[14] as DadoConfiguracao).Valor);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgenciaContaCorrente.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NomeEmpresa.Valor = (base.Carteira.DadosConfiguracao[7] as DadoConfiguracao).Valor;
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroRemessaRetorno.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataGravacaoRemessaRetorno.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataCredito.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
