using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira;

public class ConstantesCarteiraCobranca
{
	public const string PREFIXO_NOME_ARQUIVO_REMESSA = "";

	public const string RADICAL_NOME_ARQUIVO_REMESSA = "REMESSA";

	public const string SUFIXO_NOME_ARQUIVO_REMESSA = "";

	public const string EXTENSAO_NOME_ARQUIVO_REMESSA = "REM";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.FEBRABAN240;

	public const bool GERA_HEADER_ARQUIVO_FEBRABAN240 = true;

	public const bool GERA_HEADER_LOTE_FEBRABAN240 = true;

	public const bool GERA_SEGMENTO_P_FEBRABAN240 = true;

	public const bool GERA_SEGMENTO_Q_FEBRABAN240 = true;

	public const bool GERA_SEGMENTO_R_FEBRABAN240 = true;

	public const bool GERA_TRAILLER_LOTE_FEBRABAN240 = true;

	public const bool GERA_TRAILLER_ARQUIVO_FEBRABAN240 = true;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;

	public const int TAMANHO_NOME_ARQUIVO_REMESSA = 7;
}
