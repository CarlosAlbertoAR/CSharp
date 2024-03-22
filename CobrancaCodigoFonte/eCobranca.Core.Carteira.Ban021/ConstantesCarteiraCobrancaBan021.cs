using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban021;

public class ConstantesCarteiraCobrancaBan021
{
	public const string SAC = "SAC Banestes: 0800 727 0474 (gratuito, qualquer localidade). Ouvidoria Geral Banestes: 0800 727 0030 (gratuito, qualquer localidade).";

	public const string NOME_BANCO = "BANESTES";

	public const string CODIGO_BANCO_IMPRESSAO = "021-3";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.CNAB400;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
