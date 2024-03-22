using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban133.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban133 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban133()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.CRESOL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).CodigoBanco.Valor = EnumCodigoBanco.CRESOL.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).NomeBanco.Valor = EnumCodigoBanco.CRESOL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).DataGravacao.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).IdentificacaoSistema.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).NumeroSequencialRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban133).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.CRESOL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
