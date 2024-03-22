using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheY01Febraban240Padrao
{
	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca EnderecoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca BairroSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca SufixoCepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CidadeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UfSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
