using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban021.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban021 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban021, ComandoCarregarLoteArquivoRetornoCnab400Ban021, ComandoCarregarTraillerRetornoCnab400Ban021>
{
	public ComandoCarregarArquivoRetornoCnab400Ban021()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
	}
}
