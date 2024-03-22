using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;

public interface IHeaderRemessaCnab400Ban136
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoRemessa { get; }

	CampoLayoutArquivoCobranca IdentificacaoRemessaLiteral { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca LiteralServico { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoVariacao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivo { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
