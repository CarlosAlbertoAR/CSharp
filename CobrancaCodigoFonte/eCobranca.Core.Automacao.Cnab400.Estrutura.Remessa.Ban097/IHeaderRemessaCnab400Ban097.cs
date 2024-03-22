using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;

public interface IHeaderRemessaCnab400Ban097
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoArquivo { get; }

	CampoLayoutArquivoCobranca TipoArquivoLiteral { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca TipoServicoLiteral { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DigitoContaCorrente { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca SequencialRemessa { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
