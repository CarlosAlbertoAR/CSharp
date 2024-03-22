using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban104;

public interface IDetalheRetornoCnab400Ban104
{
	CampoLayoutArquivoCobranca IdentificadorRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca IdentificacaoEmissaoBloqueto { get; }

	CampoLayoutArquivoCobranca IdentificacaoDistribuicaoBloqueto { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca Modalidade { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoMotivoRejeicao { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca CodigoLiquidacaoBaixa { get; }

	CampoLayoutArquivoCobranca CodigoFormaPagamento { get; }

	CampoLayoutArquivoCobranca InformacaoFloatNegociado { get; }

	CampoLayoutArquivoCobranca DataDebitoTarifa { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorPrincipalPago { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca ValorMulta { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
