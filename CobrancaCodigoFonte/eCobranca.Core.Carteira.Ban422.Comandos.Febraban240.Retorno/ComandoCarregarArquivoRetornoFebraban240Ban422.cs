using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban422 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban422, ComandoCarregarLoteArquivoRetornoFebrababan240Ban422, ComandoCarregarHeaderLoteRetornoFebrabab240Ban422, ComandoCarregarSegmentoTRetornoFebraban240Ban422, ComandoCarregarSegmentoURetornoFebraban240Ban422, ComandoCarregarTraillerLoteRetornoFebraban240Ban422, ComandoCarregarTraillerArquivoRetornoFebraban240Ban422>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban422(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
