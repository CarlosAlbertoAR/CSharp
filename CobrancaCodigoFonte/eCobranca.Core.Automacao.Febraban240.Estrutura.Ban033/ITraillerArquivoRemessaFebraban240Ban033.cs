using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ITraillerArquivoRemessaFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca QuantidadeLotesArquivo { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosArquivo { get; }

	CampoLayoutArquivoCobranca UsoReservadobanco2 { get; }
}
