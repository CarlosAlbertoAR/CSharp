using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoRRemessaFebraban240Ban422 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoRRemessaFebraban240Ban422()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO R da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SAFRA.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).LoteServico.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_R.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMovimento.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMovimento.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.CodigoDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto2.Valor = valorParametroAdicional.ToEnum<EnumCodigoDesconto>().Codigo();
			}
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional2))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto2.Valor = valorParametroAdicional2;
			}
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional3))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto2.Valor = valorParametroAdicional3;
			}
			string valorParametroAdicional4 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_DESCONTO3, base.Carteira.ParametrosDisponiveis.Documento.CodigoDesconto3(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional4))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto3.Valor = valorParametroAdicional4.ToEnum<EnumCodigoDesconto>().Codigo();
			}
			string valorParametroAdicional5 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO3, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto3(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional5))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto3.Valor = valorParametroAdicional5;
			}
			string valorParametroAdicional6 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO3, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto3(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional6))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto3.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto3.Valor = valorParametroAdicional6;
			}
			ConfigurarMulta();
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).InformacaoAoSacado.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).Mensagem3.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).Mensagem4.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoOcorrenciaSacado.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoBancoParaDebito.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoAgenciaParaDebito.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).DvAgenciaParaDebito.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).ContaCorrenteParaDebito.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).DvContaCorrenteParaDebito.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).DvAgenciaContaCorrenteParaDebito.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).AvisoParaDebitoAutomatico.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).UsoExclusivoFebraban3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoRRemessaFebraban240(EnumCodigoBanco.BANCO_SAFRA, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMulta.Valor = EnumCodigoMulta.SEM_MULTA.Codigo();
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataMulta.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento.Value.AddDays(1.0), typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).Multa.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (string.IsNullOrEmpty(base.Documento.CodigoMulta) && string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			return;
		}
		EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()));
		DateTime? dateTime = base.Documento.DataVencimento.Value.AddDays(1.0);
		if (enumCodigoMulta == EnumCodigoMulta.SEM_MULTA)
		{
			dateTime = null;
		}
		double num = 0.0;
		switch (enumCodigoMulta)
		{
		case EnumCodigoMulta.SEM_MULTA:
			return;
		case EnumCodigoMulta.VALOR_FIXO:
			num = ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
			break;
		case EnumCodigoMulta.PERCENTUAL:
			num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			break;
		}
		if (num > 0.0)
		{
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMulta.Valor = enumCodigoMulta.Codigo();
			if (dateTime.HasValue)
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataMulta.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
			}
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).Multa.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
		}
	}
}
