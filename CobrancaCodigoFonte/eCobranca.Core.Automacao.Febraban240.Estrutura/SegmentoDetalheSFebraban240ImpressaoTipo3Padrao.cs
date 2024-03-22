using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheSFebraban240ImpressaoTipo3Padrao : SegmentoDetalheSFebraban240ImpressaoTipo3, ISegmentoDetalheSFebraban240ImpressaoTipo3Padrao
{
	public CampoLayoutArquivoCobranca Mensagem5 => campos[8];

	public CampoLayoutArquivoCobranca Mensagem6 => campos[9];

	public CampoLayoutArquivoCobranca Mensagem7 => campos[10];

	public CampoLayoutArquivoCobranca Mensagem8 => campos[11];

	public CampoLayoutArquivoCobranca Mensagem9 => campos[12];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[13];

	public SegmentoDetalheSFebraban240ImpressaoTipo3Padrao(long segmentoLote, long sequenciaSegmento)
		: base(segmentoLote, sequenciaSegmento)
	{
	}
}
