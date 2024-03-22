using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheQFebraban240Padrao
{
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

	CampoLayoutArquivoCobranca CodigoBancoCorrespondente { get; }

	CampoLayoutArquivoCobranca NossoNumeroNoBancoCorrespondente { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
