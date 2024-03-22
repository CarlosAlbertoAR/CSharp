using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban399;

public interface IHeaderRemessaCnab400Ban399
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoOperacao { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoOperacaoExtenso { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoServico { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoServicoExtenso { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca SubContaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca DensidadeGravacao { get; }

	CampoLayoutArquivoCobranca UnidadeDensidadeGravacao { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca SiglaLayoutTecnico { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
