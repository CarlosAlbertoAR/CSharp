using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban756 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban756, ComandoCarregarLoteArquivoRetornoFebrababan240Ban756, ComandoCarregarHeaderLoteRetornoFebrabab240Ban756, ComandoCarregarSegmentoTRetornoFebraban240Ban756, ComandoCarregarSegmentoURetornoFebraban240Ban756, ComandoCarregarTraillerLoteRetornoFebraban240Ban756, ComandoCarregarTraillerArquivoRetornoFebraban240Ban756>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban756(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}
}
