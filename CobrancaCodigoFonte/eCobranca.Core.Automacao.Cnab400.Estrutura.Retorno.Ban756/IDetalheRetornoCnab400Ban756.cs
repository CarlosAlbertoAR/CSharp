using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban756;

public interface IDetalheRetornoCnab400Ban756
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroConvenio { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca NumeroParcela { get; }

	CampoLayoutArquivoCobranca GrupoValor { get; }

	CampoLayoutArquivoCobranca CodigoBaixaRecusa { get; }

	CampoLayoutArquivoCobranca PrefixoTitulo { get; }

	CampoLayoutArquivoCobranca VariacaoCarteira { get; }

	CampoLayoutArquivoCobranca ContaCaucao { get; }

	CampoLayoutArquivoCobranca CodigoResponsabilidade { get; }

	CampoLayoutArquivoCobranca DVCodigoResponsabilidade { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca Ocorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoRecebedor { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca DVAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca ValorOutrasDespesas { get; }

	CampoLayoutArquivoCobranca ValorJurosDoDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOFDoDesconto { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca DescontoConcedido { get; }

	CampoLayoutArquivoCobranca ValorRecebido { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca ValorOutrosRecebimentos { get; }

	CampoLayoutArquivoCobranca ValorAbatimentoNaoAproveitadoPeloPagador { get; }

	CampoLayoutArquivoCobranca ValorLancamento { get; }

	CampoLayoutArquivoCobranca IndicativoDebitoCredito { get; }

	CampoLayoutArquivoCobranca IndicativoValor { get; }

	CampoLayoutArquivoCobranca ValorAjuste { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
