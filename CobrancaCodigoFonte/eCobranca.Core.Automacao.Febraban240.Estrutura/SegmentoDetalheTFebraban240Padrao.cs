using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalheTFebraban240Padrao : SegmentoDetalheTFebraban240, ISegmentoDetalheTFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoAgencia => campos[7];

	public CampoLayoutArquivoCobranca DvAgencia => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca DvContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca DvAgenciaContaCorrente => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[12];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[13];

	public CampoLayoutArquivoCobranca NumeroDocumentoCobranca => campos[14];

	public CampoLayoutArquivoCobranca DataVencimentoTitulo => campos[15];

	public CampoLayoutArquivoCobranca ValorNominalTitulo => campos[16];

	public CampoLayoutArquivoCobranca CodigoBancoRecebedor => campos[17];

	public CampoLayoutArquivoCobranca CodigoAgenciaRecebedora => campos[18];

	public CampoLayoutArquivoCobranca DvAgenciaRecebedora => campos[19];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa => campos[20];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[21];

	public CampoLayoutArquivoCobranca TipoInscricaoSacado => campos[22];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacado => campos[23];

	public CampoLayoutArquivoCobranca NomeSacado => campos[24];

	public CampoLayoutArquivoCobranca NumeroContrato => campos[25];

	public CampoLayoutArquivoCobranca ValorTarifaCustas => campos[26];

	public CampoLayoutArquivoCobranca MotivoOcorrencia => campos[27];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[28];

	public SegmentoDetalheTFebraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
