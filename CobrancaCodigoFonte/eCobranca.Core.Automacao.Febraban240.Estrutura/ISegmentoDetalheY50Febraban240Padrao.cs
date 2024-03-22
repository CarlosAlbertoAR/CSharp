using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheY50Febraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DvAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DvContaCorrente { get; }

	CampoLayoutArquivoCobranca DvAgenciaContaCorrente { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca CodigoCalculoRateio { get; }

	CampoLayoutArquivoCobranca TipoValorInformadoRateio { get; }

	CampoLayoutArquivoCobranca ValorPercentualRateio { get; }

	CampoLayoutArquivoCobranca CodigoBancoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca DvAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DvContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DvAgenciaContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca ParcelaRateio { get; }

	CampoLayoutArquivoCobranca NumeroDiasParaCreditoBeneficiario { get; }

	CampoLayoutArquivoCobranca DataCreditoBeneficiario { get; }

	CampoLayoutArquivoCobranca MotivoOcorrido { get; }

	CampoLayoutArquivoCobranca IspbBancoDestinatario { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
