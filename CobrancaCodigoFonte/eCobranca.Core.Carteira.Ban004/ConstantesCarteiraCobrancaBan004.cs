using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban004;

public class ConstantesCarteiraCobrancaBan004
{
	public const string SAC = "SAC Banco do Nordeste: 0800 728 3030 Cliente Consulta Capitais e Regiões Metropolitanas: 4020-0004 (tarifa de ligação local) Demais Localidades: 0800 033 0004 Atendimento Especial para pessoas com deficiência auditiva ou de fala: 0800 033 3031 Ouvidoria Sugestões e reclamações: 0800 033 3033 Nossas agências o Banco do Nordeste mais perto de você outros canais de atendimento ";

	public const string CODIGO_BANCO_IMPRESSAO = "004-3";

	public const string DIRETORIO_REMESSA = "C:\\eCobranca\\Remessas\\";

	public const EnumLayoutArquivoRemessa LAYOUT_ARQUIVO_REMESSA = EnumLayoutArquivoRemessa.CNAB400;

	public const int SEQUENCIA_REMESSA_INICIAL = 1;

	public const int SEQUENCIA_LOTE_INICIAL = 1;
}
