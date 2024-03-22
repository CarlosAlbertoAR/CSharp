using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;

public interface IRegistroDetalheRemessaCnab400Ban133
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DVAgencia { get; }

	CampoLayoutArquivoCobranca RazaoContaCorrente { get; }

	CampoLayoutArquivoCobranca ContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca PercentualMulta { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca DescontoBonificacaoPorDia { get; }

	CampoLayoutArquivoCobranca IdentificacaoEmissorBoleto { get; }

	CampoLayoutArquivoCobranca IdentificacaoDebitoAutomatico { get; }

	CampoLayoutArquivoCobranca IdentificacaoOperacaoBanco { get; }

	CampoLayoutArquivoCobranca IndicadorRateioCredito { get; }

	CampoLayoutArquivoCobranca EnderecamentoAvisoDebitoAutomatico { get; }

	CampoLayoutArquivoCobranca QuantidadePossiveisPagamento { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca BancoEncarregadoCobranca { get; }

	CampoLayoutArquivoCobranca AgenciaDepositaria { get; }

	CampoLayoutArquivoCobranca Especie { get; }

	CampoLayoutArquivoCobranca Identificacao { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca PrimeiraInstrucao { get; }

	CampoLayoutArquivoCobranca SegundaInstrucao { get; }

	CampoLayoutArquivoCobranca ValorJurosAoDia { get; }

	CampoLayoutArquivoCobranca DataLimiteDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca PrimeiraMensagem { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca SacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
