using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public interface IRegistroTipo6RemessaCnab400Ban748
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca EnderecoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CidadeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CepSacadorAvalista { get; }

	CampoLayoutArquivoCobranca UfSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
