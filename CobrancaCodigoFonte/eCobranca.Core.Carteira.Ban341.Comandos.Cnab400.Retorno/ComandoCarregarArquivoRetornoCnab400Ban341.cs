using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban341 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban341, ComandoCarregarLoteArquivoRetornoCnab400Ban341, ComandoCarregarTraillerRetornoCnab400Ban341>
{
	public ComandoCarregarArquivoRetornoCnab400Ban341()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}
}
