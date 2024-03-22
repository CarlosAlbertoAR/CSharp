using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheQFebraban240Padrao : SegmentoDetalheQFebraban240, ISegmentoDetalheQFebraban240Padrao
{
	public CampoLayoutArquivoCobranca TipoInscricaoSacado => campos[7];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacado => campos[8];

	public CampoLayoutArquivoCobranca NomeSacado => campos[9];

	public CampoLayoutArquivoCobranca EnderecoSacado => campos[10];

	public CampoLayoutArquivoCobranca BairroSacado => campos[11];

	public CampoLayoutArquivoCobranca CepSacado => campos[12];

	public CampoLayoutArquivoCobranca SufixoCepSacado => campos[13];

	public CampoLayoutArquivoCobranca CidadeSacado => campos[14];

	public CampoLayoutArquivoCobranca UfSacado => campos[15];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[16];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[17];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[18];

	public CampoLayoutArquivoCobranca CodigoBancoCorrespondente => campos[19];

	public CampoLayoutArquivoCobranca NossoNumeroNoBancoCorrespondente => campos[20];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[21];

	public SegmentoDetalheQFebraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
