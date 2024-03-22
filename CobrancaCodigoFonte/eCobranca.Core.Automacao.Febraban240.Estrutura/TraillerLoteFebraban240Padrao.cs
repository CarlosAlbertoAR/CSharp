using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public class TraillerLoteFebraban240Padrao : TraillerLoteFebraban240, ITraillerLoteFebraban240Padrao
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosLote => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada => campos[7];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaCaucionada => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada => campos[11];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaDescontada => campos[12];

	public CampoLayoutArquivoCobranca NumeroAvisoLancamento => campos[13];

	public CampoLayoutArquivoCobranca UsoExclusivoFebraban2 => campos[14];
}
