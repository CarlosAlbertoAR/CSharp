using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban097CobrancaSimples : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban097CobrancaSimples, ComandoCarregarLoteArquivoRetornoCnab400Ban097CobrancaSimples, ComandoCarregarTraillerRetornoCnab400Ban097CobrancaSimples>
{
	public ComandoCarregarArquivoRetornoCnab400Ban097CobrancaSimples()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
