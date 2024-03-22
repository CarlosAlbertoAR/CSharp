using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;

public interface IHeaderRemessaCnab400Ban004
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoOperacao { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoOperacaoExtenso { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoServico { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoServicoExtenso { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DigitoContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca CodigoUsuario { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
