using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public interface ISegmentoDetalheGFebraban150Padrao
{
	CampoLayoutArquivoCobranca CodigoDoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco { get; }

	CampoLayoutArquivoCobranca DataPagamento { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca CodigoBarras { get; }

	CampoLayoutArquivoCobranca ValorRecebido { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaArrecadadora { get; }

	CampoLayoutArquivoCobranca FormaArrecadacao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }
}
