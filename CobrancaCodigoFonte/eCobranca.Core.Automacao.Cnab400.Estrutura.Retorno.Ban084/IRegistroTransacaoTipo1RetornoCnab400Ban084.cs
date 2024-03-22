using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban084;

public interface IRegistroTransacaoTipo1RetornoCnab400Ban084
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco { get; }

	CampoLayoutArquivoCobranca NumeroControleBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca IndicadorRateioCredito { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca ValorDespesa { get; }

	CampoLayoutArquivoCobranca OutrasDespesas { get; }

	CampoLayoutArquivoCobranca JurosOperacaoEmAtraso { get; }

	CampoLayoutArquivoCobranca IOFDevido { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca JurosDeMora { get; }

	CampoLayoutArquivoCobranca OutrosCreditos { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca MotivoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca OrigemPagamento { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca CodigoBanco2 { get; }

	CampoLayoutArquivoCobranca MotivoRejeicao { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca NumeroCartorio { get; }

	CampoLayoutArquivoCobranca NumeroProtocolo { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
