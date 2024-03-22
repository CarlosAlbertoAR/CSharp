using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban756 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban756, ComandoGerarLoteArquivoRemessaFebraban240Ban756, ComandoGerarHeaderLoteRemessaFebraban240Ban756, ComandoGerarSegmentoPRemessaFebraban240Ban756, ComandoGerarSegmentoQRemessaFebraban240Ban756, ComandoGerarSegmentoRRemessaFebraban240Ban756, ComandoGerarTraillerLoteRemessaFebraban240Ban756, ComandoGerarTraillerArquivoRemessaFebraban240Ban756>
{
	public ComandoGerarArquivoRemessaFebraban240Ban756(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}
}
