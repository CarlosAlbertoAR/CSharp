using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoTipo1RemessaCnab400Ban084 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoTipo1RemessaCnab400Ban084()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban084.DETALHE.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).AgenciaDebito.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DVAgenciaDebito.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).RazaoContaCorrente.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ContaCorrente.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DVContaCorrente.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoBeneficiarioNoBanco.Valor = "0" + StringUtil.ZerosLeft(base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca, 3) + "0" + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1), 4) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1), 7) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2), 1);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CodigoBanco.Valor = "0";
			ConfigurarMulta();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1);
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DVNossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DVNossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2);
			}
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DescontoBonificacaoPorDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DescontoBonificacaoPorDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CondicaoEmissaoBloqueto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_E_PROCESSA_REGISTRO.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CondicaoEmissaoBloqueto.Valor = EnumCodigoEmissaoBoleto.CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO.Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoEmissaoBoletoDebitoAutomatico.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoOperacao.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IndicadorRateioCredito.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).EnderecamentoParaAvisoDebitoAutomatico.Valor = EnumAvisoDebitoAutomatico.NAO_EMITE_AVISO.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Filler1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).IdentificacaoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CodigoBancoCobrador.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).AgenciaDepositaria.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Identificacao.Valor = "N";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			GerarInstrucoes();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorIOF.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).TipoInscricaoPagador.Valor = EnumTipoInscricao.NAO_TEM.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Mensagem1.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CepPagador))
			{
				string text = StringUtil.RemoverMascara(base.Documento.CepPagador);
				if (text.Length == 8)
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).PrefixoCepPagador.Valor = text.Substring(0, 5);
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).SufixoCepPagador.Valor = text.Substring(5, 3);
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.CepInvalido(text), new StackTrace().GetFrame(1).GetMethod());
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).PrefixoCepPagador.Valor = "0";
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).SufixoCepPagador.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).PrefixoCepPagador.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).SufixoCepPagador.Valor = "0";
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DataDesconto.Valor = "0";
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (!(num <= 0.0) && num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CodigoMulta.Valor = EnumCodigoMulta.SEM_MULTA.Codigo();
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.SEM_MULTA));
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
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void GerarInstrucoes()
	{
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto))
		{
			if (base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR2.ToString()))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao1.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao1.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasProtesto(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
		else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto))
		{
			if (base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR2.ToString()))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao1.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban084).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasProtesto(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
	}

	private int GetDiasProtesto()
	{
		int num = base.Documento.DiasProtesto;
		if (num < 3)
		{
			num = 3;
		}
		if (num > 55)
		{
			num = 55;
		}
		return num;
	}
}
