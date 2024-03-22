using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban033 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban033, ComandoCarregarLoteArquivoRetornoCnab400Ban033, ComandoCarregarTraillerRetornoCnab400Ban033>
{
	public ComandoCarregarArquivoRetornoCnab400Ban033()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}
}
