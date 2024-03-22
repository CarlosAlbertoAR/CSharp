using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban133.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban133 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban133, ComandoGerarLoteArquivoRemessaCnab400Ban133, ComandoGerarTraillerRemessaCnab400Ban133>
{
	public ComandoGerarArquivoRemessaCnab400Ban133()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.CRESOL}]...");
	}
}
