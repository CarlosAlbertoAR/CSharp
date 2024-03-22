using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Core.Parametros.Ban341;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheRemessaCnab400Ban341 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_ITAU}]...");
			(base.Segmento as DetalheRemessaCnab400Ban341).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban341.DETALHE.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban341).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban341).Filler1.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban341).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban341).DVAgenciaContaBeneficiario.Valor = DVGenerator.GetDVModulo10(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1));
			(base.Segmento as DetalheRemessaCnab400Ban341).Filler2.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban341).CondigoInstrucaoOuAlegacaoASerCancelada.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban341).IdentificacaoTituloBeneficiario.Valor = base.Documento.NumeroControle;
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).NossoNumero.Valor = "0";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).QuantidadeMoedaVariavel.Valor = "0";
			(base.Segmento as DetalheRemessaCnab400Ban341).NumeroCarteiraNoBanco.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban341).IdentificacaoOperacaoNoBanco.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban341).CodigoCarteira.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Sigla();
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban341).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban341).ValorNominalTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban341).CodigoBanco.Valor = EnumCodigoBanco.BANCO_ITAU.Codigo();
			(base.Segmento as DetalheRemessaCnab400Ban341).CodigoAgenciaCobradora.Valor = "0";
			if (string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoAceite.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoAceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_PRIMEIRA_INSTRUCAO_COBRANCA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).PrimeiraInstrucaoCobranca(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban341).InstrucaoCobranca1.Valor = valorParametroAdicional.ToEnum<EnumInstrucaoCobranca>().Codigo();
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_SEGUNDA_INSTRUCAO_COBRANCA, (base.Carteira.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan341).SegundaInstrucaoCobranca(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			(base.Segmento as DetalheRemessaCnab400Ban341).InstrucaoCobranca2.Valor = valorParametroAdicional2.ToEnum<EnumInstrucaoCobranca>().Codigo();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as DetalheRemessaCnab400Ban341).ValorIOF.Valor = "0";
			if (base.Documento.ValorAbatimento > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).ValorAbatimento.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDesconto, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).ValorAbatimento.Valor = "0";
			}
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban341).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban341).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as DetalheRemessaCnab400Ban341).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban341).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban341).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban341).UFPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban341).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as DetalheRemessaCnab400Ban341).Filler4.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban341).DataJuros.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban341).QuantidadeDias.Valor = "0";
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).QuantidadeDias.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else if (base.Documento.DiasBaixaDevolucao > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).QuantidadeDias.Valor = (string)base.IntConverter.Convert(base.Documento.DiasBaixaDevolucao, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).QuantidadeDias.Valor = "0";
			}
			(base.Segmento as DetalheRemessaCnab400Ban341).Filler5.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban341).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_ITAU, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as DetalheRemessaCnab400Ban341).DataDesconto.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
		(base.Segmento as DetalheRemessaCnab400Ban341).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoDesconto) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoDesconto))
		{
			DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
			double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).DataDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
				(base.Segmento as DetalheRemessaCnab400Ban341).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as DetalheRemessaCnab400Ban341).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoJuros) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros))
		{
			double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			if (num > 0.0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban341).ValorJurosAoDia.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
