using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban084;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban084 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban084()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).CodigoBeneficiario.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).CodigoBanco.Valor = EnumCodigoBanco.UNIPRIME_NORTE_PARANA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).NomeBanco.Valor = EnumCodigoBanco.UNIPRIME_NORTE_PARANA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).IdentificacaoSistema.Valor = EnumIdentificacaoSistema.MX.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).NumeroSequencialRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban084).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.UNIPRIME_NORTE_PARANA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
