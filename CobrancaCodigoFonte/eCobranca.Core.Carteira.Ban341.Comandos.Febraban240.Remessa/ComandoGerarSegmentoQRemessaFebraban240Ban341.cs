using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Remessa;

public class ComandoGerarSegmentoQRemessaFebraban240Ban341 : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoQRemessaFebraban240Ban341()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).CodigoBancoCompensacao.Valor = EnumCodigoBanco.BANCO_ITAU.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).LoteServico.Valor = base.Segmento.SequenciaLote.ToString();
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoRegistro.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).NumeroSequencialRegistroNoLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).CodigoSegmentoRegistroDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).UsoExclusivoFebraban1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).CodigoMovimento.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).CodigoMovimento.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoInscricaoSacado.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoInscricaoSacado.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoInscricaoSacado.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).NumeroInscricaoSacado.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).NumeroInscricaoSacado.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).NomeSacado.Valor = base.Documento.NomePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).EnderecoSacado.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).BairroSacado.Valor = base.Documento.BairroPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).CepSacado.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(0, 5);
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).SufixoCepSacado.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(5, 3);
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).CidadeSacado.Valor = base.Documento.CidadePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).UfSacado.Valor = base.Documento.UfPagador;
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ_PJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF_PF.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CnpjAvalista);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfAvalista))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Padrao).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Documento.CpfAvalista);
			}
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).NomeSacadorAvalista.Valor = base.Documento.SacadorAvalista;
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).CodigoBancoCorrespondente.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).NossoNumeroNoBancoCorrespondente.Valor = "";
			(base.Segmento as SegmentoDetalheQFebraban240Padrao).UsoExclusivoFebraban2.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoQRemessaFebraban240(EnumCodigoBanco.BANCO_ITAU, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
