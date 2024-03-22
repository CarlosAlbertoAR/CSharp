using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public interface ISegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil
{
	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca RegistroDetalhe { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroLote { get; }

	CampoLayoutArquivoCobranca CodigoSegmentoDoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca ControleBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca TipoInscricao { get; }

	CampoLayoutArquivoCobranca NumeroInscricao { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ValorTarifa { get; }

	CampoLayoutArquivoCobranca MotivosOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }
}
