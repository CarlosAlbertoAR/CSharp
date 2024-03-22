using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheRFebraban240Padrao : SegmentoDetalheRFebraban240, ISegmentoDetalheRFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoDesconto2 => campos[7];

	public CampoLayoutArquivoCobranca DataDesconto2 => campos[8];

	public CampoLayoutArquivoCobranca Desconto2 => campos[9];

	public CampoLayoutArquivoCobranca CodigoDesconto3 => campos[10];

	public CampoLayoutArquivoCobranca DataDesconto3 => campos[11];

	public CampoLayoutArquivoCobranca Desconto3 => campos[12];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[13];

	public CampoLayoutArquivoCobranca DataMulta => campos[14];

	public CampoLayoutArquivoCobranca Multa => campos[15];

	public CampoLayoutArquivoCobranca InformacaoAoSacado => campos[16];

	public CampoLayoutArquivoCobranca Mensagem3 => campos[17];

	public CampoLayoutArquivoCobranca Mensagem4 => campos[18];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[19];

	public CampoLayoutArquivoCobranca CodigoOcorrenciaSacado => campos[20];

	public CampoLayoutArquivoCobranca CodigoBancoParaDebito => campos[21];

	public CampoLayoutArquivoCobranca CodigoAgenciaParaDebito => campos[22];

	public CampoLayoutArquivoCobranca DvAgenciaParaDebito => campos[23];

	public CampoLayoutArquivoCobranca ContaCorrenteParaDebito => campos[24];

	public CampoLayoutArquivoCobranca DvContaCorrenteParaDebito => campos[25];

	public CampoLayoutArquivoCobranca DvAgenciaContaCorrenteParaDebito => campos[26];

	public CampoLayoutArquivoCobranca AvisoParaDebitoAutomatico => campos[27];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban3 => campos[28];

	public SegmentoDetalheRFebraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
