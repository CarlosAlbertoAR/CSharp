using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban756 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban756, ComandoCarregarLoteArquivoRetornoCnab400Ban756, ComandoCarregarTraillerRetornoCnab400Ban756>
{
	public ComandoCarregarArquivoRetornoCnab400Ban756()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}
}
