using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban104;

public interface ITraillerArquivoFebraban240Ban104
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca QuantidadeLotesArquivo { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosArquivo { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban3 { get; }
}
