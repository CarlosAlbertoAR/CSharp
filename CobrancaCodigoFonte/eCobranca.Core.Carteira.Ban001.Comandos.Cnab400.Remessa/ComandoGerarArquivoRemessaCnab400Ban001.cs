using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban001 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban001, ComandoGerarLoteArquivoRemessaCnab400Ban001, ComandoGerarTraillerRemessaCnab400Ban001>
{
	public ComandoGerarArquivoRemessaCnab400Ban001()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
