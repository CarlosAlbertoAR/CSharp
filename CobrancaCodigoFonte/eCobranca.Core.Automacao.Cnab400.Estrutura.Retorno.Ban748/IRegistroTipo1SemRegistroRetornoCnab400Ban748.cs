using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban748;

public interface IRegistroTipo1SemRegistroRetornoCnab400Ban748
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca TipoCobranca { get; }

	CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorJurosDeMora { get; }

	CampoLayoutArquivoCobranca ValorMulta { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca MotivosOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca DataPrevistaCredito { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
