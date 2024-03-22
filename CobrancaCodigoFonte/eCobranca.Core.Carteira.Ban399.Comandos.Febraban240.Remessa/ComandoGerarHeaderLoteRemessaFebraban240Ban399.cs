using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban399 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarHeaderLoteRemessaFebraban240Ban399()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.HSBC_BANK_BRASIL.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroVersaoLayoutLote.Valor = "010";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoConvenioBanco.Valor = "COBCNAB00" + (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor.Substring(0, 4) + StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(0, 7);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).CodigoAgencia.Valor = (base.Carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor.Substring(0, 4);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgencia.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroContaCorrente.Valor = StringUtil.RemoverMascara((base.Carteira.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(0, 7);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVContaCorrente.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DVAgenciaContaCorrente.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).Mensagem2.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).NumeroRemessaRetorno.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataGravacaoRemessaRetorno.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).DataCredito.Valor = "0";
			(base.Lote.HeaderLote as HeaderLoteFebraban240Padrao).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.HSBC_BANK_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
