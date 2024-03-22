using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa.CorrespondenteBan001;

public class ComandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil : ComandoGerarSegmentoDetalheRemessaFebraban240
{
	public ComandoGerarSegmentoQRemessaFebraban240Ban756CorrespondenteBancoBrasil()
	{
		Logger.Debug($"Criando comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}

	public override void Execute()
	{
		try
		{
			Logger.Debug($"Executando o comando para gerar o SEGMENTO Q da remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).Filler1.Valor = "0";
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).RegistroDoDetalhe.Valor = EnumTipoRegistroFebraban240.DETALHE.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NumeroSequencialDoRegistroLote.Valor = base.Segmento.SequenciaSegmento.ToString();
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).CodigoSegmentoRegistroDoDetalhe.Valor = EnumTipoSegmentoDetalheFebraban240.SEGMENTO_Q.Codigo();
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).Filler1.Valor = "";
			if (string.IsNullOrEmpty(base.Documento.CodigoMovimentoRemessa))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).CodigoInstrucao.Valor = base.Carteira.ConfiguracaoArquivoRemessa.CodigoMovimentoRemessaPadrao.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).CodigoInstrucao.Valor = base.Documento.CodigoMovimentoRemessa.ToEnum<EnumCodigoMovimentoRemessa>().Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).TipoInscricaoPagador.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).TipoInscricaoPagador.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			if (!string.IsNullOrEmpty(base.Documento.CnpjPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CnpjPagador);
			}
			else if (!string.IsNullOrEmpty(base.Documento.CpfPagador))
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NumeroInscricaoPagador.Valor = StringUtil.RemoverMascara(base.Documento.CpfPagador);
			}
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NomePagador.Valor = base.Documento.NomePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).EnderecoPagador.Valor = base.Documento.EnderecoPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).BairroPagador.Valor = base.Documento.BairroPagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).CepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(0, 5);
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).SufixoCepPagador.Valor = StringUtil.RemoverMascara(base.Documento.CepPagador).Substring(5, 3);
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).CidadePagador.Valor = base.Documento.CidadePagador;
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).UFPagador.Valor = base.Documento.UfPagador;
			if ((EnumTipoInscricao)(object)base.Carteira.ConfiguracaoCarteiraCobranca.TipoInscricaoBeneficiario.ToEnum<EnumTipoInscricao>() == EnumTipoInscricao.CPF)
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CPF.Codigo();
			}
			else
			{
				(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).TipoInscricaoSacadorAvalista.Valor = EnumTipoInscricao.CNPJ.Codigo();
			}
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NumeroInscricaoSacadorAvalista.Valor = StringUtil.RemoverMascara(base.Carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario);
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).NomeSacadorAvalista.Valor = base.Carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario;
			(base.Segmento as SegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil).Filler3.Valor = "";
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ModeloBoleto.FalhaExecutandoComandoGerarSegmentoQRemessaFebraban240(EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
