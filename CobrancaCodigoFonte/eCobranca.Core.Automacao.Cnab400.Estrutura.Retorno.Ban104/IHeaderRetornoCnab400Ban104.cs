using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban104;

public interface IHeaderRetornoCnab400Ban104
{
	CampoLayoutArquivoCobranca IdentificadorRegistro { get; }

	CampoLayoutArquivoCobranca IdentificadorRetorno { get; }

	CampoLayoutArquivoCobranca IdentificadorRetornoLiteral { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca TipoServicoLiteral { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGeracao { get; }

	CampoLayoutArquivoCobranca MensagemRetorno { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRetorno { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
