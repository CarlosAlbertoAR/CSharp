using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class HeaderArquivoFebraban240Padrao : HeaderArquivoFebraban240, IHeaderArquivoFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[3];

	public CampoLayoutArquivoCobranca TipoInscricaoEmpresa => campos[4];

	public CampoLayoutArquivoCobranca NumeroInscricaoEmpresa => campos[5];

	public CampoLayoutArquivoCobranca CodigoConvenioBanco => campos[6];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[7];

	public CampoLayoutArquivoCobranca DVAgencia => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca DVAgenciaContaCorrente => campos[11];

	public CampoLayoutArquivoCobranca NomeEmpresa => campos[12];

	public CampoLayoutArquivoCobranca NomeBanco => campos[13];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[14];

	public CampoLayoutArquivoCobranca CodigoRemessaRetorno => campos[15];

	public CampoLayoutArquivoCobranca DataGeracaoArquivo => campos[16];

	public CampoLayoutArquivoCobranca HoraGeracaoArquivo => campos[17];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivo => campos[18];

	public CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo => campos[19];

	public CampoLayoutArquivoCobranca DensidadeGravacaoArquivo => campos[20];

	public CampoLayoutArquivoCobranca UsoReservadoBanco => campos[21];

	public CampoLayoutArquivoCobranca UsoReservadoEmpresa => campos[22];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban3 => campos[23];

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[18].Valor.Trim());
	}
}
