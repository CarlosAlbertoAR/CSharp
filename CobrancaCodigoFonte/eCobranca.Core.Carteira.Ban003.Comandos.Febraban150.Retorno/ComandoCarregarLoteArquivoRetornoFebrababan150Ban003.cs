using eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban150.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan150Ban003 : ComandoCarregarLoteArquivoRetornoFebraban150<ComandoCarregarSegmentoGRetornoFebraban150Ban003>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan150Ban003()
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN150 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}
}
