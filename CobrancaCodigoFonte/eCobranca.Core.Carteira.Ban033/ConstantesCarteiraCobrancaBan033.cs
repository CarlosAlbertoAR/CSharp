using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033;

public class ConstantesCarteiraCobrancaBan033
{
	public const string SAC = "SAC Santander: 0800 762 7777 (Informações, elogios e reclamações) atende também deficientes auditivos ou de fala. Ouvidoria Santander: 0800 726 0322 (dias úteis, das 9h às 18h)";

	public const string CODIGO_BANCO_IMPRESSAO = "033-7";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
