using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheSFebraban240ImpressaoTipo3Padrao
{
	CampoLayoutArquivoCobranca Mensagem5 { get; }

	CampoLayoutArquivoCobranca Mensagem6 { get; }

	CampoLayoutArquivoCobranca Mensagem7 { get; }

	CampoLayoutArquivoCobranca Mensagem8 { get; }

	CampoLayoutArquivoCobranca Mensagem9 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
