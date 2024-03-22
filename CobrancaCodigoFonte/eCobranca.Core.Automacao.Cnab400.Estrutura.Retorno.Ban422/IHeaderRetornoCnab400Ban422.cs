using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban422;

public interface IHeaderRetornoCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoArquivoRetorno { get; }

	CampoLayoutArquivoCobranca LiteralIdentificacaoArquivoRetorno { get; }

	CampoLayoutArquivoCobranca CodigoIdentificacaoServico { get; }

	CampoLayoutArquivoCobranca LiteralIdentificacaoServico { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca DataGravacaoArquivo { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
