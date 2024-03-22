using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756;

public class ConstantesCarteiraCobrancaBan756
{
	public const string SAC = "SAC Sicoob: 0800 724 4420 (Informações, elogios e reclamações) ou 0800 940 0458 (deficientes auditivos ou de fala). Ouvidoria Sicoob: 0800 725 0996 (dias úteis, das 8h às 20h)";

	public const string CODIGO_BANCO_IMPRESSAO = "756-0";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
