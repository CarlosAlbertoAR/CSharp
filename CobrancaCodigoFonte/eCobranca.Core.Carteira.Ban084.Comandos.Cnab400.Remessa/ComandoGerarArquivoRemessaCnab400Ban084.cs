using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban084 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban084, ComandoGerarLoteArquivoRemessaCnab400Ban084, ComandoGerarTraillerRemessaCnab400Ban084>
{
	public ComandoGerarArquivoRemessaCnab400Ban084()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}
}
