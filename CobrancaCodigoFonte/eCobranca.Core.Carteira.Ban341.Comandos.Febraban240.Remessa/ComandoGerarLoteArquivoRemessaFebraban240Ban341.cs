using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban341 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban341, ComandoGerarSegmentoPRemessaFebraban240Ban341, ComandoGerarSegmentoQRemessaFebraban240Ban341, ComandoGerarSegmentoRRemessaFebraban240Ban341, ComandoGerarTraillerLoteRemessaFebraban240Ban341>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban341(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}
}
