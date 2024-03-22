using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public interface IDetalheOpcionalRemessaCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca EnderecoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca BairroSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CidadeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UFSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
