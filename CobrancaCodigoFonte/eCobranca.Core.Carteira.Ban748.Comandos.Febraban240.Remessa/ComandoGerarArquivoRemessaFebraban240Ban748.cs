using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban748 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban748, ComandoGerarLoteArquivoRemessaFebraban240Ban748, ComandoGerarHeaderLoteRemessaFebraban240Ban748, ComandoGerarSegmentoPRemessaFebraban240Ban748, ComandoGerarSegmentoQRemessaFebraban240Ban748, ComandoGerarSegmentoRRemessaFebraban240Ban748, ComandoGerarTraillerLoteRemessaFebraban240Ban748, ComandoGerarTraillerArquivoRemessaFebraban240Ban748>
{
	public ComandoGerarArquivoRemessaFebraban240Ban748(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}
}
