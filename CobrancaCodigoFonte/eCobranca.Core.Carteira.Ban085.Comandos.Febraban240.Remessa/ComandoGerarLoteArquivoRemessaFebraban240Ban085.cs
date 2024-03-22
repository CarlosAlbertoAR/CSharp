using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban085 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban085, ComandoGerarSegmentoPRemessaFebraban240Ban085, ComandoGerarSegmentoQRemessaFebraban240Ban085, ComandoGerarSegmentoRRemessaFebraban240Ban085, ComandoGerarTraillerLoteRemessaFebraban240Ban085>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban085(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}
}
