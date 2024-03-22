using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban422 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban422, ComandoGerarLoteArquivoRemessaCnab400Ban422, ComandoGerarTraillerRemessaCnab400Ban422>
{
	public ComandoGerarArquivoRemessaCnab400Ban422()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
