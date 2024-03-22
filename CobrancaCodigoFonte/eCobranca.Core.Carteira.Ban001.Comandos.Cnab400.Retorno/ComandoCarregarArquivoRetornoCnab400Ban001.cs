using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban001 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban001, ComandoCarregarLoteArquivoRetornoCnab400Ban001, ComandoCarregarTraillerRetornoCnab400Ban001>
{
	public ComandoCarregarArquivoRetornoCnab400Ban001()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
