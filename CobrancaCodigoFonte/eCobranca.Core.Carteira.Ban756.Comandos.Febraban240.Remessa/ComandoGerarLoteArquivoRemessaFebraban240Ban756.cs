using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban756.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban756 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban756, ComandoGerarSegmentoPRemessaFebraban240Ban756, ComandoGerarSegmentoQRemessaFebraban240Ban756, ComandoGerarSegmentoRRemessaFebraban240Ban756, ComandoGerarTraillerLoteRemessaFebraban240Ban756>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban756(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_COOPERATIVO_DO_BRASIL}]...");
	}
}
