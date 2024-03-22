using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban104 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban104, ComandoGerarLoteArquivoRemessaCnab400Ban104, ComandoGerarTraillerRemessaCnab400Ban104>
{
	public ComandoGerarArquivoRemessaCnab400Ban104()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}
}
