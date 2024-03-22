using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban097 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban097, ComandoGerarLoteArquivoRemessaCnab400Ban097, ComandoGerarTraillerRemessaCnab400Ban097>
{
	public ComandoGerarArquivoRemessaCnab400Ban097()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
