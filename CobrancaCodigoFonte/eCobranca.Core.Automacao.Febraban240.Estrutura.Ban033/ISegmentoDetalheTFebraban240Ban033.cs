using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalheTFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NumeroLote { get; }

	CampoLayoutArquivoCobranca TipoDoRegistro { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroLote { get; }

	CampoLayoutArquivoCobranca CodigoDoSegmentoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca DVAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca NumeroDocumentoCobranca { get; }

	CampoLayoutArquivoCobranca DataVencimentoTitulo { get; }

	CampoLayoutArquivoCobranca ValorNominalTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca DvAgenciaCobradora { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca ContaCobranca { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca MotivosOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }
}
