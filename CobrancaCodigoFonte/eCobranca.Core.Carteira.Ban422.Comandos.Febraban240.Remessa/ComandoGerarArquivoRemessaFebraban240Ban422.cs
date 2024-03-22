using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban422 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban422, ComandoGerarLoteArquivoRemessaFebraban240Ban422, ComandoGerarHeaderLoteRemessaFebraban240Ban422, ComandoGerarSegmentoPRemessaFebraban240Ban422, ComandoGerarSegmentoQRemessaFebraban240Ban422, ComandoGerarSegmentoRRemessaFebraban240Ban422, ComandoGerarTraillerLoteRemessaFebraban240Ban422, ComandoGerarTraillerArquivoRemessaFebraban240Ban422>
{
	public ComandoGerarArquivoRemessaFebraban240Ban422(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
