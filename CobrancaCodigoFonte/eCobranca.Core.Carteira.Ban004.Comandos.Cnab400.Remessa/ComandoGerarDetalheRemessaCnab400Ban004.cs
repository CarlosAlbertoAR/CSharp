using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban004;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban004.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheRemessaCnab400Ban004 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban004()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			(base.Segmento as DetalheRemessaCnab400Ban004).CodigoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban004.DETALHE.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban004).Filler1.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban004).AgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban004).Filler2.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban004).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban004).DigitoContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			ConfigurarMulta();
			(base.Segmento as DetalheRemessaCnab400Ban004).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban004).NumeroControle.Valor = base.Documento.NumeroControle;
			(base.Segmento as DetalheRemessaCnab400Ban004).NossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 1);
			(base.Segmento as DetalheRemessaCnab400Ban004).DigitoNossoNumero.Valor = StringUtil.ObterValorDeCampoMascarado(base.Documento.NossoNumero, 2);
			if (base.Carteira is CarteiraCobrancaBan004Codigo241 || base.Carteira is CarteiraCobrancaBan004Codigo541)
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).NumeroContrato.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor;
			}
			(base.Segmento as DetalheRemessaCnab400Ban004).DataSegundoDesconto.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban004).ValorSegundoDesconto.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban004).Filler4.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban004).Carteira.Valor = base.Carteira.GetCodigoCarteiraImpressao().Substring(0, 1);
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoServico.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoServico.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoServico.Valor = EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban004).SeuNumero.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban004).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban004).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban004).NumeroBanco.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban004).AgenciaCobradora.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban004).Filler5.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Especie.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Especie.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Especie.Valor = EnumTipoDocumentoCobranca.DM2.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Aceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Aceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).Aceite.Valor = EnumTipoAceite.N.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban004).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban004).CodigoInstrucao.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_INSTRUCAO, ((ParametrosAdicionaisDisponiveisDocumentoCobrancaBan004)base.Carteira.ParametrosDisponiveis.Documento).CodigoInstrucao(), base.Documento.ParametrosAdicionais).ToEnum<EnumCodigoInstrucao>()
				.Codigo();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as DetalheRemessaCnab400Ban004).ValorIOC.Valor = "0";
			if (base.Documento.ValorAbatimento > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).ValorAbatimento.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).NumeroInscricaoPagador.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban004).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban004).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban004).ComplementoEnderecoPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban004).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban004).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban004).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban004).MensageOuNomeSacadorAvalista.Valor = GetInfoAvalista();
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).PrazoProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(int), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).PrazoProtesto.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.Moeda))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoMoeda.Valor = base.Documento.Moeda.ToEnum<EnumCodigoMoeda>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda))
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoMoeda.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMoeda.ToEnum<EnumCodigoMoeda>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).CodigoMoeda.Valor = EnumCodigoMoeda.REAL6.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban004).SequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as DetalheRemessaCnab400Ban004).DataDesconto.Valor = "0";
		(base.Segmento as DetalheRemessaCnab400Ban004).ValorDesconto.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : EnumCodigoDesconto.SEM_DESCONTO));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = 0.0;
			switch (enumCodigoDesconto)
			{
			case EnumCodigoDesconto.SEM_DESCONTO:
				return;
			case EnumCodigoDesconto.VALOR_FIXO_ATE_A_DATA_INFORMADA:
				num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban004).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban004).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as DetalheRemessaCnab400Ban004).JurosDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.ISENTO2));
		double num = 0.0;
		switch (enumCodigoJuros)
		{
		case EnumCodigoJuros.ISENTO2:
		case EnumCodigoJuros.COMISSAO_PERMANENCIA_BANCO:
			return;
		case EnumCodigoJuros.VALOR_POR_DIA:
			num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			break;
		}
		if (num > 0.0)
		{
			(base.Segmento as DetalheRemessaCnab400Ban004).JurosDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as DetalheRemessaCnab400Ban004).TaxaMulta.Valor = "0";
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
				(base.Segmento as DetalheRemessaCnab400Ban004).TaxaMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F0", CultureInfo.CurrentCulture);
			}
		}
	}

	private string GetInfoAvalista()
	{
		string result = "";
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
}
