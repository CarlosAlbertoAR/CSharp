using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class HeaderLoteFebraban240Padrao : HeaderLoteFebraban240, IHeaderLoteFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[3];

	public CampoLayoutArquivoCobranca TipoServico => campos[4];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[5];

	public CampoLayoutArquivoCobranca NumeroVersaoLayoutLote => campos[6];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[7];

	public CampoLayoutArquivoCobranca TipoInscricaoEmpresa => campos[8];

	public CampoLayoutArquivoCobranca NumeroInscricaoEmpresa => campos[9];

	public CampoLayoutArquivoCobranca CodigoConvenioBanco => campos[10];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[11];

	public CampoLayoutArquivoCobranca DVAgencia => campos[12];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[13];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[14];

	public CampoLayoutArquivoCobranca DVAgenciaContaCorrente => campos[15];

	public CampoLayoutArquivoCobranca NomeEmpresa => campos[16];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[17];

	public CampoLayoutArquivoCobranca Mensagem2 => campos[18];

	public CampoLayoutArquivoCobranca NumeroRemessaRetorno => campos[19];

	public CampoLayoutArquivoCobranca DataGravacaoRemessaRetorno => campos[20];

	public CampoLayoutArquivoCobranca DataCredito => campos[21];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban3 => campos[22];
}
