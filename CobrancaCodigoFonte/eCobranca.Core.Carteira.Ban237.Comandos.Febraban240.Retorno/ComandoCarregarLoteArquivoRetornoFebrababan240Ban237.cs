using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Retorno;

public class ComandoCarregarLoteArquivoRetornoFebrababan240Ban237 : ComandoCarregarLoteArquivoRetornoFebraban240<ComandoCarregarHeaderLoteRetornoFebrabab240Ban237, ComandoCarregarSegmentoTRetornoFebraban240Ban237, ComandoCarregarSegmentoURetornoFebraban240Ban237, ComandoCarregarTraillerLoteRetornoFebraban240Ban237>
{
	public ComandoCarregarLoteArquivoRetornoFebrababan240Ban237(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar lote do arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
