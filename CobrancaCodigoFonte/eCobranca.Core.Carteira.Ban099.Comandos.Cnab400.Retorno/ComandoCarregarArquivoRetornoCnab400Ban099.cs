using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban099.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban099 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban099, ComandoCarregarLoteArquivoRetornoCnab400Ban099, ComandoCarregarTraillerRetornoCnab400Ban099>
{
	public ComandoCarregarArquivoRetornoCnab400Ban099()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
	}
}
