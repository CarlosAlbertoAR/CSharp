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

public class ComandoGerarDetalheRemessaCnab400Ban097CobrancaSimples : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheRemessaCnab400Ban097CobrancaSimples()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).IdentificacaoRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban097.DETALHE.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DVContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler1.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero);
			if (!string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CodigoOperacao.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CodigoOperacao.Valor = EnumCodigoMovimentoRemessa.ENTRADA_DE_TITULOS.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DataOperacao.Valor = (string)base.DateConverter.Convert(DateTime.Now, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler2.Valor = "";
			if (base.Documento.NumeroParcelaCarnet > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroParcela.Valor = (string)base.IntConverter.Convert(base.Documento.NumeroParcelaCarnet, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroParcela.Valor = (string)base.IntConverter.Convert(1, typeof(string), null, CultureInfo.CurrentCulture);
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoPagamento.Valor = "3";
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoRecebimento.Valor = "3";
			if (!string.IsNullOrEmpty(base.Documento.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).EspecieTitulo.Valor = base.Documento.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).EspecieTitulo.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.TipoDocumentoCobranca.ToEnum<EnumTipoDocumentoCobranca>().Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CodigoProtesto) && !base.Documento.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR3.ToString()))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoProtesto.Valor = base.Documento.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto) && !base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.Equals(EnumCodigoProtesto.NAO_PROTESTAR3.ToString()))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoProtesto.Valor = base.Carteira.ConfiguracaoDocumentoCobranca.CodigoProtesto.ToEnum<EnumCodigoProtesto>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoProtesto.Valor = "";
			}
			if (base.Documento.DiasProtesto > 0)
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DiasProtesto.Valor = (string)base.IntConverter.Convert(base.Documento.DiasProtesto, typeof(string), null, CultureInfo.CurrentCulture);
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoProtesto.Valor = "";
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.REM_TIPO_ENVIO_PROTESTO_REMESSA_CNAB400, (base.Carteira.ConfiguracaoArquivoRemessa.ParametrosDisponiveis.Remessa as ParametrosAdicionaisDisponiveisConfiguracaoArquivoRemessaBan097).TipoEnvioProtesto(), base.Carteira.ConfiguracaoArquivoRemessa.ParametrosAdicionais);
			if (!string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoEnvioProtesto.Valor = valorParametroAdicional.ToEnum<EnumTipoEnvioProtesto>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoEnvioProtesto.Valor = EnumTipoEnvioProtesto.NENHUM.Codigo();
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler3.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroDocumento.Valor = base.Documento.NumeroDocumento;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DataVencimento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			if ((base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CodigoOperacao.Valor.Equals(EnumCodigoMovimentoRemessa.CANCELAMENTO.Codigo()))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).ValorOperacao.Valor = "";
			}
			else
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).ValorOperacao.Valor = (string)base.DoubleConverter.Convert(base.Documento.ValorDocumento, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DataLimitePagamento.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento.Value.AddDays(90.0), typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler4.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).DataEmissaoTitulo.Valor = (string)base.DateConverter.Convert(base.Documento.DataDocumento, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler5.Valor = "";
			if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador) + StringUtil.ObterStringComBrancos(4);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NomeFantasiaPagador.Valor = base.Documento.NomeFantasiaPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			if (!string.IsNullOrEmpty(base.Documento.NumeroEnderecoPagador))
			{
				(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroEnderecoPagador.Valor = (string)base.IntConverter.Convert(base.Documento.NumeroEnderecoPagador, typeof(string), null, CultureInfo.CurrentCulture);
			}
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).UfPagador.Valor = base.Documento.UfPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).CelularPagador.Valor = StringUtil.RemoverMascara(base.Documento.CelularPagador);
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).EmailPagador.Valor = base.Documento.EmailPagador;
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).Filler6.Valor = "";
			(base.Segmento as DetalheRemessaCnab400Ban097CobrancaSimples).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
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
}
