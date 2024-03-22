using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class SegmentoDetalhePFebraban240Padrao : SegmentoDetalhePFebraban240, ISegmentoDetalhePFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoAgencia => campos[7];

	public CampoLayoutArquivoCobranca DvAgencia => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca DvContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca DvAgenciaContaCorrente => campos[11];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[12];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[13];

	public CampoLayoutArquivoCobranca FormaCadastroTituloNoBanco => campos[14];

	public CampoLayoutArquivoCobranca TipoDocumento => campos[15];

	public CampoLayoutArquivoCobranca IdentificacaoEmissaoBoleto => campos[16];

	public CampoLayoutArquivoCobranca IdentificacaoDistribuicao => campos[17];

	public CampoLayoutArquivoCobranca NumeroDocumentoCobranca => campos[18];

	public CampoLayoutArquivoCobranca DataVencimentoTitulo => campos[19];

	public CampoLayoutArquivoCobranca ValorNominalTitulo => campos[20];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[21];

	public CampoLayoutArquivoCobranca DvAgenciaCobradora => campos[22];

	public CampoLayoutArquivoCobranca EspecieTitulo => campos[23];

	public CampoLayoutArquivoCobranca Aceite => campos[24];

	public CampoLayoutArquivoCobranca DataEmissaoTitulo => campos[25];

	public CampoLayoutArquivoCobranca CodigoJuros => campos[26];

	public CampoLayoutArquivoCobranca DataJuros => campos[27];

	public CampoLayoutArquivoCobranca JurosMora => campos[28];

	public CampoLayoutArquivoCobranca CodigoDesconto1 => campos[29];

	public CampoLayoutArquivoCobranca DataDesconto1 => campos[30];

	public CampoLayoutArquivoCobranca Desconto1 => campos[31];

	public CampoLayoutArquivoCobranca ValorIOF => campos[32];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[33];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa => campos[34];

	public CampoLayoutArquivoCobranca CodigoProtesto => campos[35];

	public CampoLayoutArquivoCobranca NumeroDiasParaProtesto => campos[36];

	public CampoLayoutArquivoCobranca CodigoBaixa => campos[37];

	public CampoLayoutArquivoCobranca NumeroDiasParaBaixa => campos[38];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[39];

	public CampoLayoutArquivoCobranca NumeroContrato => campos[40];

	public CampoLayoutArquivoCobranca UsoLivreBancoEmpresa => campos[41];

	public SegmentoDetalhePFebraban240Padrao(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
	}
}
