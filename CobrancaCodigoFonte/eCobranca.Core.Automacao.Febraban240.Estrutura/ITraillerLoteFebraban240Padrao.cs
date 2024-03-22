using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ITraillerLoteFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosLote { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoLancamento { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
