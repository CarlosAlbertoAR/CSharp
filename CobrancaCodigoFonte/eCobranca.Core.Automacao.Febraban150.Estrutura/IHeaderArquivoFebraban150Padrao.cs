using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public interface IHeaderArquivoFebraban150Padrao
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoRemessa { get; }

	CampoLayoutArquivoCobranca CodigoConvenio { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGeracao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivo { get; }

	CampoLayoutArquivoCobranca VersaoLayout { get; }

	CampoLayoutArquivoCobranca UsoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }
}
