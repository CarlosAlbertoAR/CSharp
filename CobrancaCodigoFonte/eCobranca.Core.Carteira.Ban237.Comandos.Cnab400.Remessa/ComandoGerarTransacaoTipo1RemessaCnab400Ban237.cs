using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban237;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoTipo1RemessaCnab400Ban237 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoTipo1RemessaCnab400Ban237()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban237.TRANSACAO_TIPO_1.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).AgenciaDebito.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DVAgenciaDebito.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).RazaoContaCorrente.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ContaCorrente.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DVContaCorrente.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoBeneficiarioNoBanco.Valor = "0" + StringUtil.ZerosLeft(base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca, 3) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1), 5) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1), 7) + StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2), 1);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			if (ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CLIENTE_OPTA_DEBITO_AUTOMATICO, ((base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis as ParametrosAdicionaisDisponiveisBan237).Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan237).ClienteOptaDebitoAutomatico(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais).Equals("S") ? true : false)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoBanco.Valor = EnumCodigoBanco.BANCO_BRADESCO.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoBanco.Valor = "0";
			}
			ConfigurarMulta();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1);
			}
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DVNossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DVNossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2);
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DescontoBonificacaoPorDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CondicaoEmissaoBloqueto.Valor = EnumCodigoEmissaoBoleto.BANCO_EMITE_E_PROCESSA_REGISTRO.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CondicaoEmissaoBloqueto.Valor = EnumCodigoEmissaoBoleto.CLIENTE_EMITE_E_BANCO_PROCESSA_REGISTRO.Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoEmissaoBoletoDebitoAutomatico.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoOperacao.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IndicadorRateioCredito.Valor = "";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).EnderecamentoParaAvisoDebitoAutomatico.Valor = EnumAvisoDebitoAutomatico.NAO_EMITE_AVISO.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Filler1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).IdentificacaoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoBancoCobrador.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).AgenciaDepositaria.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Identificacao.Valor = "N";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			GerarInstrucoes();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorIOF.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).TipoInscricaoPagador.Valor = EnumTipoInscricao.NAO_TEM.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).EnderecoPagador.Valor = base.Documento.EnderecoPagador + " " + base.Documento.BairroPagador + " " + base.Documento.CidadePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Mensagem1.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CepPagador))
			{
				string text = StringUtil.RemoverMascara(base.Documento.CepPagador);
				if (text.Length == 8)
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PrefixoCepPagador.Valor = text.Substring(0, 5);
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SufixoCepPagador.Valor = text.Substring(5, 3);
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.CepInvalido(text), new StackTrace().GetFrame(1).GetMethod());
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PrefixoCepPagador.Valor = "0";
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SufixoCepPagador.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PrefixoCepPagador.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SufixoCepPagador.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.SacadorAvalista) && (!string.IsNullOrEmpty(base.Documento.CnpjAvalista) || !string.IsNullOrEmpty(base.Documento.CpfAvalista)))
			{
				if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
				{
					string text2 = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
					if (text2.Length == 14)
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = text2.Substring(12, 2) + text2.Substring(8, 4) + StringUtil.ZerosLeft(text2.Substring(0, 8), 9) + StringUtil.ObterStringComBrancos(2) + base.Documento.SacadorAvalista;
					}
					else
					{
						Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.NumeroInscricaoCnpjInvalido(text2), new StackTrace().GetFrame(1).GetMethod());
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = "";
					}
				}
				else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
				{
					string text3 = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
					if (text3.Length == 11)
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = text3.Substring(9, 2) + StringUtil.ZerosLeft("0", 4) + text3.Substring(0, 9) + StringUtil.ObterStringComBrancos(2) + base.Documento.SacadorAvalista;
					}
					else
					{
						Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.NumeroInscricaoCpfInvalido(text3), new StackTrace().GetFrame(1).GetMethod());
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = "";
					}
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = "";
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DataDesconto.Valor = "0";
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoMulta.Valor = EnumCodigoMulta.SEM_MULTA.Codigo();
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.SEM_MULTA));
			double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void GerarInstrucoes()
	{
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto))
		{
			if (base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR2.ToString()))
			{
				if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
				{
					if (base.Documento.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
					}
				}
				else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
				{
					if (base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasProtesto(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
		else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto))
		{
			if (base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR2.ToString()))
			{
				if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
				{
					if (base.Documento.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
					}
				}
				else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
				{
					if (base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
					}
					else
					{
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
						(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
					}
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasProtesto(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
		else if (!string.IsNullOrEmpty(base.Documento.CodigoBaixaDevolucao))
		{
			if (base.Documento.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Documento.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
		else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao))
		{
			if (base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.Equals(EnumCodigoBaixaDevolucao.NAO_BAIXAR_NAO_DEVOLVER.ToString()))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = "0";
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoBaixaDevolucao.ToEnum<EnumCodigoBaixaDevolucao>().Codigo();
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = (string)base.IntConverter.Convert(GetDiasBaixaDevolucao(), typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
	}

	private int GetDiasProtesto()
	{
		int num = base.Documento.DiasProtesto;
		if (num < 5)
		{
			num = 5;
		}
		if (num > 99)
		{
			num = 99;
		}
		return num;
	}

	private int GetDiasBaixaDevolucao()
	{
		int num = base.Documento.DiasBaixaDevolucao;
		if (num > 99)
		{
			num = 99;
		}
		return num;
	}
}
