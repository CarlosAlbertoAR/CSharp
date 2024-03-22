using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban237 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban237, ComandoCarregarLoteArquivoRetornoFebrababan240Ban237, ComandoCarregarHeaderLoteRetornoFebrabab240Ban237, ComandoCarregarSegmentoTRetornoFebraban240Ban237, ComandoCarregarSegmentoURetornoFebraban240Ban237, ComandoCarregarTraillerLoteRetornoFebraban240Ban237, ComandoCarregarTraillerArquivoRetornoFebraban240Ban237>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban237(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
