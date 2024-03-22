using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban037.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban037 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban037, ComandoCarregarLoteArquivoRetornoFebrababan240Ban037, ComandoCarregarHeaderLoteRetornoFebrabab240Ban037, ComandoCarregarSegmentoTRetornoFebraban240Ban037, ComandoCarregarSegmentoURetornoFebraban240Ban037, ComandoCarregarTraillerLoteRetornoFebraban240Ban037, ComandoCarregarTraillerArquivoRetornoFebraban240Ban037>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban037(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA}]...");
	}
}
