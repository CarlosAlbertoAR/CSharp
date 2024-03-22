using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarHeaderLoteRemessaFebraban240Ban756CorrespondenteBancoBrasil()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler1.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler2.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler3.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).CodigoCooperativaBeneficiario.Valor = StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.Carteira.DadosConfiguracao[0]).Valor, 1);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).CodigoCobranca.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[7]).Valor);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).NumeroContaCorrente.Valor = StringUtil.RemoverMascara(((DadoConfiguracao)base.Carteira.DadosConfiguracao[1]).Valor);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler4.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).NomeBeneficiario.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler5.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).NumeroRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).DataGravacao.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler6.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Ban756CorrespondenteBancoBrasil).Filler7.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
