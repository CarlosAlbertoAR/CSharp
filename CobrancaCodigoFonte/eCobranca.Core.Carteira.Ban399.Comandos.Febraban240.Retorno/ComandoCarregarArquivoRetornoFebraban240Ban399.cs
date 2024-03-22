using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban399 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban399, ComandoCarregarLoteArquivoRetornoFebrababan240Ban399, ComandoCarregarHeaderLoteRetornoFebrabab240Ban399, ComandoCarregarSegmentoTRetornoFebraban240Ban399, ComandoCarregarSegmentoURetornoFebraban240Ban399, ComandoCarregarTraillerLoteRetornoFebraban240Ban399, ComandoCarregarTraillerArquivoRetornoFebraban240Ban399>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban399(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}
}
