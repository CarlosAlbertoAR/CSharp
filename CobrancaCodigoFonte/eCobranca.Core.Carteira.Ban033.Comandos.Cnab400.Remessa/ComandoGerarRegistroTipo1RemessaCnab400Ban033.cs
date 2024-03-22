using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban033;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo1RemessaCnab400Ban033 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo1RemessaCnab400Ban033()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban033.REGISTRO_TIPO_1.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).AgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ContaMovimentoBeneficiario.Valor = StringUtil.ZerosLeft(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 8);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ContaCobrancaBeneficiario.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor).Substring(0, 8);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataSegundoDesconto.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataSegundoDesconto.Valor = valorParametroAdicional;
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Filler1.Valor = "";
			ConfigurarMulta();
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).UnidadeValorMoeda.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorTituloEmOutraUnidade.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Filler2.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoCarteira.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[4]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.NumeroDocumento))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SeuNumero.Valor = base.Documento.NumeroControle;
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SeuNumero.Valor = base.Documento.NumeroDocumento;
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroBancoCobrador.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).AgenciaCobradora.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).EspecieDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).EspecieDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataEmissaoTitulo.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor = "0";
			}
			if (!(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor.Equals("00"))
			{
				if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
				{
					if ((base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor != base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo())
					{
						(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SegundaInstrucaoCobranca.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
					}
				}
				else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
				{
					if ((base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrimeiraInstrucaoCobranca.Valor != base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo())
					{
						(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SegundaInstrucaoCobranca.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
					}
				}
				else
				{
					(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SegundaInstrucaoCobranca.Valor = "0";
				}
			}
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorIOF.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).TipoInscricaoPagador.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PrefixoCEPPagador.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.CepPagador, 1);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).SufixoCEPPagador.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.CepPagador, 2);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).MunicipioPagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).UFPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Filler3.Valor = "";
			if ((ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_UTILIZA_CODIGO_DE_COBRANCA_NOVA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan033).UtilizaCodigoDeCobrancaNova(), base.Documento.ParametrosAdicionais) == "S") ? true : false)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).IdentificadorComplemento.Valor = "I";
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Complemento.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(8, 2);
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).IdentificadorComplemento.Valor = "";
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Complemento.Valor = "";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Filler4.Valor = "";
			if (base.Documento.DiasProtesto > 0 && base.Documento.DiasProtesto <= 99)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroDiasProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else if (base.Documento.DiasProtesto > 99)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroDiasProtesto.Valor = (string)base.IntConverter.Convert(99, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroDiasProtesto.Valor = "0";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).Filler5.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban033).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorDesconto.Valor = "0";
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataLimiteDesconto.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorJurosAoDia.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoMulta.Valor = EnumCodigoMulta.PERCENTUAL2.Codigo();
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataMulta.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento.Value.AddDays(1.0), typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
		(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PercentualMulta.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = EnumCodigoMulta.PERCENTUAL2;
			DateTime dateTime = base.Documento.DataVencimento.Value.AddDays(1.0);
			double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).DataMulta.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTipo1RemessaCnab400Ban033).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
