using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban097CobrancaSimples : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban097CobrancaSimples, ComandoGerarLoteArquivoRemessaCnab400Ban097CobrancaSimples, ComandoGerarTraillerRemessaCnab400Ban097>
{
	public ComandoGerarArquivoRemessaCnab400Ban097CobrancaSimples()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
