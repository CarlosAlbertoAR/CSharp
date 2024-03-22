using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheY04Febraban240Padrao : SegmentoDetalheY04Febraban240, ISegmentoDetalheY04Febraban240Padrao
{
	public CampoLayoutArquivoCobranca EmailSacado => campos[8];

	public CampoLayoutArquivoCobranca CodigoDDDCelularSacado => campos[9];

	public CampoLayoutArquivoCobranca NumeroCelularSacado => campos[10];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[11];

	public SegmentoDetalheY04Febraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
