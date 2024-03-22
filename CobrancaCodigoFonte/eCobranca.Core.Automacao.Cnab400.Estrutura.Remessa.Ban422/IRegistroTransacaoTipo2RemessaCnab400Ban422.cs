using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;

public interface IRegistroTransacaoTipo2RemessaCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca EnderecoEmailPagador { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca TipoPessoaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca EnderecoBeneficiario { get; }

	CampoLayoutArquivoCobranca BairroBeneficiario { get; }

	CampoLayoutArquivoCobranca CidadeBeneficiario { get; }

	CampoLayoutArquivoCobranca CepBeneficiario { get; }

	CampoLayoutArquivoCobranca UfBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivoRemessa { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
