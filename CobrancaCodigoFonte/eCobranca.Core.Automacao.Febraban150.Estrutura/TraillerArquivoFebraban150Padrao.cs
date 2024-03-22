using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public class TraillerArquivoFebraban150Padrao : TraillerArquivoFebraban150, ITraillerArquivoFebraban150Padrao
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca QuantidadeTotalRegistros => campos[1];

	public CampoLayoutArquivoCobranca ValorTotalRegistros => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[1].Valor.Trim());
	}
}
