using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban084.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban084 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban084, ComandoCarregarLoteArquivoRetornoCnab400Ban084, ComandoCarregarTraillerRetornoCnab400Ban084>
{
	public ComandoCarregarArquivoRetornoCnab400Ban084()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.UNIPRIME_NORTE_PARANA}]...");
	}
}
