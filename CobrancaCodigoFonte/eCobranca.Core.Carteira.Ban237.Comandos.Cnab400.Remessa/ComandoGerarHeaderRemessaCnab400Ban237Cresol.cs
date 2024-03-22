using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban237Cresol : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban237Cresol()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).CodigoBeneficiario.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).NomeBeneficiario.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).CodigoBanco.Valor = EnumCodigoBanco.CRESOL.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).NomeBanco.Valor = EnumCodigoBanco.CRESOL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).DataGravacao.Valor = StringUtil.ObterStringComBrancos(6);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).IdentificacaoSistema.Valor = StringUtil.ObterStringComBrancos(2);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).NumeroSequencialRemessa.Valor = StringUtil.ObterStringComBrancos(7);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban237).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.BANCO_BRADESCO, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
