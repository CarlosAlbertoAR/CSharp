using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoPRemessaFebraban240Ban085 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoPRemessaFebraban240Ban085()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).LoteServico.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoMovimento.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoMovimento.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor.ToUpper(), 2);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor.ToUpper(), 2);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvAgenciaContaCorrente.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNoBanco.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNoBanco.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoCarteira.Valor = ((!string.IsNullOrEmpty(((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor)) ? ((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo() : EnumModalidadeCarteiraCobranca.COBRANCA_SIMPLES.Codigo());
			if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).FormaCadastroTituloNoBanco.Valor = EnumFormaCadastroTituloNoBanco.COM_CADASTRAMENTO_COBRANCA_REGISTRADA.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).FormaCadastroTituloNoBanco.Valor = EnumFormaCadastroTituloNoBanco.SEM_CADASTRAMENTO_COBRANCA_SEM_REGISTRO.Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).TipoDocumento.Valor = EnumTipoDocumento.TRADICIONAL.Codigo();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoEmissaoBoleto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_E_PROCESSA_REGISTRO.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoEmissaoBoleto.Valor = EnumCodigoEmissaoBoleto.CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO.Codigo();
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoDistribuiBoleto)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoDistribuicao.Valor = EnumCodigoDistribuicao.BANCO_DISTRIBUI.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoDistribuicao.Valor = EnumCodigoDistribuicao.CLIENTE_DISTRIBUI.Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDocumentoCobranca.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataVencimentoTitulo.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).ValorNominalTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).AgenciaCobradora.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvAgenciaCobradora.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).Aceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).Aceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataEmissaoTitulo.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).ValorIOF.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNaEmpresa.Valor = StringUtil.RemoverMascara(base.Documento.NumeroControle);
			if (string.IsNullOrEmpty(base.Documento.CodigoProtesto))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoProtesto.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoProtesto.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaProtesto.Valor = (string)base.IntConverter.Convert(GetNumeroDiasProtesto(base.Documento), typeof(string), null, CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.Codigo();
			}
			if (base.Documento.DiasBaixaDevolucao > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaBaixa.Valor = (string)base.IntConverter.Convert(base.Documento.DiasBaixaDevolucao, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaBaixa.Valor = StringUtil.ObterStringComBrancos(3);
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoMoeda.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroContrato.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).UsoLivreBancoEmpresa.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = EnumCodigoDesconto.SEM_DESCONTO2.Codigo();
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataDesconto1.Valor = "0";
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).Desconto1.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			_ = (dateTime.Value - DateTime.Today).TotalDays;
			double num = 0.0;
			switch (enumCodigoDesconto)
			{
			case EnumCodigoDesconto.VALOR_FIXO_ATE_A_DATA_INFORMADA:
			case EnumCodigoDesconto.VALOR_POR_ANTECIPACAO_DIA_CORRIDO:
				num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoDesconto.PERCENTUAL_ATE_A_DATA_INFORMADA:
				num = ((base.Documento.ValorDesconto > 0.0) ? (base.Documento.ValorDesconto / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualDesconto > 0.0) ? base.Documento.PercentualDesconto : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = enumCodigoDesconto.Codigo();
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataDesconto1.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).Desconto1.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoJuros.Valor = EnumCodigoJuros.ISENTO.Codigo();
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataJuros.Valor = "0";
		(base.Segmento as SegmentoDetalhePFebraban240Padrao).JurosMora.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()));
			DateTime? dataVencimento = base.Documento.DataVencimento;
			double num = 0.0;
			switch (enumCodigoJuros)
			{
			case EnumCodigoJuros.VALOR_POR_DIA:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoJuros.TAXA_MENSAL:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0 * 30.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso * 30.0) : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataJuros.Valor = (string)base.DateConverter.Convert(dataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).JurosMora.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private int GetNumeroDiasProtesto(DocumentoCobranca dc)
	{
		int num = 0;
		if ((string.IsNullOrEmpty(dc.CodigoProtesto) ? ((EnumCodigoProtesto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>()) : ((EnumCodigoProtesto)(object)dc.CodigoProtesto.ToEnum<EnumCodigoProtesto>())) == EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS)
		{
			if (dc.DiasProtesto <= 6)
			{
				return 6;
			}
			if (dc.DiasProtesto <= 29)
			{
				return dc.DiasProtesto;
			}
			if (dc.DiasProtesto <= 35)
			{
				return 35;
			}
			return 40;
		}
		return 0;
	}
}
