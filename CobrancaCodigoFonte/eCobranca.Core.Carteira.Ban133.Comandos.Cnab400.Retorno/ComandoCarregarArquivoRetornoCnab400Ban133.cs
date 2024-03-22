using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban133.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban133 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban133, ComandoCarregarLoteArquivoRetornoCnab400Ban133, ComandoCarregarTraillerRetornoCnab400Ban133>
{
	public ComandoCarregarArquivoRetornoCnab400Ban133()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
	}
}
