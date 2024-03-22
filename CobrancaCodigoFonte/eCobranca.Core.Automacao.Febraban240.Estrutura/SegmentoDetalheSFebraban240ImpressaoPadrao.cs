using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheSFebraban240ImpressaoPadrao : SegmentoDetalheSFebraban240Impressao, ISegmentoDetalheSFebraban240ImpressaoPadrao
{
	public CampoLayoutArquivoCobranca IdentificacaoImpressao => campos[7];

	public SegmentoDetalheSFebraban240ImpressaoPadrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
