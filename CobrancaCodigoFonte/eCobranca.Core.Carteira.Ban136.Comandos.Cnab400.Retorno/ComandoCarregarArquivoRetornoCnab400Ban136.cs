using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban136.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban136 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban136, ComandoCarregarLoteArquivoRetornoCnab400Ban136, ComandoCarregarTraillerRetornoCnab400Ban136>
{
	public ComandoCarregarArquivoRetornoCnab400Ban136()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.UNICRED}]...");
	}
}
