using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban084;

public interface ITraillerRetornoCnab400Ban084
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoRetorno { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobranca { get; }

	CampoLayoutArquivoCobranca ValorTotalCobranca { get; }

	CampoLayoutArquivoCobranca NumeroAvisoBancario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia02 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia02 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia06 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia06 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrenciaLiquidacao { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia09e10 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosocorrencia09e10 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia13 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia13 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia14 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia14 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia12 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia12 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia19 { get; }

	CampoLayoutArquivoCobranca ValorRegistrosOcorrencia19 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca ValorTotalRateiosEfetuados { get; }

	CampoLayoutArquivoCobranca QuantidadeTotalRateiosEfetuados { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
