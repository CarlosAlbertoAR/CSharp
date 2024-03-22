using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheSFebraban240ImpressaoTipo1e2Padrao : SegmentoDetalheSFebraban240ImpressaoTipo1e2, ISegmentoDetalheSFebraban240ImpressaoTipo1e2Padrao
{
	public CampoLayoutArquivoCobranca NumeroLinha => campos[8];

	public CampoLayoutArquivoCobranca Mensagem => campos[9];

	public CampoLayoutArquivoCobranca TipoFonte => campos[10];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[11];

	public SegmentoDetalheSFebraban240ImpressaoTipo1e2Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
