using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoBaseDetalheFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote { get; }

	CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca CodigoMovimento { get; }
}
