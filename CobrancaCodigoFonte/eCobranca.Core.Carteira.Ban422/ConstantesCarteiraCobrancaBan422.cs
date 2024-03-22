using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422;

public class ConstantesCarteiraCobrancaBan422
{
	public const string SAC = "SAC Safra: 0800 772 5755 (gratuito, qualquer localidade). Ouvidoria Safra: 0800 770 1236 (segunda à sexta-feira, das 9h às 18h)";

	public const string NOME_BANCO = "SAFRA";

	public const string CODIGO_BANCO_IMPRESSAO = "422-7";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
