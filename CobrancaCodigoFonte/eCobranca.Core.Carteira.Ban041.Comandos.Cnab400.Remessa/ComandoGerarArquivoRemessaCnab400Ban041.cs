using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban041 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban041, ComandoGerarLoteArquivoRemessaCnab400Ban041, ComandoGerarTraillerRemessaCnab400Ban041>
{
	public ComandoGerarArquivoRemessaCnab400Ban041()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}
}
