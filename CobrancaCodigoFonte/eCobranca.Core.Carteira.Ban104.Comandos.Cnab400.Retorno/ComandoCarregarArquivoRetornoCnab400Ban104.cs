using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban104 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban104, ComandoCarregarLoteArquivoRetornoCnab400Ban104, ComandoCarregarTraillerRetornoCnab400Ban104>
{
	public ComandoCarregarArquivoRetornoCnab400Ban104()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}
}
