using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban133;

public class ConstantesCarteiraCobrancaBan133
{
	public const string SAC = "Central de atendimento Cresol. O número disponívek para capitais e regiões metropolitanas é o 4007 1600. Para demais regiões, ligue para 0800 704 7500. Ouvidoria Cresol por meio do telefone 0800 643 1981 (Segunda a Sexta | 08h às 17h).";

	public const string CODIGO_BANCO_IMPRESSAO = "133-3";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.CNAB400;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
