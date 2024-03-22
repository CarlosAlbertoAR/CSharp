using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheY01Febraban240Padrao : SegmentoDetalheY01Febraban240, ISegmentoDetalheY01Febraban240Padrao
{
	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[8];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[9];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[10];

	public CampoLayoutArquivoCobranca EnderecoSacadorAvalista => campos[11];

	public CampoLayoutArquivoCobranca BairroSacadorAvalista => campos[12];

	public CampoLayoutArquivoCobranca CepSacadorAvalista => campos[13];

	public CampoLayoutArquivoCobranca SufixoCepSacadorAvalista => campos[14];

	public CampoLayoutArquivoCobranca CidadeSacadorAvalista => campos[15];

	public CampoLayoutArquivoCobranca UfSacadorAvalista => campos[16];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[17];

	public SegmentoDetalheY01Febraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
