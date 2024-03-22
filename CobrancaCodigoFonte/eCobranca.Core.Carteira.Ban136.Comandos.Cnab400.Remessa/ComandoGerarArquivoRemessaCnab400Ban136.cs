using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban136 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban136, ComandoGerarLoteArquivoRemessaCnab400Ban136, ComandoGerarTraillerRemessaCnab400Ban136>
{
	public ComandoGerarArquivoRemessaCnab400Ban136()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
	}
}
