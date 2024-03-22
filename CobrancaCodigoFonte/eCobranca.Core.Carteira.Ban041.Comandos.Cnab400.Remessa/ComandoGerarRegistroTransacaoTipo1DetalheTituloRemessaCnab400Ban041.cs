using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTransacaoTipo1DetalheTituloRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban041.TRANSACAO_TIPO_1_DADOS_TITULO.Codigo();
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler1.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1) + StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler2.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).IdentificacaoTituloBeneficiario.Valor = base.Documento.NumeroDocumento;
			if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NossoNumero.Valor = "";
			}
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Mensagem.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler3.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TipoCarteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).SeuNumero.Valor = base.Documento.NumeroControle;
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).BancoCobrador.Valor = EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.Codigo();
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler4.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TipoDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TipoDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorIOF.Valor = "0";
			if (base.Documento.ValorAbatimento > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorAbatimento.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler5.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler6.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroDiasMultaAposVencimento.Valor = (string)base.IntConverter.Convert(0, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).UFPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler7.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).Filler8.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
			EnumTipoCarteiraCobranca enumTipoCarteiraCobranca = (EnumTipoCarteiraCobranca)(object)base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>();
			if ((uint)(enumTipoCarteiraCobranca - 39) <= 1u)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao1.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao2.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoJurosDeMora.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorPercentualJurosAoDia.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).DataDesconto.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorDesconto.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TaxaMulta.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TaxaAoDiaPagamentoAntecipado.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorParaCalculoDesconto.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroDiasProtestoOuDevolucaoAutomatica.Valor = "0";
				return;
			}
			if (base.Documento.InstrucoesCobranca.Count > 0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao1.Valor = ((InstrucaoCobranca)base.Documento.InstrucoesCobranca[0]).Codigo.ToEnum<EnumInstrucaoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao1.Valor = "0";
			}
			if (base.Documento.InstrucoesCobranca.Count > 1)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao2.Valor = ((InstrucaoCobranca)base.Documento.InstrucoesCobranca[1]).Codigo.ToEnum<EnumInstrucaoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoInstrucao2.Valor = "0";
			}
			ConfigurarJuros();
			ConfigurarDesconto();
			ConfigurarMulta();
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TaxaAoDiaPagamentoAntecipado.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F1", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorParaCalculoDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (base.Documento.DiasBaixaDevolucao > 0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroDiasProtestoOuDevolucaoAutomatica.Valor = (string)base.IntConverter.Convert(base.Documento.DiasBaixaDevolucao, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).NumeroDiasProtestoOuDevolucaoAutomatica.Valor = "0";
			}
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TaxaMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F1", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).TaxaMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F1", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).DataDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
		(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoJurosDeMora.Valor = EnumCodigoJuros.VALOR_DIARIO.Codigo();
		(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorPercentualJurosAoDia.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.VALOR_DIARIO));
			double num = 0.0;
			switch (enumCodigoJuros)
			{
			case EnumCodigoJuros.VALOR_DIARIO:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoJuros.TAXA_MENSAL2:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0 * 30.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso * 30.0) : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).CodigoJurosDeMora.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as RegistroTransacaoTipo1DadosTituloRemessaCnab400Ban041).ValorPercentualJurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
