using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban097 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban097, ComandoCarregarLoteArquivoRetornoCnab400Ban097, ComandoCarregarTraillerRetornoCnab400Ban097>
{
	public ComandoCarregarArquivoRetornoCnab400Ban097()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
