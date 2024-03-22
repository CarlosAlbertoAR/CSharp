using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban422 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban422, ComandoCarregarLoteArquivoRetornoCnab400Ban422, ComandoCarregarTraillerRetornoCnab400Ban422>
{
	public ComandoCarregarArquivoRetornoCnab400Ban422()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
