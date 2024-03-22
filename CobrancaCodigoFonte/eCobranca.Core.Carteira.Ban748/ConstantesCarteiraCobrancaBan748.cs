using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748;

public class ConstantesCarteiraCobrancaBan748
{
	public const string SAC = "SAC Sicredi: 0800 724 7220 (Informações, elogios e reclamações) ou 0800 724 0525 (deficientes auditivos ou de fala). Ouvidoria Sicredi: 0800 646 2519 (dias úteis, das 8h às 18h)";

	public const string CODIGO_BANCO_IMPRESSAO = "748-X";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
