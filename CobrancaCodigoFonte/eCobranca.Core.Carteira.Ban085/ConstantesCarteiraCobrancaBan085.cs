using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085;

public class ConstantesCarteiraCobrancaBan085
{
	public const string SAC = "SAC CECRED: 0800 647 2200 (informações, reclamações, sugestões e elogios).\n                          Ouvidoria: 0800 644 1100                        \n                             www.cecred.coop.br                           \n";

	public const string CODIGO_BANCO_IMPRESSAO = "085-0";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
