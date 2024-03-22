using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public interface ITraillerArquivoFebraban150Padrao
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca QuantidadeTotalRegistros { get; }

	CampoLayoutArquivoCobranca ValorTotalRegistros { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }
}
