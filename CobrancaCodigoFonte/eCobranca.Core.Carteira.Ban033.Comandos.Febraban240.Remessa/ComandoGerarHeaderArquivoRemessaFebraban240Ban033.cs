using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderArquivoRemessaFebraban240Ban033 : ComandoGerarSegmentoArquivoRemessaFebraban240
{
	public ComandoGerarHeaderArquivoRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240  do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE ARQUIVO da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).LoteServico.Valor = "0000";
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_ARQUIVO.Codigo();
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco1.Valor = StringUtil.ObterStringComBrancos(8) + EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco1.Valor = StringUtil.ObterStringComBrancos(8) + EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).CodigoTransmissao.Valor = StringUtil.ZerosLeft(((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor, 15);
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco2.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).NomeEmpresa.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).NomeBanco.Valor = EnumCodigoBanco.BANCO_SANTANDER.Sigla();
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco3.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).CodigoRemessa.Valor = EnumTipoOperacao.REMESSA.Codigo();
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).DataGeracaoArquivo.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco4.Valor = "";
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).NumeroSequencialArquivo.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).NumeroVersaoLayoutArquivo.Valor = "040";
			(base.Arquivo.HeaderArquivo as HeaderArquivoRemessaFebraban240Ban033).UsoReservadoBanco5.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderArquivoRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
