using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheUFebraban240Padrao : SegmentoDetalheUFebraban240, ISegmentoDetalheUFebraban240Padrao
{
	public CampoLayoutArquivoCobranca ValorAcrescimos => campos[7];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[8];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[9];

	public CampoLayoutArquivoCobranca ValorIOF => campos[10];

	public CampoLayoutArquivoCobranca ValorPago => campos[11];

	public CampoLayoutArquivoCobranca ValorLiquido => campos[12];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[13];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[14];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca DataEfetivacaoCredito => campos[16];

	public CampoLayoutArquivoCobranca CodigoOcorrenciaSacado => campos[17];

	public CampoLayoutArquivoCobranca DataOcorrenciaSacado => campos[18];

	public CampoLayoutArquivoCobranca ValorOcorrenciaSacado => campos[19];

	public CampoLayoutArquivoCobranca ComplementoOcorrenciaSacado => campos[20];

	public CampoLayoutArquivoCobranca CodigoBancoCorrespondente => campos[21];

	public CampoLayoutArquivoCobranca NossoNumeroBancoCorrespondente => campos[22];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[23];

	public SegmentoDetalheUFebraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
