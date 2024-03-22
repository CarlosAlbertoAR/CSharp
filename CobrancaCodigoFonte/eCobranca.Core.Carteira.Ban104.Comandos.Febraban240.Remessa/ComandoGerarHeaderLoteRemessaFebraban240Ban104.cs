using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban104 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarHeaderLoteRemessaFebraban240Ban104()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban1.Valor = StringUtil.ZerosLeft("0", 2);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroVersaoLayoutLote.Valor = "067";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoConvenioBanco.Valor = StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 1), 7) + StringUtil.ZerosLeft("0", 13);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			long num = long.Parse(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgencia.Valor = ((num.ToString().Length <= 6) ? num.ToString().Substring(0, 1) : "0");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroContaCorrente.Valor = ((num.ToString().Length <= 6) ? (num.ToString().Substring(1) + "000000") : "000000000000");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVContaCorrente.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgenciaContaCorrente.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem2.Valor = "";
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
