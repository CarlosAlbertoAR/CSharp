using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalhePFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DvAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DvContaCorrente { get; }

	CampoLayoutArquivoCobranca DvAgenciaContaCorrente { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca FormaCadastroTituloNoBanco { get; }

	CampoLayoutArquivoCobranca TipoDocumento { get; }

	CampoLayoutArquivoCobranca IdentificacaoEmissaoBoleto { get; }

	CampoLayoutArquivoCobranca IdentificacaoDistribuicao { get; }

	CampoLayoutArquivoCobranca NumeroDocumentoCobranca { get; }

	CampoLayoutArquivoCobranca DataVencimentoTitulo { get; }

	CampoLayoutArquivoCobranca ValorNominalTitulo { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca DvAgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca Aceite { get; }

	CampoLayoutArquivoCobranca DataEmissaoTitulo { get; }

	CampoLayoutArquivoCobranca CodigoJuros { get; }

	CampoLayoutArquivoCobranca DataJuros { get; }

	CampoLayoutArquivoCobranca JurosMora { get; }

	CampoLayoutArquivoCobranca CodigoDesconto1 { get; }

	CampoLayoutArquivoCobranca DataDesconto1 { get; }

	CampoLayoutArquivoCobranca Desconto1 { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoProtesto { get; }

	CampoLayoutArquivoCobranca NumeroDiasParaProtesto { get; }

	CampoLayoutArquivoCobranca CodigoBaixa { get; }

	CampoLayoutArquivoCobranca NumeroDiasParaBaixa { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca NumeroContrato { get; }

	CampoLayoutArquivoCobranca UsoLivreBancoEmpresa { get; }
}
