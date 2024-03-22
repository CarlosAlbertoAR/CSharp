using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban001 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban001, ComandoCarregarLoteArquivoRetornoFebrababan240Ban001, ComandoCarregarHeaderLoteRetornoFebrabab240Ban001, ComandoCarregarSegmentoTRetornoFebraban240Ban001, ComandoCarregarSegmentoURetornoFebraban240Ban001, ComandoCarregarTraillerLoteRetornoFebraban240Ban001, ComandoCarregarTraillerArquivoRetornoFebraban240Ban001>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban001(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
