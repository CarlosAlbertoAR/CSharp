using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public interface ISegmentoDetalheQFebraban240Ban756CorrespondenteBancoBrasil
{
	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca RegistroDoDetalhe { get; }

	CampoLayoutArquivoCobranca NumeroSequencialDoRegistroLote { get; }

	CampoLayoutArquivoCobranca CodigoSegmentoRegistroDoDetalhe { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoInstrucao { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca SufixoCepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UFPagador { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }
}
