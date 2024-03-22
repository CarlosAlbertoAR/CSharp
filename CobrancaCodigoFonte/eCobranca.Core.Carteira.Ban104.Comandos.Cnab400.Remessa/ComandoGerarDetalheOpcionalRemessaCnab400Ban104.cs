using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Remessa;

public class ComandoGerarDetalheOpcionalRemessaCnab400Ban104 : ComandoGerarSegmentoDetalheRemessaCnab400
{
	public ComandoGerarDetalheOpcionalRemessaCnab400Ban104()
	{
		Logger.Debug($"Criando comando para gerar o DETALHE da remessa CNAB400 da carteira do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o DETALHE da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).IdentificadorRegistro.Valor = EnumTipoSegmentoDetalheCnab400Ban104.DETALHE_OPCIONAL.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).TipoInscricaoBeneficiario.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).NumeroInscricaoBeneficiario.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 1);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Filler1.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Filler2.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.BancoEmiteBoleto)
			{
				if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
				{
					(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Modalidade.Valor = "11";
				}
				else
				{
					(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Modalidade.Valor = "21";
				}
			}
			else if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Modalidade.Valor = "14";
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Modalidade.Valor = "24";
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).NossoNumero.Valor = StringUtil.RemoverMascara(base.Documento.NossoNumero).Substring(2, 15);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Filler3.Valor = "";
			if (base.Carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoCarteira.Valor = "01";
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoCarteira.Valor = "02";
			}
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoOcorrencia.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoOcorrencia.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Filler4.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).CodigoBanco.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem1.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM1_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem1Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem2.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM2_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem2Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem3.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM3_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem3Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem4.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM4_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem4Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem5.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM5_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem5Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Mensagem6.Valor = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_MENSAGEM6_BOLETO, base.Carteira.ParametrosDisponiveis.Documento.Mensagem6Boleto(), base.Documento.ParametrosAdicionais);
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).Filler5.Valor = "";
			(base.Segmento as DetalheOpcionalRemessaCnab400Ban104).NumeroSequencialRegistro.Valor = base.Segmento.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarDetalheArquivoRemessaCNAB400(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
