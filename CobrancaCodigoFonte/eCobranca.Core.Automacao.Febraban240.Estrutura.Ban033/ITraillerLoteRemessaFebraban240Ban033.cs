using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ITraillerLoteRemessaFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosLote { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }
}
