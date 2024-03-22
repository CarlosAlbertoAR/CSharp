using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheY05Febraban240Padrao
{
	CampoLayoutArquivoCobranca IdentificacaoCheque1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoCheque2 { get; }

	CampoLayoutArquivoCobranca IdentificacaoCheque3 { get; }

	CampoLayoutArquivoCobranca IdentificacaoCheque4 { get; }

	CampoLayoutArquivoCobranca IdentificacaoCheque5 { get; }

	CampoLayoutArquivoCobranca IdentificacaoCheque6 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
