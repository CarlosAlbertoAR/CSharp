using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban037.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban037 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban037, ComandoCarregarSegmentoTRetornoFebraban240Ban037, ComandoCarregarSegmentoURetornoFebraban240Ban037, ComandoCarregarTraillerLoteRetornoFebraban240Ban037>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban037(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA}]...");
	}
}
