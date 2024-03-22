using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalheQFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NumeroLoteNaRemessa { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote { get; }

	CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca CodigoMovimentoRemessa { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacado { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacado { get; }

	CampoLayoutArquivoCobranca NomeSacado { get; }

	CampoLayoutArquivoCobranca EnderecoSacado { get; }

	CampoLayoutArquivoCobranca BairroSacado { get; }

	CampoLayoutArquivoCobranca CepSacado { get; }

	CampoLayoutArquivoCobranca SufixoCepSacado { get; }

	CampoLayoutArquivoCobranca CidadeSacado { get; }

	CampoLayoutArquivoCobranca UfSacado { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca IdentificadorCarne { get; }

	CampoLayoutArquivoCobranca SequencialParcela { get; }

	CampoLayoutArquivoCobranca QuantidadeTotalParcelas { get; }

	CampoLayoutArquivoCobranca NumeroPlano { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }
}
