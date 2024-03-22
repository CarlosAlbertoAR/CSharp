using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface IHeaderArquivoRetornoFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca CodigoRetorno { get; }

	CampoLayoutArquivoCobranca DataGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivo { get; }

	CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }
}
