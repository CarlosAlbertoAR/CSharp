using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;

public interface ITraillerLoteFebraban240Ban104
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosLote { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban3 { get; }
}
