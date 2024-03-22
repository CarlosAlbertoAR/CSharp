using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoPRemessaFebraban240Ban237Unicred : ComandoGerarSegmentoPRemessaFebraban240Ban237
{
	public ComandoGerarSegmentoPRemessaFebraban240Ban237Unicred()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO P da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_BRADESCO.Codigo();
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
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).IdentificacaoTituloNoBanco.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1).Substring(0, 11) + StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2).Substring(0, 1) + StringUtil.ObterStringComBrancos(5);
			}
			if (string.IsNullOrEmpty(base.Documento.ModalidadeCobranca))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoCarteira.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
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
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDocumentoCobranca.Valor = StringUtil.ZerosLeft(string.Empty, 5) + StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
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
			(base.Segmento as SegmentoDetalhePFebraban240Padrao).Aceite.Valor = EnumTipoAceite.N.Codigo();
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
			if (base.Documento.ValorDesconto > 0.0 || base.Documento.PercentualDesconto > 0.0)
			{
				if (string.IsNullOrEmpty(base.Documento.CodigoDesconto))
				{
					(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>().Codigo();
				}
				else
				{
					(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>().Codigo();
				}
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoDesconto1.Valor = "0";
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
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaProtesto.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaProtesto.Valor = "0";
			}
			if (string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).CodigoBaixa.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			if (base.Documento.DiasBaixaDevolucao > 0)
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaBaixa.Valor = (string)base.IntConverter.Convert(base.Documento.DiasBaixaDevolucao, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as SegmentoDetalhePFebraban240Padrao).NumeroDiasParaBaixa.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.DiasBaixa, typeof(string), null, CultureInfo.CurrentCulture);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoPRemessaFebraban240(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
