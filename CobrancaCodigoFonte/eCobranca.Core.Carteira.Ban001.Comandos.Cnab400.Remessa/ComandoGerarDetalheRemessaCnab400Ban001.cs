using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheRemessaCnab400Ban001 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban001()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			(base.Segmento as DetalheRemessaCnab400Ban001).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban001.DETALHE.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban001).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban001).DVAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban001).DVContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroConvenio.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor;
			(base.Segmento as DetalheRemessaCnab400Ban001).CodigoControleEmpresa.Valor = base.Documento.NumeroControle;
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroPrestacao.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban001).GrupoValor.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban001).Filler1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.SacadorAvalista))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).IndicativoMensagemOuSacadorAvalista.Valor = " ";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).IndicativoMensagemOuSacadorAvalista.Valor = "A";
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).PrefixoTitulo.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban001).VariacaoCarteira.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor;
			(base.Segmento as DetalheRemessaCnab400Ban001).ContaCaucao.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroBordero.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.ModalidadeCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoCobranca.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[5]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Sigla();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoCobranca.Valor = base.Documento.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Sigla();
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).CarteiraCobranca.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca;
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).Comando.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).Comando.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).SeuNumero.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban001).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban001).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroBanco.Valor = base.Carteira.ConfiguracaoArquivoRemessa.Banco.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban001).CodigoAgenciaCobradora.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban001).DVAgenciaCobradora.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).AceiteTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).AceiteTitulo.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			ConfigurarInstrucoesCodificadas();
			ConfiguraJuros();
			ConfiguraDesconto();
			if (!base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.Equals(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_4.ToString()) && !base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.Equals(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_6.ToString()) && !base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.Equals(EnumTipoCarteiraCobranca.BAN001_COD_12_CONVENIO_7.ToString()))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).ValorIOF.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).TipoInscricaoPagador.Valor = EnumTipoInscricao.ISENTO.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban001).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban001).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban001).Filler2.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban001).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban001).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban001).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban001).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban001).UFPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban001).ObservacoesOuMensagemOuSacadorAvalista.Valor = GetInfoAvalista();
			(base.Segmento as DetalheRemessaCnab400Ban001).NumeroDiasProtesto.Valor = GetDiasParaProtesto();
			(base.Segmento as DetalheRemessaCnab400Ban001).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban001).SequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarInstrucoesCodificadas()
	{
		string valor = (base.Segmento as DetalheRemessaCnab400Ban001).Comando.Valor;
		if (valor.Equals(EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo()))
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada1.Valor = GetCodigoInstrucaoProtesto();
			string text = ((base.Documento.ValorDesconto > 0.0 || base.Documento.PercentualDesconto > 0.0) ? EnumInstrucaoCobranca.CONCEDER_DESCONTO_SO_ATE_DATA_ESTIPULADA.Codigo() : string.Empty);
			string text2 = ((base.Documento.ValorJurosDiasAtraso > 0.0 || base.Documento.PercentualJurosDiaAtraso > 0.0) ? EnumInstrucaoCobranca.COBRAR_JUROS.Codigo() : string.Empty);
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor = ((!string.IsNullOrEmpty(text)) ? text : ((!string.IsNullOrEmpty(text2)) ? text2 : EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES.Codigo()));
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor = (string.IsNullOrEmpty((base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor) ? EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES.Codigo() : (base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor);
		}
		else if (valor.Equals(EnumCodigoMovimentoRemessa.PEDIDO_DE_BAIXA.Codigo()))
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada1.Valor = EnumInstrucaoCobranca.DEVOLVER.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor = EnumInstrucaoCobranca.BAIXAR.Codigo();
		}
		else if (valor.Equals(EnumCodigoMovimentoRemessa.PROTESTAR.Codigo()))
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada1.Valor = GetCodigoInstrucaoProtesto();
			(base.Segmento as DetalheRemessaCnab400Ban001).InstrucaoCodificada2.Valor = EnumInstrucaoCobranca.AUSENCIA_DE_INSTRUCOES.Codigo();
		}
	}

	private string GetCodigoInstrucaoProtesto()
	{
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto) && base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.PROTESTAR_DIAS_CORRIDOS.ToString()) && base.Documento.DiasProtesto > 0)
		{
			return EnumInstrucaoCobranca.PROTESTO_EM_DIAS_CORRIDOS.Codigo();
		}
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto) && base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.PROTESTAR_DIAS_UTEIS.ToString()) && base.Documento.DiasProtesto > 0)
		{
			return GetIntrucaoProtestoPorDiasUteis();
		}
		return EnumInstrucaoCobranca.NAO_PROTESTAR.Codigo();
	}

	private void ConfiguraDesconto()
	{
		(base.Segmento as DetalheRemessaCnab400Ban001).DataDesconto.Valor = "0";
		(base.Segmento as DetalheRemessaCnab400Ban001).ValorDesconto.Valor = "0";
		DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
		double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
		if (num > 0.0)
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban001).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}

	private void ConfiguraJuros()
	{
		if (base.Documento.ValorJurosDiasAtraso > 0.0)
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).JurosAoDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorJurosDiasAtraso, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
		else if (base.Documento.PercentualJurosDiaAtraso > 0.0)
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).JurosAoDia.Valor = (string)base.DoubleConverter.Convert(base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
		else
		{
			(base.Segmento as DetalheRemessaCnab400Ban001).JurosAoDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}

	private string GetInfoAvalista()
	{
		string result = "";
		if (base.Segmento.Campos[13].Valor.Equals(" "))
		{
			return result;
		}
		if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
		{
			result = ((base.Documento.SacadorAvalista.Length < 21) ? (base.Documento.SacadorAvalista + StringUtil.ObterStringComBrancos(21 - base.Documento.SacadorAvalista.Length)) : base.Documento.SacadorAvalista.Substring(0, 21));
			result += StringUtil.ObterStringComBrancos(1);
			result += "CNPJ";
			result += StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
		}
		else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
		{
			result = ((base.Documento.SacadorAvalista.Length < 24) ? (base.Documento.SacadorAvalista + StringUtil.ObterStringComBrancos(24 - base.Documento.SacadorAvalista.Length)) : base.Documento.SacadorAvalista.Substring(0, 24));
			result += StringUtil.ObterStringComBrancos(1);
			result += "CPF";
			result += StringUtil.RemoverMascara(base.Documento.CpfAvalista);
		}
		return result;
	}

	private string GetDiasParaProtesto()
	{
		string result = "0";
		if (base.Segmento.Campos[20].Valor.Equals(EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo()) && (base.Segmento.Campos[30].Valor.Equals(EnumInstrucaoCobranca.PROTESTO_EM_DIAS_CORRIDOS.Codigo()) || base.Segmento.Campos[31].Valor.Equals(EnumInstrucaoCobranca.PROTESTO_EM_DIAS_CORRIDOS.Codigo())))
		{
			result = ((base.Documento.DiasProtesto <= 6) ? "06" : ((base.Documento.DiasProtesto <= 29) ? StringUtil.ZerosLeft(base.Documento.DiasProtesto.ToString(), 2) : ((base.Documento.DiasProtesto > 35) ? "40" : "35")));
		}
		return result;
	}

	private string GetIntrucaoProtestoPorDiasUteis()
	{
		string result = "0";
		if (base.Segmento.Campos[20].Valor.Equals(EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo()) || base.Segmento.Campos[20].Valor.Equals(EnumCodigoMovimentoRemessa.PROTESTAR.Codigo()))
		{
			result = ((base.Documento.DiasProtesto <= 3) ? EnumInstrucaoCobranca.PROTESTAR_3_DIAS_UTEIS_APOS_VENCIMENTO.Codigo() : ((base.Documento.DiasProtesto != 4) ? EnumInstrucaoCobranca.PROTESTAR_5_DIAS_UTEIS_APOS_VENCIMENTO.Codigo() : EnumInstrucaoCobranca.PROTESTAR_4_DIAS_UTEIS_APOS_VENCIMENTO.Codigo()));
		}
		return result;
	}
}
