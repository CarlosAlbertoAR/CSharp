using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public interface IHeaderRemessaCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca TipoOperacaoLiteral { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca TipoServicoLiteral { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVContaAgenciaContaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGeracao { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
