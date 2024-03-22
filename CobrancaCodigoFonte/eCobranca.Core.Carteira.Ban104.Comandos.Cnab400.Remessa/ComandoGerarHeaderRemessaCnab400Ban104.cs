using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban104 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban104()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).IdentificadorRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).IdentificadorRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).IdentidicadorRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).TipoServicoLiteral.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).CodigoAgenciaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).CodigoBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[2]).Valor, 1);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).Filler1.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).CodigoBanco.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).NomeBanco.Valor = EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).DataGeracao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).NumeroSequencialRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban104).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
