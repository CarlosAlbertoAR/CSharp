using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban237 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban237, ComandoGerarLoteArquivoRemessaCnab400Ban237, ComandoGerarTraillerRemessaCnab400Ban237>
{
	public ComandoGerarArquivoRemessaCnab400Ban237()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
