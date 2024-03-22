using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban001 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban001, ComandoCarregarSegmentoTRetornoFebraban240Ban001, ComandoCarregarSegmentoURetornoFebraban240Ban001, ComandoCarregarTraillerLoteRetornoFebraban240Ban001>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban001(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
