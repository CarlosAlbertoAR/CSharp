using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban237;

public interface IRegistroTransacaoTipo3RemessaCnab400Ban237
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca CodigoCalculoRateio { get; }

	CampoLayoutArquivoCobranca TipoValorInformado { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario1 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario1 { get; }

	CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca Parcela1 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario1 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario2 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario2 { get; }

	CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Parcela2 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario3 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario3 { get; }

	CampoLayoutArquivoCobranca ValorPercentualRateioBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca Parcela3 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
