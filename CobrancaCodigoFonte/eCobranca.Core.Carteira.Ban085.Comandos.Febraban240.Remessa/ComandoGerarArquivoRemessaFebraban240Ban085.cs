using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban085.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban085 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban085, ComandoGerarLoteArquivoRemessaFebraban240Ban085, ComandoGerarHeaderLoteRemessaFebraban240Ban085, ComandoGerarSegmentoPRemessaFebraban240Ban085, ComandoGerarSegmentoQRemessaFebraban240Ban085, ComandoGerarSegmentoRRemessaFebraban240Ban085, ComandoGerarTraillerLoteRemessaFebraban240Ban085, ComandoGerarTraillerArquivoRemessaFebraban240Ban085>
{
	public ComandoGerarArquivoRemessaFebraban240Ban085(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_AILOS}]...");
	}
}
