using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public interface IHeaderRemessaCnab400Ban748
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca TipoOperacaoLiteral { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca TipoServicoLiteral { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroRemessa { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca VersaoSistema { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
