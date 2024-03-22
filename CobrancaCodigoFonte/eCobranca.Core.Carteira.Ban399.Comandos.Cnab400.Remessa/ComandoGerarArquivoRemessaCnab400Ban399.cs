using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban399 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban399, ComandoGerarLoteArquivoRemessaCnab400Ban399, ComandoGerarTraillerRemessaCnab400Ban399>
{
	public ComandoGerarArquivoRemessaCnab400Ban399()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}
}
