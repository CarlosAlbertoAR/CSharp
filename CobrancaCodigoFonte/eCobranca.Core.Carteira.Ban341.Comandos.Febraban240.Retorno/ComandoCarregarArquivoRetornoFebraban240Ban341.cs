using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban341 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban341, ComandoCarregarLoteArquivoRetornoFebrababan240Ban341, ComandoCarregarHeaderLoteRetornoFebrabab240Ban341, ComandoCarregarSegmentoTRetornoFebraban240Ban341, ComandoCarregarSegmentoURetornoFebraban240Ban341, ComandoCarregarTraillerLoteRetornoFebraban240Ban341, ComandoCarregarTraillerArquivoRetornoFebraban240Ban341>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban341(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}
}
