using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;

public interface IRegistroTransacaoTipo3RateioCreditoRetornoCnab400Ban041
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca EmissorBoletoCobranca { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoCalculoRateio { get; }

	CampoLayoutArquivoCobranca TipoValorInformado { get; }

	CampoLayoutArquivoCobranca Fillers3 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario1 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler12 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca MotivoOcorrenciaRateioBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
