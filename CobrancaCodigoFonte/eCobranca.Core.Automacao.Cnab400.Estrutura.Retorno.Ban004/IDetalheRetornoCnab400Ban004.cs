using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban004;

public interface IDetalheRetornoCnab400Ban004
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DigitoContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroControle { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DigitoNossoNumero { get; }

	CampoLayoutArquivoCobranca NumeroContrato { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Carteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca ConfirmacaoNossoNumero { get; }

	CampoLayoutArquivoCobranca ConfirmacaoDigitoNossoNumero { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca NumeroBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca Tarifa { get; }

	CampoLayoutArquivoCobranca Outras { get; }

	CampoLayoutArquivoCobranca Juros { get; }

	CampoLayoutArquivoCobranca IOC { get; }

	CampoLayoutArquivoCobranca AbatimentoConcedido { get; }

	CampoLayoutArquivoCobranca DescontoConcedido { get; }

	CampoLayoutArquivoCobranca ValorRecebido { get; }

	CampoLayoutArquivoCobranca JurosMora { get; }

	CampoLayoutArquivoCobranca TabelaErros { get; }

	CampoLayoutArquivoCobranca SequencialRegistro { get; }
}
