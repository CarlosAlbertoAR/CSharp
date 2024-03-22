using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237;

public class ConstantesCarteiraCobrancaBan237
{
	public const string SAC = "SAC Bradesco: 0800 704 8383 (gratuito, qualquer localidade) ou 0800 722 0099 (deficientes auditivos ou de fala). Ouvidoria Bradesco: 0800 727 9933 (segunda à sexta-feira, das 8h às 18h)";

	public const string NOME_BANCO = "BRADESCO";

	public const string CODIGO_BANCO_IMPRESSAO = "237-2";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
