using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban003 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban003, ComandoCarregarLoteArquivoRetornoFebrababan240Ban003, ComandoCarregarHeaderLoteRetornoFebrabab240Ban003, ComandoCarregarSegmentoTRetornoFebraban240Ban003, ComandoCarregarSegmentoURetornoFebraban240Ban003, ComandoCarregarTraillerLoteRetornoFebraban240Ban003, ComandoCarregarTraillerArquivoRetornoFebraban240Ban003>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban003(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}
}
