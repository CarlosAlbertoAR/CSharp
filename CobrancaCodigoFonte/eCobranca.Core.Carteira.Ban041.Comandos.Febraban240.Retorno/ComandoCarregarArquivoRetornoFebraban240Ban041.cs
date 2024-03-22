using eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Febraban240.Retorno;

public class ComandoCarregarArquivoRetornoFebraban240Ban041 : ComandoCarregarArquivoRetornoFebraban240<ComandoCarregarHeaderArquivoRetornoFebraban240Ban041, ComandoCarregarLoteArquivoRetornoFebrababan240Ban041, ComandoCarregarHeaderLoteRetornoFebrabab240Ban041, ComandoCarregarSegmentoTRetornoFebraban240Ban041, ComandoCarregarSegmentoURetornoFebraban240Ban041, ComandoCarregarTraillerLoteRetornoFebraban240Ban041, ComandoCarregarTraillerArquivoRetornoFebraban240Ban041>
{
	public ComandoCarregarArquivoRetornoFebraban240Ban041(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para carregar o arquivo FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}
}
