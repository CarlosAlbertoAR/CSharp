using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheY50Febraban240Padrao : SegmentoDetalheY50Febraban240, ISegmentoDetalheY50Febraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoAgencia => campos[8];

	public CampoLayoutArquivoCobranca DvAgencia => campos[9];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca DvContaCorrente => campos[11];

	public CampoLayoutArquivoCobranca DvAgenciaContaCorrente => campos[12];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[13];

	public CampoLayoutArquivoCobranca CodigoCalculoRateio => campos[14];

	public CampoLayoutArquivoCobranca TipoValorInformadoRateio => campos[15];

	public CampoLayoutArquivoCobranca ValorPercentualRateio => campos[16];

	public CampoLayoutArquivoCobranca CodigoBancoBeneficiario => campos[17];

	public CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario => campos[18];

	public CampoLayoutArquivoCobranca DvAgenciaBeneficiario => campos[19];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[20];

	public CampoLayoutArquivoCobranca DvContaCorrenteBeneficiario => campos[21];

	public CampoLayoutArquivoCobranca DvAgenciaContaCorrenteBeneficiario => campos[22];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[23];

	public CampoLayoutArquivoCobranca ParcelaRateio => campos[24];

	public CampoLayoutArquivoCobranca NumeroDiasParaCreditoBeneficiario => campos[25];

	public CampoLayoutArquivoCobranca DataCreditoBeneficiario => campos[26];

	public CampoLayoutArquivoCobranca MotivoOcorrido => campos[27];

	public CampoLayoutArquivoCobranca IspbBancoDestinatario => campos[28];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[29];

	public SegmentoDetalheY50Febraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
