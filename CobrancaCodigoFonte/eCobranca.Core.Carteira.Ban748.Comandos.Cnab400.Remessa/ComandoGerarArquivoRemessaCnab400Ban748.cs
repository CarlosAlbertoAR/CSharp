using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban748 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban748, ComandoGerarLoteArquivoRemessaCnab400Ban748, ComandoGerarTraillerRemessaCnab400Ban748>
{
	public ComandoGerarArquivoRemessaCnab400Ban748()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}
}
