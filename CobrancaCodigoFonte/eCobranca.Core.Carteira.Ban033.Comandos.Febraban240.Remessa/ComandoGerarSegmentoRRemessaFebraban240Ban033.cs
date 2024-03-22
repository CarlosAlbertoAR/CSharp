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

public class ComandoGerarSegmentoRRemessaFebraban240Ban033 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoRRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO R da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO R da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).LoteServico.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_R.Codigo();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).UsoExclusivoFebraban1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoMovimento.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoMovimento.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			string valorParametroAdicional = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_CODIGO_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.CodigoDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoDesconto2.Valor = valorParametroAdicional.ToEnum<EnumCodigoDesconto>().Codigo();
			}
			string valorParametroAdicional2 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_DATA_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.DataDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional2))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).DataDesconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).DataDesconto2.Valor = valorParametroAdicional2;
			}
			string valorParametroAdicional3 = ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.DOC_VALOR_DESCONTO2, base.Carteira.ParametrosDisponiveis.Documento.ValorDesconto2(), base.Documento.ParametrosAdicionais);
			if (string.IsNullOrEmpty(valorParametroAdicional3))
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).Desconto2.Valor = "0";
			}
			else
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).Desconto2.Valor = valorParametroAdicional3;
			}
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).UsoReservadoBanco2.Valor = "";
			ConfigurarMulta();
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).UsoReservadoBanco3.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).Mensagem3.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).Mensagem4.Valor = "";
			(base.Segmento as SegmentoDetalheRFebraban240Ban033).UsoReservadoBanco4.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoRRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoMulta.Valor = EnumCodigoMulta.VALOR_FIXO.Codigo();
		(base.Segmento as SegmentoDetalheRFebraban240Ban033).DataMulta.Valor = (string)base.DateConverter.Convert(base.Documento.DataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
		(base.Segmento as SegmentoDetalheRFebraban240Ban033).Multa.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()));
			DateTime? dataVencimento = base.Documento.DataVencimento;
			double num = 0.0;
			switch (enumCodigoMulta)
			{
			case EnumCodigoMulta.VALOR_FIXO:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? base.Documento.ValorMultaAtraso : ((base.Documento.PercentualMultaAtraso > 0.0) ? (base.Documento.PercentualMultaAtraso / 100.0 * base.Documento.ValorDocumento) : 0.0));
				break;
			case EnumCodigoMulta.PERCENTUAL:
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
				break;
			}
			if (num > 0.0)
			{
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).DataMulta.Valor = (string)base.DateConverter.Convert(dataVencimento, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalheRFebraban240Ban033).Multa.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
