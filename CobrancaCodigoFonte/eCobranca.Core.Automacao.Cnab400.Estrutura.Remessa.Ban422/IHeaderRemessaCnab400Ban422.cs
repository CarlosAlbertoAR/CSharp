using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;

public interface IHeaderRemessaCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoRemessa { get; }

	CampoLayoutArquivoCobranca IdentificacaoRemessaLiteral { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca LiteralServico { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRemessa { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
