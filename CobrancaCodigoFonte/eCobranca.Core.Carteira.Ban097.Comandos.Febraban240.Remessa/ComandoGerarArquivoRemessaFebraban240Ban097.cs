using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban097.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban097 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban097, ComandoGerarLoteArquivoRemessaFebraban240Ban097, ComandoGerarHeaderLoteRemessaFebraban240Ban097, ComandoGerarSegmentoPRemessaFebraban240Ban097, ComandoGerarSegmentoQRemessaFebraban240Ban097, ComandoGerarSegmentoRRemessaFebraban240Ban097, ComandoGerarTraillerLoteRemessaFebraban240Ban097, ComandoGerarTraillerArquivoRemessaFebraban240Ban097>
{
	public ComandoGerarArquivoRemessaFebraban240Ban097(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_CREDITO_NOROESTE_BRASILEIRO}]...");
	}
}
