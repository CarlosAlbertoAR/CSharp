using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroDetalheTipo1RemessaCnab400Ban399 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroDetalheTipo1RemessaCnab400Ban399()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Segmento as DetalheRemessaCnab400Ban399).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban399.REGISTRO_TIPO_1.Codigo();
			if (base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario.Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban399).Filler1.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban399).AgenciaBeneficiario.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor;
			(base.Segmento as DetalheRemessaCnab400Ban399).SubContaBeneficiario.Valor = "55";
			(base.Segmento as DetalheRemessaCnab400Ban399).NumeroContaCorrenteBeneficiario.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor + StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor);
			(base.Segmento as DetalheRemessaCnab400Ban399).Filler2.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban399).NumeroControleParticipante.Valor = base.Documento.NumeroControle;
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).DataDesconto2.Valor = "0";
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).DataDesconto2.Valor = valorParametroAdicional;
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto2.Valor = valorParametroAdicional2;
			}
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional3))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).DataDesconto3.Valor = "0";
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).DataDesconto3.Valor = valorParametroAdicional;
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto3.Valor = valorParametroAdicional2;
			}
			if (string.IsNullOrEmpty(base.Documento.ModalidadeCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).CodigoCarteira.Valor = (base.Carteira.DadosConfiguracao[3] as DadoConfiguracao).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).CodigoCarteira.Valor = base.Documento.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).SeuNumero.Valor = StringUtil.RemoverMascara(base.Documento.NumeroDocumento);
			(base.Segmento as DetalheRemessaCnab400Ban399).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban399).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban399).BancoCobrador.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban399).AgenciaDepositaria.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).EspecieDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).EspecieDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban399).Instrucao1.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban399).Instrucao2.Valor = "0";
			if (base.Documento.PercentualJurosDiaAtraso > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorJurosDeMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorJurosDiasAtraso > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorJurosDeMora.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorJurosDiasAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorJurosDeMora.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).DataDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			if (base.Documento.PercentualDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else if (base.Documento.ValorDesconto > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).ValorIOF.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban399).ValorAbatimentoMulta.Valor = "0";
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban399).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban399).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).TipoInscricaoPagador.Valor = EnumTipoInscricao.NAO_TEM.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban399).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban399).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban399).InstrucaoDeNaoRecebimento.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban399).BairroPagador.Valor = base.Documento.BairroPagador;
			if (!string.IsNullOrEmpty(base.Documento.CepPagador))
			{
				string text = StringUtil.RemoverMascara(base.Documento.CepPagador);
				if (text.Length == 8)
				{
					(base.Segmento as DetalheRemessaCnab400Ban399).PrefixoCepPagador.Valor = text.Substring(0, 5);
					(base.Segmento as DetalheRemessaCnab400Ban399).SufixoCepPagador.Valor = text.Substring(5, 3);
				}
				else
				{
					Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.Infra.CepInvalido(text), new StackTrace().GetFrame(1).GetMethod());
					(base.Segmento as DetalheRemessaCnab400Ban399).PrefixoCepPagador.Valor = "0";
					(base.Segmento as DetalheRemessaCnab400Ban399).SufixoCepPagador.Valor = "0";
				}
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).PrefixoCepPagador.Valor = "0";
				(base.Segmento as DetalheRemessaCnab400Ban399).SufixoCepPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban399).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban399).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as DetalheRemessaCnab400Ban399).TipoBoletoUtilizado.Valor = "";
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).PrazoProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban399).PrazoProtesto.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban399).CodigoMoeda.Valor = EnumCodigoMoeda.REAL4.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban399).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
