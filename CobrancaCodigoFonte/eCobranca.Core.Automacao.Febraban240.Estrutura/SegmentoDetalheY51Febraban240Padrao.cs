using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheY51Febraban240Padrao : SegmentoDetalheY51Febraban240, ISegmentoDetalheY51Febraban240Padrao
{
	public CampoLayoutArquivoCobranca NumeroNotaFiscal1 => campos[8];

	public CampoLayoutArquivoCobranca ValorNotaFiscal1 => campos[9];

	public CampoLayoutArquivoCobranca DataEmissaoNotaFiscal1 => campos[10];

	public CampoLayoutArquivoCobranca NumeroNotaFiscal2 => campos[11];

	public CampoLayoutArquivoCobranca ValorNotaFiscal2 => campos[12];

	public CampoLayoutArquivoCobranca DataEmissaoNotaFiscal2 => campos[13];

	public CampoLayoutArquivoCobranca NumeroNotaFiscal3 => campos[14];

	public CampoLayoutArquivoCobranca ValorNotaFiscal3 => campos[15];

	public CampoLayoutArquivoCobranca DataEmissaoNotaFiscal3 => campos[16];

	public CampoLayoutArquivoCobranca NumeroNotaFiscal4 => campos[17];

	public CampoLayoutArquivoCobranca ValorNotaFiscal4 => campos[18];

	public CampoLayoutArquivoCobranca DataEmissaoNotaFiscal4 => campos[19];

	public CampoLayoutArquivoCobranca NumeroNotaFiscal5 => campos[20];

	public CampoLayoutArquivoCobranca ValorNotaFiscal5 => campos[21];

	public CampoLayoutArquivoCobranca DataEmissaoNotaFiscal5 => campos[22];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[23];

	public SegmentoDetalheY51Febraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
