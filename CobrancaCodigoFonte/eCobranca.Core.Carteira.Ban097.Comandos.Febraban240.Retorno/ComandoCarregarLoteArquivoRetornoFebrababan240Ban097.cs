using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban097 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban097, ComandoCarregarSegmentoTRetornoFebraban240Ban097, ComandoCarregarSegmentoURetornoFebraban240Ban097, ComandoCarregarTraillerLoteRetornoFebraban240Ban097>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban097(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
