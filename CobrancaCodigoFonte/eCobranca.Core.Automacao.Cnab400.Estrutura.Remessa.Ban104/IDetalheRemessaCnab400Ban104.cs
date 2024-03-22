using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban104;

public interface IDetalheRemessaCnab400Ban104
{
	CampoLayoutArquivoCobranca IdentificadorRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca IdentificacaoEmissaoBloqueto { get; }

	CampoLayoutArquivoCobranca IdentificacaoDistribuicaoBloqueto { get; }

	CampoLayoutArquivoCobranca TaxaPermanencia { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca ModalidadeIdentificacao { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca MensagemBloqueto { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca Aceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Instrucao1 { get; }

	CampoLayoutArquivoCobranca Instrucao2 { get; }

	CampoLayoutArquivoCobranca JurosDeMora { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CEPPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UFPagador { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca ValorMulta { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Instrucao3 { get; }

	CampoLayoutArquivoCobranca NumeroDiasProtesto { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
