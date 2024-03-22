using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban021.Comandos.Cnab400.Remessa;

public class ComandoGerarHeaderRemessaCnab400Ban021 : ComandoGerarSegmentoArquivoRemessaCnab400
{
	public ComandoGerarHeaderRemessaCnab400Ban021()
	{
		Logger.Debug($"Criando comando para gerar o HEADER da remessa CNAB400 da carteira do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa CNAB400 da carteira cobrança do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).IdentificacaoRegistro.Valor = EnumTipoRegistroCnab400.HEADER.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).IdentificacaoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).IdentificacaoRemessaLiteral.Valor = EnumTipoOperacao.REMESSA.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).CodigoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).LiteralServico.Valor = EnumTipoServico.COBRANCA.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).CodigoBeneficiario.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).Filler1.Valor = "";
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).CodigoBanco.Valor = EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Codigo();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).NomeBanco.Valor = EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO.Sigla();
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAA, CultureInfo.CurrentCulture);
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).Filler2.Valor = "";
			(base.Arquivo.Header as IHeaderRemessaCnab400Ban021).NumeroSequencialRegistro.Valor = base.Arquivo.Header.Sequencia.ToString();
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
