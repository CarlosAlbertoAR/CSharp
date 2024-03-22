using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban748 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban748, ComandoCarregarLoteArquivoRetornoCnab400Ban748, ComandoCarregarTraillerRetornoCnab400Ban748>
{
	public ComandoCarregarArquivoRetornoCnab400Ban748()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}
}
