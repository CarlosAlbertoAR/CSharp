using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public class HeaderArquivoFebraban150Padrao : HeaderArquivoFebraban150, IHeaderArquivoFebraban150Padrao
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca CodigoRemessa => campos[1];

	public CampoLayoutArquivoCobranca CodigoConvenio => campos[2];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[3];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[4];

	public CampoLayoutArquivoCobranca NomeBanco => campos[5];

	public CampoLayoutArquivoCobranca DataGeracao => campos[6];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivo => campos[7];

	public CampoLayoutArquivoCobranca VersaoLayout => campos[8];

	public CampoLayoutArquivoCobranca UsoBanco => campos[9];

	public CampoLayoutArquivoCobranca Filler1 => campos[10];

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[7].Valor.Trim());
	}
}
