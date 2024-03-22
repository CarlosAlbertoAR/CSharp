using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban237 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban237, ComandoGerarSegmentoPRemessaFebraban240Ban237, ComandoGerarSegmentoQRemessaFebraban240Ban237, ComandoGerarSegmentoRRemessaFebraban240Ban237, ComandoGerarTraillerLoteRemessaFebraban240Ban237>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban237(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
