using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class TraillerArquivoFebraban240Padrao : TraillerArquivoFebraban240, ITraillerArquivoFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeLotesArquivo => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosArquivo => campos[5];

	public CampoLayoutArquivoCobranca QuantidadeContasConciliacao => campos[6];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[7];
}
