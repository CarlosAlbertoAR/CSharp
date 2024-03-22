using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban004.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban004 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban004, ComandoGerarLoteArquivoRemessaCnab400Ban004, ComandoGerarTraillerRemessaCnab400Ban004>
{
	public ComandoGerarArquivoRemessaCnab400Ban004()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_NORDESTE_DO_BRASIL}]...");
	}
}
