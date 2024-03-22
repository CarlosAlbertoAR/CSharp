using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban150.Estrutura;

public class SegmentoDetalheGFebraban150Padrao : SegmentoDetalheGFebraban150, ISegmentoDetalheGFebraban150Padrao
{
	public CampoLayoutArquivoCobranca CodigoDoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoBeneficiarioNoBanco => campos[1];

	public CampoLayoutArquivoCobranca DataPagamento => campos[2];

	public CampoLayoutArquivoCobranca DataCredito => campos[3];

	public CampoLayoutArquivoCobranca CodigoBarras => campos[4];

	public CampoLayoutArquivoCobranca ValorRecebido => campos[5];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[6];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[7];

	public CampoLayoutArquivoCobranca CodigoAgenciaArrecadadora => campos[8];

	public CampoLayoutArquivoCobranca FormaArrecadacao => campos[9];

	public CampoLayoutArquivoCobranca Filler1 => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[7].Valor.Trim());
	}
}
