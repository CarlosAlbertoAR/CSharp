using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban341 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban341, ComandoGerarLoteArquivoRemessaCnab400Ban341, ComandoGerarTraillerRemessaCnab400Ban341>
{
	public ComandoGerarArquivoRemessaCnab400Ban341()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}
}
