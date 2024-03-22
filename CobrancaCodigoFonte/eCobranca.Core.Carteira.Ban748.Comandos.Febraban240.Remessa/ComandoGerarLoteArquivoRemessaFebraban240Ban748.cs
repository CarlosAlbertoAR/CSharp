using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban748.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban748 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban748, ComandoGerarSegmentoPRemessaFebraban240Ban748, ComandoGerarSegmentoQRemessaFebraban240Ban748, ComandoGerarSegmentoRRemessaFebraban240Ban748, ComandoGerarTraillerLoteRemessaFebraban240Ban748>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban748(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_SICREDI}]...");
	}
}
