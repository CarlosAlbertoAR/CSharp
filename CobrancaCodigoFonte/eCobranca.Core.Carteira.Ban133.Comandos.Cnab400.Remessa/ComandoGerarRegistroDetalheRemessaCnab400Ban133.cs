using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban133.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroDetalheRemessaCnab400Ban133 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroDetalheRemessaCnab400Ban133()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.CRESOL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.CRESOL}]...");
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban133.DETALHE.Codigo();
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoAgencia.Valor = "0";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DVAgencia.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).RazaoContaCorrente.Valor = "0";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ContaCorrente.Valor = "0";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DVContaCorrente.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoBeneficiario.Valor = "0" + StringUtil.ZerosLeft(base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca, 2) + "0" + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1), 4) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1), 7) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2), 1);
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoBanco.Valor = "0";
			ConfigurarMulta();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1);
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DVNossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DVNossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2);
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DescontoBonificacaoPorDia.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoEmissorBoleto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_E_PROCESSA_REGISTRO.Codigo();
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoEmissorBoleto.Valor = EnumCodigoEmissaoBoleto.CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO.Codigo();
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoDebitoAutomatico.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IdentificacaoOperacaoBanco.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).IndicadorRateioCredito.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).EnderecamentoAvisoDebitoAutomatico.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).QuantidadePossiveisPagamento.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			if (!base.Documento.DataVencimento.HasValue)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataVencimento.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).BancoEncarregadoCobranca.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).AgenciaDepositaria.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).Especie.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).Especie.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).Identificacao.Valor = "";
			if (!base.Documento.DataDocumento.HasValue)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataEmissao.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			}
			GerarInstrucoes();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorIOF.Valor = "0";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).EnderecoPagador.Valor = base.Documento.EnderecoPagador + " " + base.Documento.CidadePagador + " " + base.Documento.UfPagador;
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).PrimeiraMensagem.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CepPagador))
			{
				string text = StringUtil.RemoverMascara(base.Documento.CepPagador);
				if (text.Length == 8)
				{
					(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CepPagador.Valor = text;
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.CepInvalido(text), new StackTrace().GetFrame(1).GetMethod());
					(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CepPagador.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CepPagador.Valor = "0";
			}
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).SacadorAvalista.Valor = "";
			(base.Segmento as RegistroDetalheRemessaCnab400Ban133).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.CRESOL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataLimiteDesconto.Valor = "0";
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (!(num <= 0.0) && num > 0.0)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoMulta.Valor = EnumCodigoMulta.SEM_MULTA.Codigo();
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.SEM_MULTA);
			double num = 0.0;
			switch (enumCodigoMulta)
			{
			case EnumCodigoMulta.SEM_MULTA:
				return;
			case EnumCodigoMulta.PERCENTUAL:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as RegistroDetalheRemessaCnab400Ban133).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void GerarInstrucoes()
	{
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).PrimeiraInstrucao.Valor = "";
		(base.Segmento as RegistroDetalheRemessaCnab400Ban133).SegundaInstrucao.Valor = "";
	}
}
