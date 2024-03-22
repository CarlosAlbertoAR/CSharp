using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Cnab400.Remessa;

public class ComandoGerarTransacaoTipo1RemessaCnab400Ban422 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	private const string INSTRUCAO_DE_JUROS = "01";

	private const string INSTRUCAO_DE_BAIXA_15_DIAS = "02";

	private const string INSTRUCAO_DE_BAIXA_30_DIAS = "03";

	private const string INSTRUCAO_NAO_PROTESTAR = "07";

	private const string INSTRUCAO_NAO_COBRAR_JUROS = "08";

	private const string INSTRUCAO_DE_MULTA = "16";

	private const string INSTRUCAO_DE_PROTESTO = "10";

	private bool possuiJuros;

	private bool possuiMulta;

	private bool possuiProtesto;

	public ComandoGerarTransacaoTipo1RemessaCnab400Ban422()
	{
		Logger.Debug($"Criando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o REGISTRO TRANSAÇÃO TIPO 1 da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban422.TRANSACAO_TIPO_1.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).TipoInscricaoBeneficiario.Valor = (base.Carteira.ConfiguracaoCarteiraCobranca.TipoInscricaoBeneficiario.Equals(EnumTipoInscricao.CPF.ToString()) ? EnumTipoInscricao.CPF.Codigo() : EnumTipoInscricao.CNPJ.Codigo());
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Trim();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoBeneficiario.Valor = StringUtil.ZerosLeft(StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor), 5) + StringUtil.ZerosLeft(StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor), 9);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Filler1.Valor = StringUtil.ObterStringComBrancos(6);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).UsoExclusivoBeneficiario.Valor = StringUtil.TruncateString(base.Documento.NumeroControle, 25);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero).Trim();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Filler2.Valor = StringUtil.ObterStringComBrancos(30);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoIof.Valor = "0";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoMoeda.Valor = ((!string.IsNullOrEmpty(base.Documento.Moeda)) ? base.Documento.Moeda.ToEnum<EnumCodigoMoeda>().Codigo() : "00");
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Filler3.Valor = StringUtil.ObterStringComBrancos(1);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoCarteira.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).SeuNumero.Valor = StringUtil.TruncateString(base.Documento.NumeroDocumento, 10);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorNominalTitulo.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).BancoEncarregadoCobranca.Valor = EnumCodigoBanco.BANCO_SAFRA.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).AgenciaEncarregadaCobranca.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor).Trim();
			if (!string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).EspecieDocumento.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).EspecieDocumento.Valor = EnumTipoDocumentoCobranca.DM2.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.Aceite))
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoAceite.Valor = base.Documento.Aceite.ToEnum<EnumTipoAceite>().Codigo();
			}
			else
			{
				(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CodigoAceite.Valor = EnumTipoAceite.N.Codigo();
			}
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).DataEmissao.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			ConfigurarInstrucoesCobranca();
			ConfigurarJuros();
			ConfigurarDesconto();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorIof.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
			ConfigurarMulta();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).TipoInscricaoPagador.Valor = ((!string.IsNullOrEmpty(base.Documento.CpfPagador)) ? EnumTipoInscricao.CPF.Codigo() : EnumTipoInscricao.CNPJ.Codigo());
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NumeroInscricaoPagador.Valor = ((!string.IsNullOrEmpty(base.Documento.CpfPagador)) ? StringUtil.RemoverMascara(base.Documento.CpfPagador) : StringUtil.RemoverMascara(base.Documento.CnpjPagador));
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).EnderecoPagador.Valor = base.Documento.EnderecoPagador + ", " + base.Documento.NumeroEnderecoPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Filler4.Valor = StringUtil.ObterStringComBrancos(2);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Filler5.Valor = StringUtil.ObterStringComBrancos(7);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).BancoEmiteBoleto.Valor = EnumCodigoBanco.BANCO_SAFRA.Codigo();
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NumeroSequencialArquivoRemessa.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).NumeroSequencialRegistroArquivo.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SAFRA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarInstrucoesCobranca()
	{
		possuiJuros = ((!string.IsNullOrEmpty(base.Documento.CodigoJuros) && (EnumCodigoJuros)(object)base.Documento.CodigoJuros.ToEnum<EnumCodigoJuros>() == EnumCodigoJuros.VALOR_POR_DIA) || (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros) && (EnumCodigoJuros)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoJuros.ToEnum<EnumCodigoJuros>() == EnumCodigoJuros.VALOR_POR_DIA)) && (base.Documento.PercentualJurosDiaAtraso > 0.0 || base.Documento.ValorJurosDiasAtraso > 0.0);
		possuiMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta) && ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>() == EnumCodigoMulta.VALOR_FIXO || (EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>() == EnumCodigoMulta.PERCENTUAL)) || (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta) && ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>() == EnumCodigoMulta.VALOR_FIXO || (EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>() == EnumCodigoMulta.PERCENTUAL))) && (base.Documento.ValorMultaAtraso > 0.0 || base.Documento.PercentualMultaAtraso > 0.0);
		possuiProtesto = ((!string.IsNullOrEmpty(base.Documento.CodigoProtesto) && (EnumCodigoProtesto)(object)base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>() == EnumCodigoProtesto.PROTESTO_NORMAL) || (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto) && (EnumCodigoProtesto)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>() == EnumCodigoProtesto.PROTESTO_NORMAL)) && base.Documento.DiasProtesto > 0;
		EnumModalidadeCarteiraCobranca enumModalidadeCarteiraCobranca = ((!string.IsNullOrEmpty(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor)) ? ((EnumModalidadeCarteiraCobranca)(object)((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor.ToEnum<EnumModalidadeCarteiraCobranca>()) : EnumModalidadeCarteiraCobranca.COBRANCA_SIMPLES);
		if (possuiJuros && possuiMulta && !possuiProtesto && (enumModalidadeCarteiraCobranca == EnumModalidadeCarteiraCobranca.COBRANCA_SIMPLES || enumModalidadeCarteiraCobranca == EnumModalidadeCarteiraCobranca.COBRANCA_VINCULADA))
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao1.Valor = "01";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao2.Valor = "16";
		}
		else if (possuiJuros && !possuiMulta && possuiProtesto && enumModalidadeCarteiraCobranca == EnumModalidadeCarteiraCobranca.COBRANCA_SIMPLES)
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao1.Valor = "01";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao2.Valor = "10";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao3.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
		}
		else if (enumModalidadeCarteiraCobranca == EnumModalidadeCarteiraCobranca.COBRANCA_SIMPLES)
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao1.Valor = "16";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao2.Valor = "10";
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).Instrucao3.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
		}
	}

	private void ConfigurarDesconto()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).DataLimiteDesconto.Valor = "0";
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		DateTime? dateTime = (base.Documento.DataLimiteDesconto.HasValue ? base.Documento.DataLimiteDesconto : base.Documento.DataVencimento);
		double num = ((base.Documento.ValorDesconto > 0.0) ? base.Documento.ValorDesconto : ((base.Documento.PercentualDesconto > 0.0) ? (base.Documento.PercentualDesconto / 100.0 * base.Documento.ValorDocumento) : 0.0));
		if (num > 0.0)
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).DataLimiteDesconto.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorDesconto.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}

	private void ConfigurarJuros()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).JurosDiario.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		double num = ((base.Documento.ValorJurosDiasAtraso > 0.0) ? base.Documento.ValorJurosDiasAtraso : ((base.Documento.PercentualJurosDiaAtraso > 0.0) ? (base.Documento.PercentualJurosDiaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
		if (num > 0.0)
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).JurosDiario.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorAbatimentoOuMulta.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		double num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
		if (num > 0.0)
		{
			(base.Segmento as RegistroTransacaoTipo1RemessaCnab400Ban422).ValorAbatimentoOuMulta.Valor = base.Documento.DataVencimento.Value.AddDays(1.0).ToString("ddMMyy") + StringUtil.ZerosLeft(StringUtil.TruncateString((string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture), 4), 4) + StringUtil.ZerosLeft(string.Empty, 3);
		}
	}
}
