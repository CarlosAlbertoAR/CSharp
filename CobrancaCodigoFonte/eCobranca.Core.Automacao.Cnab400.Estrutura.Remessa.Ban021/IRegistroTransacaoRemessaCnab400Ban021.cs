using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;

public interface IRegistroTransacaoRemessaCnab400Ban021
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca ValorMulta { get; }

	CampoLayoutArquivoCobranca IdentificacaoCarne { get; }

	CampoLayoutArquivoCobranca NumeroParcelaCarne { get; }

	CampoLayoutArquivoCobranca QuantidadeParcelasCarne { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca InscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca PracaCobranca { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca CodigoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca PrimeiraInstrucaoCobranca { get; }

	CampoLayoutArquivoCobranca SegundaInstrucaoCobranca { get; }

	CampoLayoutArquivoCobranca CodigoJuros { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca DataLimiteDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca IOC { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca EstadoPagador { get; }

	CampoLayoutArquivoCobranca MensagemCampoInstrucao { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
