using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban003 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban003, ComandoCarregarSegmentoTRetornoFebraban240Ban003, ComandoCarregarSegmentoURetornoFebraban240Ban003, ComandoCarregarTraillerLoteRetornoFebraban240Ban003>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban003(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}
}
