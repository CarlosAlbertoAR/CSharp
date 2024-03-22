using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban237;

public interface IRegistroTransacaoTipo3RetornoCnab400Ban237
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca CodigoCalculoRateioCredito { get; }

	CampoLayoutArquivoCobranca TipoValorInformado { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario1 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario1 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario1 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario1 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario1 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario1 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario2 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario2 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario2 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario2 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario2 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario2 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario2 { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario3 { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario3 { get; }

	CampoLayoutArquivoCobranca ValorEfetivoRateioBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario3 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ParcelaBeneficiario3 { get; }

	CampoLayoutArquivoCobranca FloatingBeneficiario3 { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca StatusMotivoOcorrenciaRateioCreditoBeneficiario3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
