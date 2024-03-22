using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban021.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoRemessaCnab400Ban021 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoRemessaCnab400Ban021()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban021.REGISTRO_TRANSACAO.Codigo();
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).TipoInscricaoBeneficiario.Valor = (base.Carteira.ConfiguracaoCarteiraCobranca.TipoInscricaoBeneficiario.Equals("CPF") ? EnumTipoInscricao.CPF.Codigo() : EnumTipoInscricao.CNPJ.Codigo());
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoBeneficiario.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).Filler1.Valor = "";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NossoNumero.Valor = base.Documento.NossoNumeroSemMascara;
			ConfigurarMulta();
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).IdentificacaoCarne.Valor = "";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroParcelaCarne.Valor = "0";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).QuantidadeParcelasCarne.Valor = "0";
			if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo().Substring(1);
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroInscricaoPagador.Valor = "000" + StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			else
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo().Substring(1);
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoCarteira.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoOcorrencia.Valor = ((!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa)) ? base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo() : EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo());
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).Filler2.Valor = "0";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoBanco.Valor = EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Codigo();
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).PracaCobranca.Valor = (base.Carteira.ConfiguracaoCarteiraCobranca.BancoDistribuiBoleto ? "00000" : "00501");
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).EspecieTitulo.Valor = ((!string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca)) ? base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo() : base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo());
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoAceite.Valor = ((!string.IsNullOrEmpty(base.Documento.Aceite)) ? base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo() : base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo());
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).PrimeiraInstrucaoCobranca.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			ConfigurarProtesto();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).IOC.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroInscricaoPagador.Valor = "000" + StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).EnderecoPagador.Valor = ((!string.IsNullOrEmpty(base.Documento.NumeroEnderecoPagador)) ? (base.Documento.EnderecoPagador + ", " + base.Documento.NumeroEnderecoPagador) : base.Documento.EnderecoPagador);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).EstadoPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).MensagemCampoInstrucao.Valor = "";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).Filler3.Valor = "0";
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoMoeda.Valor = ((!string.IsNullOrEmpty(base.Documento.Moeda)) ? base.Documento.Moeda.ToEnum<EnumCodigoMoeda>().Codigo() : base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo());
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarProtesto()
	{
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).PrimeiraInstrucaoCobranca.Valor = EnumCodigoProtesto.NAO_PROTESTAR5.Codigo();
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).SegundaInstrucaoCobranca.Valor = "00";
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto))
		{
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).PrimeiraInstrucaoCobranca.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
		}
		if (base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS5.ToString()))
		{
			(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).SegundaInstrucaoCobranca.Valor = ((base.Documento.DiasProtesto > 0) ? StringUtil.ZerosLeft((string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(int), null, CultureInfo.CurrentCulture), 2) : "00");
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).DataLimiteDesconto.Valor = "0";
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorJuros.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoJuros.Valor = EnumCodigoJuros.CONFIGURACAO_BANCO.Codigo();
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.CONFIGURACAO_BANCO));
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorJuros.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoMulta.Valor = EnumCodigoMulta.VALOR_FIXO4.Codigo();
		(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.VALOR_FIXO4));
			double num = 0.0;
			num = ((enumCodigoMulta != EnumCodigoMulta.PERCENTUAL3) ? ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0)) : ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0)));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as IRegistroTransacaoRemessaCnab400Ban021).ValorMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
