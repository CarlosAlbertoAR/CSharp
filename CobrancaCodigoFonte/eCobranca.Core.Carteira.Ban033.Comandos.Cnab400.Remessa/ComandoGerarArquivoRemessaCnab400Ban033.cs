using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban033 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban033, ComandoGerarLoteArquivoRemessaCnab400Ban033, ComandoGerarTraillerRemessaCnab400Ban033>
{
	public ComandoGerarArquivoRemessaCnab400Ban033()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}
}
