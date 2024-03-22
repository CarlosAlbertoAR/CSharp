using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoPRemessaFebraban240Ban756CorrespondenteBancoBrasil()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler1.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).TipoDoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NumeroSequencialDoRegistroLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoSegmentoDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler2.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoInstrucao.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoInstrucao.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler3.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NossoNumero.Valor = base.Documento.NossoNumero;
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoCarteira.Valor = "9";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).TipoDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).TipoDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).IdentificacaoEmissorBoleto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_E_PROCESSA_REGISTRO.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).IdentificacaoEmissorBoleto.Valor = EnumCodigoEmissaoBoleto.CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO.Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler4.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NumeroDocumentoCobranca.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorDocumento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler5.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler6.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			if (string.IsNullOrEmpty(base.Documento.CodigoJuros))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).TipoDeMora.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).TipoDeMora.Valor = base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>().Codigo();
			}
			if (base.Documento.PercentualJurosDiaAtraso > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorJurosDeMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorJurosDiasAtraso > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorJurosDeMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorJurosDiasAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorJurosDeMora.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler7.Valor = "0";
			if (base.Documento.ValorDesconto > 0.0 || base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).DataLimiteDesconto.Valor = "0";
			}
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler8.Valor = "";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ControleBeneficiario.Valor = StringUtil.ZerosLeft(base.Documento.NumeroControle, 25);
			if (base.Documento.DiasProtesto > 0 || base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ProtestoAutomatico.Valor = "1";
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NumeroDiasProtesto.Valor = ((base.Documento.DiasProtesto > 0) ? ((string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture)) : ((base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto > 0) ? ((string)base.IntConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture)) : "0"));
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).ProtestoAutomatico.Valor = "0";
				(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NumeroDiasProtesto.Valor = "0";
			}
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler9.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).CodigoMoeda.Valor = EnumCodigoMoeda.REAL.Codigo();
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).NumeroContratoOperacaoCredito.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil).Filler10.Valor = "0";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
