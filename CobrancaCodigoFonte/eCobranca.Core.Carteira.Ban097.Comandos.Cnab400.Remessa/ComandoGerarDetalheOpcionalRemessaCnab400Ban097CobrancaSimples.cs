using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban097;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheOpcionalRemessaCnab400Ban097CobrancaSimples()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban097.DETALHE_OPCIONAL.Codigo();
			if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).LogradouroSacadorAvalista.Valor = base.Documento.EnderecoSacadorAvalista;
			if (!string.IsNullOrEmpty(base.Documento.NumeroEnderecoSacadorAvalista))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).NumeroLogradouroSacadorAvalista.Valor = (string)base.IntConverter.Convert(base.Documento.NumeroEnderecoSacadorAvalista, typeof(string), null, CultureInfo.CurrentCulture);
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ComplementoSacadorAvalista.Valor = base.Documento.ComplementoSacadorAvalista;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).BairroSacadorAvalista.Valor = base.Documento.BairroSacadorAvalista;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).CidadeSacadorAvalista.Valor = base.Documento.CidadeSacadorAvalista;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).UfSacadorAvalista.Valor = base.Documento.UfSacadorAvalista;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).CepSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CepSacadorAvalista);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).Filler1.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).InstrucaoTitulo.Valor = base.Documento.InstrucaoCaixa;
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).Filler2.Valor = "";
			ConfigurarJuros();
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_JUROS_CNAB400, (base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).TipoCarenciaJuros(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoCarenciaJuros.Valor = valorParametroAdicional.ToEnum<EnumTipoCarencia>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoCarenciaJuros.Valor = EnumTipoCarencia.DIAS_CORRIDOS.Codigo();
			}
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_JUROS, (base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).CarenciaCobrancaJuros(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional2))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DiasCarenciaJuros.Valor = (string)base.IntConverter.Convert(int.Parse(valorParametroAdicional2), typeof(string), null, CultureInfo.CurrentCulture);
			}
			ConfigurarMulta();
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_TIPO_CARENCIA_MULTA_CNAB400, (base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).TipoCarenciaMulta(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional3))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoCarenciaMulta.Valor = valorParametroAdicional3.ToEnum<EnumTipoCarencia>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoCarenciaMulta.Valor = EnumTipoCarencia.DIAS_UTEIS.Codigo();
			}
			string valorParametroAdicional4 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_CARENCIA_COBRANCA_MULTA, (base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).CarenciaCobrancaMulta(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional4))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DiasCarenciaMulta.Valor = (string)base.IntConverter.Convert(int.Parse(valorParametroAdicional4), typeof(string), null, CultureInfo.CurrentCulture);
			}
			ConfigurarDesconto();
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DataSegundoDesconto.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorSegundoDesconto.Valor = "0";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoSegundoDesconto.Valor = EnumCodigoDesconto.ISENTO.Codigo();
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DataTerceiroDesconto.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorTerceiroDesconto.Valor = "0";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorTerceiroDesconto.Valor = EnumCodigoDesconto.ISENTO.Codigo();
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).Filler3.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoPrimeiroDesconto.Valor = EnumCodigoDesconto.ISENTO.Codigo();
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DataPrimeiroDesconto.Valor = "0";
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F4", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : EnumCodigoDesconto.ISENTO));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = 0.0;
			switch (enumCodigoDesconto)
			{
			case EnumCodigoDesconto.ISENTO:
				return;
			case EnumCodigoDesconto.VALOR_FIXO:
				num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoDesconto.PORCENTAGEM:
				num = ((base.Documento.ValorDesconto > 0.0) ? (base.Documento.ValorDesconto / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualDesconto > 0.0) ? base.Documento.PercentualDesconto : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoPrimeiroDesconto.Valor = enumCodigoDesconto.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).DataPrimeiroDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorPrimeiroDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoMulta.Valor = EnumCodigoMulta.ISENTO.Codigo();
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F4", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()) : EnumCodigoMulta.ISENTO));
			double num = 0.0;
			switch (enumCodigoMulta)
			{
			case EnumCodigoMulta.ISENTO:
				return;
			case EnumCodigoMulta.VALOR_FIXO2:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoMulta.PORCENTAGEM:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoJuros.Valor = EnumCodigoJuros.ISENTO4.Codigo();
		(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorJuros.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F4", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.ISENTO4));
			double num = 0.0;
			switch (enumCodigoJuros)
			{
			case EnumCodigoJuros.ISENTO4:
				return;
			case EnumCodigoJuros.VALOR_FIXO:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoJuros.PORCENTAGEM2:
				num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? (base.Documento.ValorJurosDiasAtraso / base.Documento.ValorDocumento * 100.0 * 30.0) : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso * 30.0) : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).TipoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban097CobrancaSimples).ValorJuros.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F4", CultureInfo.CurrentCulture);
			}
		}
	}
}
