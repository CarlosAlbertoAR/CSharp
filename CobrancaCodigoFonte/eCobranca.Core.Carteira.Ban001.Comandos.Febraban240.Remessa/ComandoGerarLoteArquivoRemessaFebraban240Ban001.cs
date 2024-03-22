using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban001 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban001, ComandoGerarSegmentoPRemessaFebraban240Ban001, ComandoGerarSegmentoQRemessaFebraban240Ban001, ComandoGerarSegmentoRRemessaFebraban240Ban001, ComandoGerarTraillerLoteRemessaFebraban240Ban001>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban001(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
