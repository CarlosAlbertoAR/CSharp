using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban399 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban399()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).IdentificacaoTipoOperacao.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).IdentificacaoTipoOperacaoExtenso.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).IdentificacaoTipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).IdentificacaoTipoServicoExtenso.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).Filler1.Valor = "0";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).AgenciaBeneficiario.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).SubContaBeneficiario.Valor = "55";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).NumeroContaCorrenteBeneficiario.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor + StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).Filler2.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).CodigoBanco.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).NomeBanco.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Sigla();
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).DensidadeGravacao.Valor = "01600";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).UnidadeDensidadeGravacao.Valor = "BPI";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).Filler3.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).SiglaLayoutTecnico.Valor = "LANCV08";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).Filler4.Valor = "";
			(base.Arquivo.Header as HeaderRemessaCnab400Ban399).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaCNAB400(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
