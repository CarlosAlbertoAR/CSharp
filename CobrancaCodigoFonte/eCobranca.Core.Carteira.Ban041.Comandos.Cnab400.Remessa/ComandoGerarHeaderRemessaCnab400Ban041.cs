using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban041 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1) + StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).IdentificacaoBanco.Valor = EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.Codigo() + EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler4.Valor = "0";
			EnumTipoCarteiraCobranca enumTipoCarteiraCobranca = (EnumTipoCarteiraCobranca)(object)base.Carteira.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>();
			if ((uint)(enumTipoCarteiraCobranca - 39) <= 1u)
			{
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).CodigoServico.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor);
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).TipoProcessamento.Valor = "P";
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).CodigoClienteOfficeBanking.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[8]).Valor);
			}
			else
			{
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).CodigoServico.Valor = StringUtil.ObterStringComBrancos(4);
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).TipoProcessamento.Valor = StringUtil.ObterStringComBrancos(1);
				(base.Arquivo.Header as HeaderRemessaCnab400Ban041).CodigoClienteOfficeBanking.Valor = "";
			}
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler5.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler6.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).Filler7.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban041).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
