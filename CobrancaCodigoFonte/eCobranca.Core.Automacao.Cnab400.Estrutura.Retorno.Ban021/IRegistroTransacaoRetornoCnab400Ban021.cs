using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban021;

public interface IRegistroTransacaoRetornoCnab400Ban021
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoLancamento { get; }

	CampoLayoutArquivoCobranca UsoBanestes { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca FatorVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominalTitulo { get; }

	CampoLayoutArquivoCobranca BancoRecebedor { get; }

	CampoLayoutArquivoCobranca AgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca TarifaBancaria { get; }

	CampoLayoutArquivoCobranca ValorOutrasDespesas { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorIOC { get; }

	CampoLayoutArquivoCobranca ValorAbatimentoConcedido { get; }

	CampoLayoutArquivoCobranca ValorDescontoConcedido { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca ValorOutrosCreditos { get; }

	CampoLayoutArquivoCobranca IdentificacaoPagamentoEmCartorio { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca MotivoOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca NumeroRemessa { get; }

	CampoLayoutArquivoCobranca DataRemessa { get; }

	CampoLayoutArquivoCobranca SequenciaTransmissaoArquivo { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
