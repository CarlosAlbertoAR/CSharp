using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ITraillerArquivoRetornoFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca NumeroLote { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeLotes { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistros { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }
}
