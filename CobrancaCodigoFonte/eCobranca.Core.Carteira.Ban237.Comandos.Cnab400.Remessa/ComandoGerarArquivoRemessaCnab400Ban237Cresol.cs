using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban237Cresol : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban237Cresol, ComandoGerarLoteArquivoRemessaCnab400Ban237Cresol, ComandoGerarTraillerRemessaCnab400Ban237Cresol>
{
	public ComandoGerarArquivoRemessaCnab400Ban237Cresol()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
