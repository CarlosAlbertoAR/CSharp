using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheSFebraban240ImpressaoTipo1e2Padrao
{
	CampoLayoutArquivoCobranca NumeroLinha { get; }

	CampoLayoutArquivoCobranca Mensagem { get; }

	CampoLayoutArquivoCobranca TipoFonte { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
