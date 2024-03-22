using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban756;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheRemessaCnab400Ban756 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban756()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Segmento as DetalheRemessaCnab400Ban756).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban756.DETALHE.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban756).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban756).DVAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban756).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban756).DVContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroConvenioBeneficiario.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroControleParticipante.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroParcela.Valor = "01";
			(base.Segmento as DetalheRemessaCnab400Ban756).GrupoValor.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban756).Filler1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.SacadorAvalista))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).IndicativoMensagemSacadorAvalista.Valor = " ";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).IndicativoMensagemSacadorAvalista.Valor = "A";
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).PrefixoTitulo.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban756).VariacaoCarteira.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban756).ContaCaucao.Valor = "0";
			if (base.Carteira is CarteiraCobrancaBan756Codigo03Garantida)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroContratoGarantia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor, 1);
				(base.Segmento as DetalheRemessaCnab400Ban756).DVNumeroContratoGarantia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor, 2);
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroBordero.Valor = base.Documento.NumeroControle;
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroContratoGarantia.Valor = "0";
				(base.Segmento as DetalheRemessaCnab400Ban756).DVNumeroContratoGarantia.Valor = "0";
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroBordero.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).Filler2.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoEmissao.Valor = EnumTipoEmissaoBoleto.EMISSOR_BANCO.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoEmissao.Valor = EnumTipoEmissaoBoleto.EMISSOR_CEDENTE.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).Carteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).Comando.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).Comando.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).SeuNumero.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban756).Vencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban756).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroBanco.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban756).PrefixoCooperativa.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban756).DVPrefixoCooperativa.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_PRIMEIRA_INSTRUCAO_CODIFICADA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan756).PrimeiraInstrucaoCodificada(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban756).Instrucao1.Valor = valorParametroAdicional.ToEnum<EnumInstrucaoCobranca>().Codigo();
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_SEGUNDA_INSTRUCAO_CODIFICADA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan756).SegundaInstrucaoCodificada(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban756).Instrucao2.Valor = valorParametroAdicional2.ToEnum<EnumInstrucaoCobranca>().Codigo();
			ConfigurarJuros();
			ConfigurarMulta();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoDistribuiBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoDistribuicao.Valor = EnumTipoDistribuicaoBoleto.DISTRIBUIDOR_BANCO.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoDistribuicao.Valor = EnumTipoDistribuicaoBoleto.DISTRIBUIDOR_CEDENTE.Codigo();
			}
			ConfigurarDesconto();
			(base.Segmento as DetalheRemessaCnab400Ban756).CodigoMoeda.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban756).ValorIOF.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban756).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TipoInscricaoPagador.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban756).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban756).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban756).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban756).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban756).UFPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban756).ObservacoesOuMensagemOuSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroDiasProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).NumeroDiasProtesto.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban756).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban756).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as DetalheRemessaCnab400Ban756).DataDesconto.Valor = "0";
		(base.Segmento as DetalheRemessaCnab400Ban756).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban756).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as DetalheRemessaCnab400Ban756).TaxaMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F4", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TaxaMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as DetalheRemessaCnab400Ban756).TaxaJurosMes.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F4", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0 * 30.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso * 30.0) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban756).TaxaJurosMes.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
		}
	}
}
