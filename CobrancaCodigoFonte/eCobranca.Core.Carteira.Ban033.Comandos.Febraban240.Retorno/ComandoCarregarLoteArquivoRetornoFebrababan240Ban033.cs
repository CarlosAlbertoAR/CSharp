using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban033 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban033, ComandoCarregarSegmentoTRetornoFebraban240Ban033, ComandoCarregarSegmentoURetornoFebraban240Ban033, ComandoCarregarTraillerLoteRetornoFebraban240Ban033>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban033(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}
}
