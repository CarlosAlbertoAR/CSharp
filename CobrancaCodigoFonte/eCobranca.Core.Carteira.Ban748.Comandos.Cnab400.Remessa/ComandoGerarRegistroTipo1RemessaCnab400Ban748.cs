using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban748;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo1RemessaCnab400Ban748 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo1RemessaCnab400Ban748()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban748.REGISTRO_TIPO_1.Codigo();
			if (base.Carteira is CarteiraCobrancaBan748CodigoA)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoCobranca.Valor = "A";
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoCobranca.Valor = "B";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoCarteira.Valor = "A";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoImpressao.Valor = "A";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler1.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoMoeda.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo();
			ConfigurarDesconto();
			ConfigurarJuros();
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler2.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler3.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).DataInstrucao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.AAAAMMDD, CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa) && ((EnumCodigoMovimentoRemessa)(object)base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>()).Equals(EnumCodigoMovimentoRemessa.ALTERACAO_DE_OUTROS_DADOS))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CampoAlterado.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CAMPO_ALTERADO, (base.Carteira.ParametrosDisponiveis.Documento as ParametrosAdicionaisDisponiveisDocumentoCobrancaBan748).CampoAlterado(), base.Documento.ParametrosAdicionais).ToEnum<EnumCampoAlteradoDocumentoCobranca>()
					.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao) && ((EnumCodigoMovimentoRemessa)(object)base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>()).Equals(EnumCodigoMovimentoRemessa.ALTERACAO_DE_OUTROS_DADOS))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CampoAlterado.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CAMPO_ALTERADO, (base.Carteira.ParametrosDisponiveis.Documento as ParametrosAdicionaisDisponiveisDocumentoCobrancaBan748).CampoAlterado(), base.Documento.ParametrosAdicionais).ToEnum<EnumCampoAlteradoDocumentoCobranca>()
					.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CampoAlterado.Valor = "";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).PostagemTitulo.Valor = "N";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler4.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoEmissaoBoleto.Valor = "A";
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoEmissaoBoleto.Valor = "B";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroParcelaCarne.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroTotalParcelasCarne.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler5.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorDescontoPorDiaAntecipacao.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			ConfigurarMulta();
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler6.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Instrucao.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Instrucao.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).SeuNumero.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler7.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).EspecieDocumento.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).EspecieDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			string value = (string.IsNullOrEmpty(base.Documento.CodigoProtesto) ? base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto : base.Documento.CodigoProtesto);
			int num = ((base.Documento.DiasProtesto > 0) ? base.Documento.DiasProtesto : base.Carteira.ConfiguracaoDocumentoCobranca.DiasProtesto);
			if (!string.IsNullOrEmpty(value) && value.ToEnum<EnumCodigoProtesto>().Equals(EnumCodigoProtesto.PROTESTO_NORMAL))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).InstrucaoProtestoAutomatico.Valor = value.ToEnum<EnumCodigoProtesto>().Codigo();
				if (num <= 0)
				{
					(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroDiasProtestoAutomatico.Valor = "0";
				}
				else if (num > 2)
				{
					(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroDiasProtestoAutomatico.Valor = (string)base.IntConverter.Convert(num, typeof(string), null, CultureInfo.CurrentCulture);
				}
				else
				{
					(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroDiasProtestoAutomatico.Valor = (string)base.IntConverter.Convert(3, typeof(string), null, CultureInfo.CurrentCulture);
				}
			}
			if (!string.IsNullOrEmpty(value) && value.ToEnum<EnumCodigoProtesto>().Equals(EnumCodigoProtesto.NEGATIVAR_AUTOMATICAMENTE2))
			{
				string text = value.ToEnum<EnumCodigoProtesto>().Codigo();
				text = ((num <= 0) ? (text + Enumerable.Repeat("0", 11)) : ((num <= 2) ? (text + StringUtil.ZerosLeft((string)base.IntConverter.Convert(3, typeof(string), null, CultureInfo.CurrentCulture), 2) + "000000000") : (text + StringUtil.ZerosLeft((string)base.IntConverter.Convert(num, typeof(string), null, CultureInfo.CurrentCulture), 2) + "000000000")));
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler8.Valor = text;
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler9.Valor = "0";
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CodigoPagadorNaCooperativa.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler10.Valor = "0";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).Filler11.Valor = "";
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).CodigoPagadorNoBeneficiario.Valor = "0";
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.ZerosLeft(StringUtil.RemoverMascara(base.Documento.CnpjAvalista), 14);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = StringUtil.ZerosLeft(StringUtil.RemoverMascara(base.Documento.CpfAvalista), 14);
			}
			else
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroInscricaoSacadorAvalista.Valor = "";
			}
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as RegistroTipo1RemessaCnab400Ban748).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).PercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoDesconto.Valor = EnumCodigoDesconto.VALOR.Codigo();
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).DataDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorPercentualDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : EnumCodigoDesconto.VALOR));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = 0.0;
			switch (enumCodigoDesconto)
			{
			case EnumCodigoDesconto.VALOR:
				num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoDesconto.PERCENTUAL:
				num = ((base.Documento.ValorDesconto > 0.0) ? (base.Documento.ValorDesconto / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualDesconto > 0.0) ? base.Documento.PercentualDesconto : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoDesconto.Valor = enumCodigoDesconto.Codigo();
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorPercentualDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoJuros.Valor = EnumCodigoJuros.VALOR.Codigo();
		(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.VALOR));
			double num = 0.0;
			switch (enumCodigoJuros)
			{
			case EnumCodigoJuros.VALOR:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoJuros.PERCENTUAL:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? base.Documento.PercentualJurosDiaAtraso : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).TipoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as RegistroTipo1RemessaCnab400Ban748).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
