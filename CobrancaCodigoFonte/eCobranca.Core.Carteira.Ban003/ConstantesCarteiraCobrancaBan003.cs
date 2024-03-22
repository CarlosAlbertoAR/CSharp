using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003;

public class ConstantesCarteiraCobrancaBan003
{
	public const string SAC = "SAC Banco da Amazônia: 0800 727 7228 (gratuito, qualquer localidade, 24 horas por dia). Ouvidoria Banco da Amazônia: 0800 722 2171 (dias úteis, das 8h às 18h)";

	public const string CODIGO_BANCO_IMPRESSAO = "003-5";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const EnumLayoutArquivoRetorno LAYOUT_ARQUIVO_RETORNO = EnumLayoutArquivoRetorno.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
