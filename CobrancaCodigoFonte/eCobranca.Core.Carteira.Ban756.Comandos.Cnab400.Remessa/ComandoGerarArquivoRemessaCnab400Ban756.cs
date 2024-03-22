using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban756 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban756, ComandoGerarLoteArquivoRemessaCnab400Ban756, ComandoGerarTraillerRemessaCnab400Ban756>
{
	public ComandoGerarArquivoRemessaCnab400Ban756()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}
}
