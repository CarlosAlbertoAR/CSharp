using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoPRemessaFebraban240Ban399 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoPRemessaFebraban240Ban399()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo();
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
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoAgencia.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor;
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvAgencia.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor);
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvContaCorrente.Valor = "0";
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DvAgenciaContaCorrente.Valor = "0";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNoBanco.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNoBanco.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			if (string.IsNullOrEmpty(base.Documento.ModalidadeCobranca))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoCarteira.Valor = (base.Carteira.DadosConfiguracao[3] as DadoConfiguracao).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoCarteira.Valor = base.Documento.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			}
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
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoEmissaoBoleto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_BOLETO_AUTO_ENVELOPADO.Codigo();
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
			if (string.IsNullOrEmpty(base.Documento.CodigoJuros))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoJuros.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoJuros.Valor = base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataJuros.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			if (base.Documento.PercentualJurosDiaAtraso > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).JurosMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorJurosDiasAtraso > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).JurosMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorJurosDiasAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).JurosMora.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			if (string.IsNullOrEmpty(base.Documento.CodigoDesconto))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>().Codigo();
			}
			if (base.Documento.ValorDesconto > 0.0 || base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataDesconto1.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).DataDesconto1.Valor = "0";
			}
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).Desconto1.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).Desconto1.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
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
			if (string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaBaixa.Valor = "0";
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private int GetNumeroDiasProtesto(DocumentoCobranca dc)
	{
		int result = 0;
		if (dc.DiasProtesto > 0)
		{
			result = ((dc.DiasProtesto <= 2) ? 2 : ((dc.DiasProtesto > 2 && dc.DiasProtesto < 35) ? dc.DiasProtesto : ((dc.DiasProtesto != 35) ? 45 : 35)));
		}
		return result;
	}
}
