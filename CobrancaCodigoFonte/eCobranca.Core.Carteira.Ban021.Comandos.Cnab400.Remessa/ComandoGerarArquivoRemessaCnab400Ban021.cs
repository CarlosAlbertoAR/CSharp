using eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban021.Comandos.Cnab400.Remessa;

public class ComandoGerarArquivoRemessaCnab400Ban021 : ComandoGerarArquivoRemessaCnab400<ComandoGerarHeaderRemessaCnab400Ban021, ComandoGerarLoteArquivoRemessaCnab400Ban021, ComandoGerarTraillerRemessaCnab400Ban021>
{
	public ComandoGerarArquivoRemessaCnab400Ban021()
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
	}
}
