using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban422 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban422, ComandoCarregarSegmentoTRetornoFebraban240Ban422, ComandoCarregarSegmentoURetornoFebraban240Ban422, ComandoCarregarTraillerLoteRetornoFebraban240Ban422>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban422(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
