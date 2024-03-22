using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ITraillerLoteRetornoFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosLote { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalTituloCobrancaSimples { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoLancamento { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }
}
