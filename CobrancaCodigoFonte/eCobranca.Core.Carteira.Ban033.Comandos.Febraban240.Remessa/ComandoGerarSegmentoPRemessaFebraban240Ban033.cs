using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoPRemessaFebraban240Ban033 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoPRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do {EnumCodigoBanco.BANCO_SANTANDER}...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoBanco.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroLoteNaRemessa.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoMovimentoRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoMovimentoRemessa.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DvAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor.ToUpper(), 2);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DvContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor.ToUpper(), 2);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).ContaCobranca.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DvContaCobranca.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor.ToUpper(), 2);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco2.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).IdentificacaoTituloNoBanco.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).TipoCobranca.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[4]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).FormaCadastramento.Valor = EnumFormaCadastroTituloNoBanco.COM_CADASTRAMENTO_COBRANCA_REGISTRADA.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).FormaCadastramento.Valor = EnumFormaCadastroTituloNoBanco.SEM_CADASTRAMENTO_COBRANCA_SEM_REGISTRO.Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).TipoDocumento.Valor = EnumTipoDocumento.TRADICIONAL.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco3.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco4.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroDocumento.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).AgenciaCobradora.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DvAgenciaCobradora.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco5.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).EspecieDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).EspecieDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).ValorIOF.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).IdentificacaoTituloNaEmpresa.Valor = StringUtil.RemoverMascara(base.Documento.NumeroControle);
			if (string.IsNullOrEmpty(base.Documento.CodigoProtesto))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoProtesto.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoProtesto.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroDiasProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroDiasProtesto.Valor = "0";
			}
			if (string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoBaixaDevolucao.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoBaixaDevolucao.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco6.Valor = "";
			if (base.Documento.DiasBaixaDevolucao > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroDiasBaixaDevolucao.Valor = (string)base.IntConverter.Convert(base.Documento.DiasBaixaDevolucao, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).NumeroDiasBaixaDevolucao.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.DiasBaixa, typeof(string), null, CultureInfo.CurrentCulture);
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoMoeda.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban033).UsoReservadoBanco7.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoDesconto.Valor = EnumCodigoDesconto.SEM_DESCONTO.Codigo();
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataDesconto.Valor = "0";
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).Desconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = 0.0;
			switch (enumCodigoDesconto)
			{
			case EnumCodigoDesconto.SEM_DESCONTO:
				return;
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
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoDesconto.Valor = enumCodigoDesconto.Codigo();
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).Desconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoJuros.Valor = EnumCodigoJuros.ISENTO.Codigo();
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataJuros.Valor = "0";
		(base.Segmento as SegmentoDetalhePFebraban240Ban033).JurosAoDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()));
			DateTime? dataVencimento = base.Documento.DataVencimento;
			double num = 0.0;
			switch (enumCodigoJuros)
			{
			case EnumCodigoJuros.ISENTO:
				return;
			case EnumCodigoJuros.VALOR_POR_DIA:
			case EnumCodigoJuros.TOLERANCIA_VALOR_POR_DIA:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoJuros.TAXA_MENSAL:
			case EnumCodigoJuros.TOLERANCIA_TAXA_MENSAL:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0 * 30.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso * 30.0) : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).CodigoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).DataJuros.Valor = (string)base.DateConverter.Convert(dataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalhePFebraban240Ban033).JurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
