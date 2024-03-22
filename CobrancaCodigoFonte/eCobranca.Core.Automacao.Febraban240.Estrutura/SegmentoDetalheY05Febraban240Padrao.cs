using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheY05Febraban240Padrao : SegmentoDetalheY05Febraban240, ISegmentoDetalheY05Febraban240Padrao
{
	public CampoLayoutArquivoCobranca IdentificacaoCheque1 => campos[8];

	public CampoLayoutArquivoCobranca IdentificacaoCheque2 => campos[9];

	public CampoLayoutArquivoCobranca IdentificacaoCheque3 => campos[10];

	public CampoLayoutArquivoCobranca IdentificacaoCheque4 => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoCheque5 => campos[12];

	public CampoLayoutArquivoCobranca IdentificacaoCheque6 => campos[13];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[14];

	public SegmentoDetalheY05Febraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
