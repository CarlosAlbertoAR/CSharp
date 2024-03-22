using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban136;

public interface IRegistroTipo1RetornoCnab400Ban136
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroAgencia { get; }

	CampoLayoutArquivoCobranca DigitoAgencia { get; }

	CampoLayoutArquivoCobranca ContaCorrente { get; }

	CampoLayoutArquivoCobranca DigitoContaCorrente { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca ModalidadeCobranca { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca Variacao { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca UsoBanco { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataLiquidacao { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca CodigoBancoRecebedor { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca DigitoAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca DataRepasse { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca ValorLiquido { get; }

	CampoLayoutArquivoCobranca MotivoOcorrencia { get; }

	CampoLayoutArquivoCobranca TipoInstrucaoOrigem { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
