using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheY04Febraban240Padrao
{
	CampoLayoutArquivoCobranca EmailSacado { get; }

	CampoLayoutArquivoCobranca CodigoDDDCelularSacado { get; }

	CampoLayoutArquivoCobranca NumeroCelularSacado { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
