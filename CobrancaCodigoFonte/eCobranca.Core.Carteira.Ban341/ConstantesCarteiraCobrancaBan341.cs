using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341;

public class ConstantesCarteiraCobrancaBan341
{
	public const string SAC = "SAC Itaú: 0800 728 0728 (gratuito, qualquer localidade) ou 0800 722 1722 (deficientes auditivos ou de fala). Ouvidoria Itaú: 0800 570 0011 (dias úties, das 9h às 18h)";

	public const string NOME_BANCO = "BANCO ITAU SA";

	public const string CODIGO_BANCO_IMPRESSAO = "341-7";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
