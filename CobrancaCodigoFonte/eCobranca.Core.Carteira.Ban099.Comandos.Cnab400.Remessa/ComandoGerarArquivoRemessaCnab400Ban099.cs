using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban099.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban099 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban099, ComandoGerarLoteArquivoRemessaCnab400Ban099, ComandoGerarTraillerRemessaCnab400Ban099>
{
	public ComandoGerarArquivoRemessaCnab400Ban099()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
	}
}
