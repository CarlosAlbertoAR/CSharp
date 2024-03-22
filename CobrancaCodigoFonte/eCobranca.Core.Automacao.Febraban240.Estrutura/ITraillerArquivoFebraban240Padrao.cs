using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ITraillerArquivoFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca QuantidadeLotesArquivo { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosArquivo { get; }

	CampoLayoutArquivoCobranca QuantidadeContasConciliacao { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
