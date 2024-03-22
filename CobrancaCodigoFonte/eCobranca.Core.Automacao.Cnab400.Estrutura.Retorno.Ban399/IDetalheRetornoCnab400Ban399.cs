using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban399;

public interface IDetalheRetornoCnab400Ban399
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca SubContaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca OrigemPagamento { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DataDesconto2 { get; }

	CampoLayoutArquivoCobranca ValorDesconto2 { get; }

	CampoLayoutArquivoCobranca DataDesconto3 { get; }

	CampoLayoutArquivoCobranca ValorDesconto3 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca NossoNumeroBanco { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca BancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorJurosDeMora { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ComplementoOcorrencia { get; }

	CampoLayoutArquivoCobranca IndicativoDeCredito { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca NumeroAviso { get; }

	CampoLayoutArquivoCobranca TipoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
