using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban237 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban237, ComandoCarregarLoteArquivoRetornoCnab400Ban237, ComandoCarregarTraillerRetornoCnab400Ban237>
{
	public ComandoCarregarArquivoRetornoCnab400Ban237()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
