using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban136;

public class ConstantesCarteiraCobrancaBan136
{
	public const string SAC = "Central de Atendimento Unicred: (65) 3314-4700 Ouvidoria Unicred: 0800 940 0602 (segunda à sexta-feira, horário de atendimento: 09:00 às 18:00)";

	public const string NOME_BANCO = "UNICRED";

	public const string CODIGO_BANCO_IMPRESSAO = "136-8";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.CNAB400;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
