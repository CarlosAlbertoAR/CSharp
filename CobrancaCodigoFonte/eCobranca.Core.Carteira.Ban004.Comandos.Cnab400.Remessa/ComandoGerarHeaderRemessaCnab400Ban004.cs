using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban004.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban004 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban004()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).IdentificacaoTipoOperacao.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).IdentificacaoTipoOperacaoExtenso.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).IdentificacaoTipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).IdentificacaoTipoServicoExtenso.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).AgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).Filler1.Valor = "0";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).ContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).DigitoContaCorrenteBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 2);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).NumeroBanco.Valor = EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).NomeBanco.Valor = EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).CodigoUsuario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[6]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).Filler3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban004).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
