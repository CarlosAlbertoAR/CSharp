using eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban150.Retorno;

public class ComandoCarregarArquivoRetornoFebraban150Ban003 : ComandoCarregarArquivoRetornoFebraban150<ComandoCarregarHeaderArquivoRetornoFebraban150Ban003, ComandoCarregarLoteArquivoRetornoFebrababan150Ban003, ComandoCarregarSegmentoGRetornoFebraban150Ban003, ComandoCarregarTraillerArquivoRetornoFebraban150Ban003>
{
	public ComandoCarregarArquivoRetornoFebraban150Ban003()
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}
}
