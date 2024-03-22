using eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Retorno;

public class ComandoCarregarArquivoRetornoCnab400Ban041 : ComandoCarregarArquivoRetornoCnab400<ComandoCarregarHeaderRetornoCnab400Ban041, ComandoCarregarLoteArquivoRetornoCnab400Ban041, ComandoCarregarTraillerRetornoCnab400Ban041>
{
	public ComandoCarregarArquivoRetornoCnab400Ban041()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}
}
