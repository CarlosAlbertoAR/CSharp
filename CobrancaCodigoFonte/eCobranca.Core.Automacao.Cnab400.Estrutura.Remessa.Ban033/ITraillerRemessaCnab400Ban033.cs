using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;

public interface ITraillerRemessaCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosArquivo { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulos { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequenciaRegistro { get; }
}
