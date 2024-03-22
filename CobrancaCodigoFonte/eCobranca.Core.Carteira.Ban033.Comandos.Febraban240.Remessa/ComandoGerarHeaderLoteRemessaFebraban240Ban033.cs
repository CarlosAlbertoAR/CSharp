using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarHeaderLoteRemessaFebraban240Ban033 : ComandoGerarSegmentoLoteRemessaFebraban240
{
	public ComandoGerarHeaderLoteRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o HEADER DE LOTE da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).LoteServico.Valor = base.Lote.SequenciaLote.ToString();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.HEADER_DE_LOTE.Codigo();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).TipoOperacao.Valor = EnumTipoOperacao.ARQUIVO_REMESSA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).TipoServico.Valor = EnumTipoServico.COBRANCA.Codigo();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).UsoReservadoBanco1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).NumeroVersaoLayoutLote.Valor = "030";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).UsoReservadoBanco2.Valor = "";
			if (StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario).Length == 14)
			{
				(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else
			{
				(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).TipoInscricaoEmpresa.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).NumeroInscricaoEmpresa.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).UsoReservadoBanco3.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).CodigoTransmissao.Valor = ((DadoConfiguracao)base.Carteira.DadosConfiguracao[3]).Valor;
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).UsoReservadoBanco4.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).NomeCedente.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).Mensagem1.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).Mensagem2.Valor = "";
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).NumeroRemessaRetorno.Valor = base.Carteira.ConfiguracaoArquivoRemessa.SequenciaRemessa.ToString();
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).DataGravacaoRemessaRetorno.Valor = (string)base.DateConverter.Convert(DateTime.Today, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			(base.Lote.HeaderLote as HeaderLoteRemessaFebraban240Ban033).UsoReservadoBanco5.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarHeaderLoteRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
