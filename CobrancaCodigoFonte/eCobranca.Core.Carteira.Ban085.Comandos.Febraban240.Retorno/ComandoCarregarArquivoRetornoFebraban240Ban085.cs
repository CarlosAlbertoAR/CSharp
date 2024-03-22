using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban085 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban085, ComandoCarregarLoteArquivoRetornoFebrababan240Ban085, ComandoCarregarHeaderLoteRetornoFebrabab240Ban085, ComandoCarregarSegmentoTRetornoFebraban240Ban085, ComandoCarregarSegmentoURetornoFebraban240Ban085, ComandoCarregarTraillerLoteRetornoFebraban240Ban085, ComandoCarregarTraillerArquivoRetornoFebraban240Ban085>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban085(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}
}
