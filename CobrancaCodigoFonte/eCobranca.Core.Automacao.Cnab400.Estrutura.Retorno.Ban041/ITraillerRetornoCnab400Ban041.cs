using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;

public interface ITraillerRetornoCnab400Ban041
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCarteira { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulos { get; }

	CampoLayoutArquivoCobranca NumeroSequenciaArquivo { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosRegistrados { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosRegistrados { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosLiquidados { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosLiquidados { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca QuantidadeTotalRateiosEfetuados { get; }

	CampoLayoutArquivoCobranca ValorTotalRateiosEfetuados { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
