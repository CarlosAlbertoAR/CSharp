using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban748 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban748, ComandoCarregarSegmentoTRetornoFebraban240Ban748, ComandoCarregarSegmentoURetornoFebraban240Ban748, ComandoCarregarTraillerLoteRetornoFebraban240Ban748>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban748(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}
}
