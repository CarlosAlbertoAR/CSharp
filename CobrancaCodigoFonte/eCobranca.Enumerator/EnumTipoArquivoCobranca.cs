using System.ComponentModel;

namespace eCobranca.Enumerator;

public enum EnumTipoArquivoCobranca
{
	[Description("Arquivo de remessa utilizado para envio de títulos de cobrança para o banco")]
	REMESSA,
	[Description("Arquivo de retorno gerado pelo banco para envio de títulos de cobrança ao beneficiário")]
	RETORNO,
	[Description("Ainda não definido")]
	INDEFINIDO
}
