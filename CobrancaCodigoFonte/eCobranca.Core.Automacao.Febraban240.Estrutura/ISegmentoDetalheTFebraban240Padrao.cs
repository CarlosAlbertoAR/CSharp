using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheTFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DvAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DvContaCorrente { get; }

	CampoLayoutArquivoCobranca DvAgenciaContaCorrente { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca NumeroDocumentoCobranca { get; }

	CampoLayoutArquivoCobranca DataVencimentoTitulo { get; }

	CampoLayoutArquivoCobranca ValorNominalTitulo { get; }

	CampoLayoutArquivoCobranca CodigoBancoRecebedor { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca DvAgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacado { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacado { get; }

	CampoLayoutArquivoCobranca NomeSacado { get; }

	CampoLayoutArquivoCobranca NumeroContrato { get; }

	CampoLayoutArquivoCobranca ValorTarifaCustas { get; }

	CampoLayoutArquivoCobranca MotivoOcorrencia { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
