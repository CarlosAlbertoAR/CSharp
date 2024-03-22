using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban097;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheRemessaCnab400Ban097 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban097()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Segmento as DetalheRemessaCnab400Ban097).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban097.DETALHE.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler1.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban097).DVContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler2.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoControleEmpresa.Valor = base.Documento.NumeroControle;
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler4.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).ComandoIdentificacao.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).ComandoIdentificacao.Valor = EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban097).DataRealizacaoSituacao.Valor = (string)base.DateConverter.Convert(DateTime.Now, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler5.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler6.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler7.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).ContaCaucao.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoResponsabilidade.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).DVCodigoResponsabilidade.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).NumeroBordero.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler8.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).CarteiraModalidade.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoMovimentoRemessa.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban097).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler9.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler10.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler11.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler12.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler13.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler14.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler15.Valor = "";
			if (base.Documento.PercentualJurosDiaAtraso > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaJuros.Valor = (string)base.DoubleConverter.Convert(MathUtil.ConverterTaxaJurosDiarioParaMensal(base.Documento.PercentualJurosDiaAtraso * 30.0), typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorJurosDiasAtraso > 0.0)
			{
				double num = base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0;
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaJuros.Valor = (string)base.DoubleConverter.Convert(MathUtil.ConverterTaxaJurosDiarioParaMensal(num * 30.0), typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.PercentualJurosAoDia > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaJuros.Valor = (string)base.DoubleConverter.Convert(MathUtil.ConverterTaxaJurosDiarioParaMensal(base.Carteira.ConfiguracaoDocumentoCobranca.PercentualJurosAoDia * 30.0), typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.ValorJurosAoDia > 0.0)
			{
				double num2 = base.Carteira.ConfiguracaoDocumentoCobranca.ValorJurosAoDia / base.Documento.ValorDocumento * 100.0;
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaJuros.Valor = (string)base.DoubleConverter.Convert(MathUtil.ConverterTaxaJurosDiarioParaMensal(num2 * 30.0), typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaJuros.Valor = "0";
			}
			if (base.Documento.PercentualMultaAtraso > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaMulta.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualMultaAtraso, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorMultaAtraso > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaMulta.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.PercentualMulta > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaMulta.Valor = (string)base.DoubleConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.PercentualMulta, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.ValorMulta > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaMulta.Valor = (string)base.DoubleConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.ValorMulta / base.Documento.ValorDocumento * 100.0, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).PercentualTaxaMulta.Valor = "0";
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_JUROS_CNAB400, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).TipoCarenciaJuros(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoJuros.Valor = valorParametroAdicional;
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_JUROS, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).CarenciaCobrancaJuros(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban097).DiasJuros.Valor = valorParametroAdicional2;
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_MULTA_CNAB400, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).TipoCarenciaMulta(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban097).CodigoJuros.Valor = valorParametroAdicional3;
			string valorParametroAdicional4 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_MULTA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).CarenciaCobrancaMulta(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban097).DiasJuros.Valor = valorParametroAdicional4;
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.PercentualDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Carteira.ConfiguracaoDocumentoCobranca.ValorDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(base.Carteira.ConfiguracaoDocumentoCobranca.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorPrimeiroDesconto.Valor = "0";
			}
			string valorParametroAdicional5 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			string valorParametroAdicional6 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional5) && !string.IsNullOrEmpty(valorParametroAdicional6))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).DataSegundoDesconto.Valor = valorParametroAdicional5;
				(base.Segmento as DetalheRemessaCnab400Ban097).ValorSegundoDesconto.Valor = valorParametroAdicional6;
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoPagador.Valor = EnumTipoInscricao.ISENTO.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban097).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban097).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban097).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban097).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.ISENTO.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097).NumeroInscricaoSacadorAvalista.Valor = "0";
			}
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).Protesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097).Protesto.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban097).Filler16.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
