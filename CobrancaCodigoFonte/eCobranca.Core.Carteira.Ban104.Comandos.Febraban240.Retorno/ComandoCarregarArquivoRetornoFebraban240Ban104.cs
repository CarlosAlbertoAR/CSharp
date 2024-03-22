using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban104 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban104, ComandoCarregarLoteArquivoRetornoFebrababan240Ban104, ComandoCarregarHeaderLoteRetornoFebrabab240Ban104, ComandoCarregarSegmentoTRetornoFebraban240Ban104, ComandoCarregarSegmentoURetornoFebraban240Ban104, ComandoCarregarTraillerLoteRetornoFebraban240Ban104, ComandoCarregarTraillerArquivoRetornoFebraban240Ban104>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban104(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}
}
