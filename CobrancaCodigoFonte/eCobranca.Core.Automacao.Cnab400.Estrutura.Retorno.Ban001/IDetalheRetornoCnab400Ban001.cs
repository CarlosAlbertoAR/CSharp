using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban001;

public interface IDetalheRetornoCnab400Ban001
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DVAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca NumeroConvenio { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca TipoCobranca { get; }

	CampoLayoutArquivoCobranca TipoCobrancaComando72 { get; }

	CampoLayoutArquivoCobranca DiasParaCalculo { get; }

	CampoLayoutArquivoCobranca NaturezaRecebimento { get; }

	CampoLayoutArquivoCobranca PrefixoTitulo { get; }

	CampoLayoutArquivoCobranca VariacaoCarteira { get; }

	CampoLayoutArquivoCobranca ContaCaucao { get; }

	CampoLayoutArquivoCobranca TaxaDesconto { get; }

	CampoLayoutArquivoCobranca TaxaIOF { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca Comando { get; }

	CampoLayoutArquivoCobranca DataLiquidacao { get; }

	CampoLayoutArquivoCobranca NumeroTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoRecebedor { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca DVAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca OutrasDespesas { get; }

	CampoLayoutArquivoCobranca JurosDoDesconto { get; }

	CampoLayoutArquivoCobranca IOFDoDesconto { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca DescontoConcedido { get; }

	CampoLayoutArquivoCobranca ValorRecebido { get; }

	CampoLayoutArquivoCobranca JurosDeMora { get; }

	CampoLayoutArquivoCobranca OutrosRecebimentos { get; }

	CampoLayoutArquivoCobranca AbatimentoNaoAproveitadoPeloPagador { get; }

	CampoLayoutArquivoCobranca ValorLancamento { get; }

	CampoLayoutArquivoCobranca IndicativoDebitoOuCredito { get; }

	CampoLayoutArquivoCobranca IndicadorValor { get; }

	CampoLayoutArquivoCobranca ValorAjuste { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca Filler12 { get; }

	CampoLayoutArquivoCobranca IdicativoAutorizacaoLiquidacaoParcial { get; }

	CampoLayoutArquivoCobranca Filler13 { get; }

	CampoLayoutArquivoCobranca CanalPagamentoTitulo { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
