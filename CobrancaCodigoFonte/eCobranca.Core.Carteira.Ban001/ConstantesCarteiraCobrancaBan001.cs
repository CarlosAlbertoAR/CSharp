using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001;

public class ConstantesCarteiraCobrancaBan001
{
	public const string SAC = "SAC Banco do Brasil: 0800 729 0722 (gratuito, qualquer localidade) ou 0800 729 0088 (deficientes auditivos ou de fala). Ouvidoria Banco do Brasil: 0800 729 5678 (dias úteis, das 8h às 18h) ou 0800 729 0088 (para deficientes auditivos ou de fala)";

	public const string CODIGO_BANCO_IMPRESSAO = "001-9";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
