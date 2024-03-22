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

public class ComandoGerarHeaderRemessaCnab400Ban422 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban422()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).LiteralServico.Valor = "Cobrança";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).Filler1.Valor = StringUtil.ObterStringComBrancos(7);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).CodigoBeneficiario.Valor = StringUtil.TruncateString(StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor), 5) + StringUtil.TruncateString(StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor), 9);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).Filler2.Valor = StringUtil.ObterStringComBrancos(6);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).CodigoBanco.Valor = EnumCodigoBanco.BANCO_SAFRA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).NomeBanco.Valor = EnumCodigoBanco.BANCO_SAFRA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).Filler3.Valor = StringUtil.ObterStringComBrancos(4);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).Filler4.Valor = StringUtil.ObterStringComBrancos(291);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).NumeroSequencialRemessa.Valor = (string)base.IntConverter.Convert(base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa, typeof(string), null, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban422).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_SAFRA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
