using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban033 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban033, ComandoCarregarLoteArquivoRetornoFebrababan240Ban033, ComandoCarregarHeaderLoteRetornoFebrabab240Ban033, ComandoCarregarSegmentoTRetornoFebraban240Ban033, ComandoCarregarSegmentoURetornoFebraban240Ban033, ComandoCarregarTraillerLoteRetornoFebraban240Ban033, ComandoCarregarTraillerArquivoRetornoFebraban240Ban033>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban033(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}
}
