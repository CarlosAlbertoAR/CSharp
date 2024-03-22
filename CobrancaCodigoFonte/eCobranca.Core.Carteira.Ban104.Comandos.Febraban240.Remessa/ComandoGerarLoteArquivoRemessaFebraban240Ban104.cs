using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban104 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban104, ComandoGerarSegmentoPRemessaFebraban240Ban104, ComandoGerarSegmentoQRemessaFebraban240Ban104, ComandoGerarSegmentoRRemessaFebraban240Ban104, ComandoGerarTraillerLoteRemessaFebraban240Ban104>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban104(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}
}
