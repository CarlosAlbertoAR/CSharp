using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoQRemessaFebraban240Ban033 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoQRemessaFebraban240Ban033()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).CodigoBanco.Valor = EnumCodigoBanco.BANCO_SANTANDER.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroLoteNaRemessa.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).UsoReservadoBanco1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).CodigoMovimentoRemessa.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).CodigoMovimentoRemessa.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoInscricaoSacado.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoInscricaoSacado.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoInscricaoSacado.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroInscricaoSacado.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroInscricaoSacado.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).NomeSacado.Valor = base.Documento.NomePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).EnderecoSacado.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).BairroSacado.Valor = base.Documento.BairroPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).CepSacado.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(0, 5);
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).SufixoCepSacado.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(5, 3);
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).CidadeSacado.Valor = base.Documento.CidadePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).UfSacado.Valor = base.Documento.UfPagador;
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).IdentificadorCarne.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).SequencialParcela.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).QuantidadeTotalParcelas.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).NumeroPlano.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Ban033).UsoReservadoBanco2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoQRemessaFebraban240(EnumCodigoBanco.BANCO_SANTANDER, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
