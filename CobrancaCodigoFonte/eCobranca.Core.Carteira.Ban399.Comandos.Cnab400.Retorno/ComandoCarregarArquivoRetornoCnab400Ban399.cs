using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban399 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban399, ComandoCarregarLoteArquivoRetornoCnab400Ban399, ComandoCarregarTraillerRetornoCnab400Ban399>
{
	public ComandoCarregarArquivoRetornoCnab400Ban399()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}
}
