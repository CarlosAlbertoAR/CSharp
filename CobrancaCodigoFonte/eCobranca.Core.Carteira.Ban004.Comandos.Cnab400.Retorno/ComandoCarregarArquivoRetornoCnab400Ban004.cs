using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban004.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban004 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban004, ComandoCarregarLoteArquivoRetornoCnab400Ban004, ComandoCarregarTraillerRetornoCnab400Ban004>
{
	public ComandoCarregarArquivoRetornoCnab400Ban004()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
	}
}
