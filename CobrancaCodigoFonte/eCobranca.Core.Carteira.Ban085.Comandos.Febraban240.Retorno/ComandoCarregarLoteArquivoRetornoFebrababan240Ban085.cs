using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban085 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban085, ComandoCarregarSegmentoTRetornoFebraban240Ban085, ComandoCarregarSegmentoURetornoFebraban240Ban085, ComandoCarregarTraillerLoteRetornoFebraban240Ban085>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban085(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}
}
