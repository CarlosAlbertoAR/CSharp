using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;

public interface IDetalheRetornoCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVAgenciaContaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroCarteira { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca ConfirmacaoNossoNumero { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca DVAgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca ValorDespesaCobranca { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorLancamento { get; }

	CampoLayoutArquivoCobranca ValorJurosDeMora { get; }

	CampoLayoutArquivoCobranca ValorOutrosCreditos { get; }

	CampoLayoutArquivoCobranca IndicadorBoletoDDA { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca CodigoInstrucaoCancelada { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca RegistrosRejeitados { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca CodigoLiquidacao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
