using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399;

public class ConstantesCarteiraCobrancaBan399
{
	public const string SAC = "SAC HSBC: 4004-4722 (capitais e regiões metropolitanas) ou 0800 703 4722 (demais localidades). Segunda a sexta-feira (exceto feriados): das 7h às 20h.";

	public const string CODIGO_BANCO_IMPRESSAO = "399-9";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
