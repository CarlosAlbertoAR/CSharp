using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban422.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban422 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban422, ComandoGerarSegmentoPRemessaFebraban240Ban422, ComandoGerarSegmentoQRemessaFebraban240Ban422, ComandoGerarSegmentoRRemessaFebraban240Ban422, ComandoGerarTraillerLoteRemessaFebraban240Ban422>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban422(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
	}
}
