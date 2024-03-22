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

public class ComandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarTransacaoTipo1RemessaCnab400Ban237Unicred()
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
			if (string.IsNullOrEmpty(base.Documento.CodigoMulta))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoMulta.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoMulta.Valor = base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>().Codigo();
			}
			if ((base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).CodigoMulta.Valor == "2")
			{
				if (base.Documento.PercentualMultaAtraso > 0.0)
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualMultaAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
				}
				else if (base.Documento.ValorMultaAtraso > 0.0)
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0, typeof(string), "F2", CultureInfo.CurrentCulture);
				}
				else
				{
					(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).PercentualMulta.Valor = "0";
				}
			}
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
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DescontoBonificacaoPorDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DescontoBonificacaoPorDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
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
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).NumeroDocumento.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
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
			if (string.IsNullOrEmpty(base.Documento.CodigoProtesto))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao1.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = ((base.Documento.DiasProtesto > 3) ? StringUtil.ZerosLeft(base.Documento.DiasProtesto.ToString(), 2) : "03");
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).Instrucao2.Valor = "0";
			}
			if (base.Documento.PercentualJurosDiaAtraso > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorJurosDiasAtraso > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorJurosDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorJurosDiasAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorJurosDia.Valor = "0";
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).DataDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorDesconto > 0.0)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
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
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
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
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[13]).Valor) + "  " + ((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor;
			}
			else
			{
				string text2 = ((base.Documento.BairroPagador.Length > 20) ? base.Documento.BairroPagador.Substring(0, 20) : (base.Documento.BairroPagador + StringUtil.ObterStringComBrancos(20 - base.Documento.BairroPagador.Length)));
				string text3 = ((base.Documento.CidadePagador.Length > 38) ? base.Documento.CidadePagador.Substring(0, 38) : (base.Documento.CidadePagador + StringUtil.ObterStringComBrancos(38 - base.Documento.CidadePagador.Length)));
				string text4 = ((base.Documento.UfPagador.Length > 2) ? base.Documento.UfPagador.Substring(0, 2) : (base.Documento.UfPagador + StringUtil.ObterStringComBrancos(2 - base.Documento.UfPagador.Length)));
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban237).SacadorAvalistaOuMensagem2.Valor = text2 + text3 + text4;
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
}
