using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban099;

public interface IRegistroTransacaoTipo1RemessaCnab400Ban099
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca AgenciaDebito { get; }

	CampoLayoutArquivoCobranca DVAgenciaDebito { get; }

	CampoLayoutArquivoCobranca RazaoContaCorrente { get; }

	CampoLayoutArquivoCobranca ContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca PercentualMulta { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DVNossoNumero { get; }

	CampoLayoutArquivoCobranca DescontoBonificacaoPorDia { get; }

	CampoLayoutArquivoCobranca CondicaoEmissaoBloqueto { get; }

	CampoLayoutArquivoCobranca IdentificacaoEmissaoBoletoDebitoAutomatico { get; }

	CampoLayoutArquivoCobranca IdentificacaoOperacao { get; }

	CampoLayoutArquivoCobranca IndicadorRateioCredito { get; }

	CampoLayoutArquivoCobranca EnderecamentoParaAvisoDebitoAutomatico { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaDepositaria { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca Identificacao { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Instrucao1 { get; }

	CampoLayoutArquivoCobranca Instrucao2 { get; }

	CampoLayoutArquivoCobranca ValorJurosDia { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca PrefixoCepPagador { get; }

	CampoLayoutArquivoCobranca SufixoCepPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UfPagador { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
