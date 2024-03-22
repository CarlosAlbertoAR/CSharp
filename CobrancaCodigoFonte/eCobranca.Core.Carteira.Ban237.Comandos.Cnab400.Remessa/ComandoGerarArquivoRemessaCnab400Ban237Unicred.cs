using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban237Unicred : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban237Unicred, ComandoGerarLoteArquivoRemessaCnab400Ban237Unicred, ComandoGerarTraillerRemessaCnab400Ban237Unicred>
{
	public ComandoGerarArquivoRemessaCnab400Ban237Unicred()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
