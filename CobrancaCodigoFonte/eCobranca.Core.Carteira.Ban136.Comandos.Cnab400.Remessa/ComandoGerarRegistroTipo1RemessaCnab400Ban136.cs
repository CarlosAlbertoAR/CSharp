using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Remessa;

public class ComandoGerarRegistroTipo1RemessaCnab400Ban136 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarRegistroTipo1RemessaCnab400Ban136()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNICRED}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNICRED}]...");
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban136.REGISTRO_TIPO1.Codigo();
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoAgencia.Valor = StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1), 5);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DVAgencia.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 2);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ContaCorrente.Valor = StringUtil.ZerosLeft(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1), 12);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DVContaCorrente.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler1.Valor = StringUtil.ZerosLeft(string.Empty, 1);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoCarteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler2.Valor = StringUtil.ZerosLeft(string.Empty, 13);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NumeroControleParticipante.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoBanco.Valor = EnumCodigoBanco.UNICRED.Codigo();
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler3.Valor = StringUtil.ZerosLeft(string.Empty, 2);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler4.Valor = StringUtil.ObterStringComBrancos(25);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler5.Valor = StringUtil.ZerosLeft(string.Empty, 1);
			ConfigurarMulta();
			ConfigurarJuros();
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler6.Valor = "N";
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler7.Valor = StringUtil.ObterStringComBrancos(2);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoOcorrencia.Valor = ((!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa)) ? base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo() : EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo());
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorNominal.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler8.Valor = StringUtil.ZerosLeft(string.Empty, 3);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler9.Valor = StringUtil.ZerosLeft(string.Empty, 5);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler10.Valor = StringUtil.ZerosLeft(string.Empty, 2);
			ConfigurarDesconto();
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler11.Valor = StringUtil.ZerosLeft(string.Empty, 1);
			ConfigurarProtesto();
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).Filler12.Valor = StringUtil.ZerosLeft(string.Empty, 2);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorAbatimento, typeof(string), "F2", CultureInfo.CurrentCulture);
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo().Substring(1);
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NumeroInscricaoPagador.Valor = "000" + StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo().Substring(1);
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).EnderecoPagador.Valor = ((!string.IsNullOrEmpty(base.Documento.NumeroEnderecoPagador)) ? (base.Documento.EnderecoPagador + ", " + base.Documento.NumeroEnderecoPagador) : base.Documento.EnderecoPagador);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).SacadorAvalista.Valor = "";
			(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.UNICRED, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoDesconto.Valor = EnumCodigoDesconto.SEM_DESCONTO.Codigo();
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DataLimiteDesconto.Valor = "0";
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			EnumCodigoDesconto enumCodigoDesconto = ((!string.IsNullOrEmpty(base.Documento.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Documento.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto)) ? ((EnumCodigoDesconto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto.ToEnum<EnumCodigoDesconto>()) : EnumCodigoDesconto.SEM_DESCONTO));
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoDesconto.Valor = enumCodigoDesconto.Codigo();
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoJuros.Valor = EnumCodigoJuros.ISENTO5.Codigo();
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorJuros.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			EnumCodigoJuros enumCodigoJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros)) ? ((EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>()) : EnumCodigoJuros.ISENTO5));
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoJuros.Valor = enumCodigoJuros.Codigo();
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorJuros.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoMulta.Valor = EnumCodigoMulta.ISENTO2.Codigo();
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorPercentualMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : (string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta) ? EnumCodigoMulta.VALOR_FIXO : ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>())));
			double num = 0.0;
			num = ((enumCodigoMulta != EnumCodigoMulta.PERCENTUAL) ? ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0)) : ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0)));
			if (num > 0.0)
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).ValorPercentualMulta.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarProtesto()
	{
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoProtesto.Valor = EnumCodigoProtesto.NAO_PROTESTAR.Codigo();
		(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DiasProtesto.Valor = "0";
		if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto))
		{
			EnumCodigoProtesto enumCodigoProtesto = ((!string.IsNullOrEmpty(base.Documento.CodigoProtesto)) ? ((EnumCodigoProtesto)(object)base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>()) : ((!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto)) ? ((EnumCodigoProtesto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>()) : EnumCodigoProtesto.NAO_PROTESTAR));
			int num = ((base.Documento.DiasProtesto > 0) ? base.Documento.DiasProtesto : 0);
			num = ((num > 99) ? 99 : num);
			if (num > 0)
			{
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).CodigoProtesto.Valor = enumCodigoProtesto.Codigo();
				(base.Segmento as IRegistroTipo1RemesaCnab400Ban136).DiasProtesto.Valor = (string)base.IntConverter.Convert(num, typeof(string), null, CultureInfo.CurrentCulture);
			}
		}
	}
}
