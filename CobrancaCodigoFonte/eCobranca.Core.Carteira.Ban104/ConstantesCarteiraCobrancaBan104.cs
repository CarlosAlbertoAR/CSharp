using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104;

public class ConstantesCarteiraCobrancaBan104
{
	public const string SAC = "SAC CAIXA: 0800 726 0101 (informações, reclamações, sugestões e elogios).       Para pessoas com deficiência auditiva ou de fala: 0800 726 2492                               Ouvidoria: 0800 725 7474                                                       caixa.gov.br                               ";

	public const string CODIGO_BANCO_IMPRESSAO = "104-0";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
