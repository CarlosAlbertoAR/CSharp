using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public interface IRegistroTransacaoTipo3RateioCreditoRemessaCnab400Ban041
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiarioPrincipal { get; }

	CampoLayoutArquivoCobranca TipoEmissorBoletoCobranca { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoCalculoRateio { get; }

	CampoLayoutArquivoCobranca TipoValorInformado { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorPercentualBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca ValorPercentualBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca ValorPercentualBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
