using System;
using System.Diagnostics;
using System.Globalization;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoRRemessaFebraban240Ban748 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoRRemessaFebraban240Ban748()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO R da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando comando para gerar o SEGMENTO R da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI.Codigo();
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
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto2.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto2.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto2.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoDesconto3.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataDesconto3.Valor = "0";
			(base.Segmento as SegmentoDetalheRFebraban240Padrao).Desconto3.Valor = "0";
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoRRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}

	private void ConfigurarMulta()
	{
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMulta.Valor = EnumCodigoMulta.PERCENTUAL.Codigo();
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataMulta.Valor = StringUtil.ObterStringComBrancos(8);
		(base.Segmento as SegmentoDetalheRFebraban240Padrao).Multa.Valor = (string)base.DoubleConverter.Convert(0, typeof(string), "F2", CultureInfo.CurrentCulture);
		if (!string.IsNullOrEmpty(base.Documento.CodigoMulta) || !string.IsNullOrEmpty(base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta))
		{
			EnumCodigoMulta enumCodigoMulta = ((!string.IsNullOrEmpty(base.Documento.CodigoMulta)) ? ((EnumCodigoMulta)(object)base.Documento.CodigoMulta.ToEnum<EnumCodigoMulta>()) : ((EnumCodigoMulta)(object)base.Carteira.ConfiguracaoDocumentoCobranca.CodigoMulta.ToEnum<EnumCodigoMulta>()));
			DateTime? dateTime = base.Documento.DataVencimento.Value.AddDays(1.0);
			double num = 0.0;
			if (enumCodigoMulta == EnumCodigoMulta.PERCENTUAL)
			{
				num = ((base.Documento.ValorMultaAtraso > 0.0) ? (base.Documento.ValorMultaAtraso / base.Documento.ValorDocumento * 100.0) : ((base.Documento.PercentualMultaAtraso > 0.0) ? base.Documento.PercentualMultaAtraso : 0.0));
			}
			if (num > 0.0)
			{
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).CodigoMulta.Valor = enumCodigoMulta.Codigo();
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).DataMulta.Valor = (string)base.DateConverter.Convert(dateTime, typeof(string), EnumTipoData.DDMMAAAA, CultureInfo.CurrentCulture);
				(base.Segmento as SegmentoDetalheRFebraban240Padrao).Multa.Valor = (string)base.DoubleConverter.Convert(num, typeof(string), "F2", CultureInfo.CurrentCulture);
			}
		}
	}
}
