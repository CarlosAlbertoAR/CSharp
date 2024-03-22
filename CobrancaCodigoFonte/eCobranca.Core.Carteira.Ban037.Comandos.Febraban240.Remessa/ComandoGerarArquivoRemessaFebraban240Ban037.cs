using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban037.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban037 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban037, ComandoGerarLoteArquivoRemessaFebraban240Ban037, ComandoGerarHeaderLoteRemessaFebraban240Ban037, ComandoGerarSegmentoPRemessaFebraban240Ban037, ComandoGerarSegmentoQRemessaFebraban240Ban037, ComandoGerarSegmentoRRemessaFebraban240Ban037, ComandoGerarTraillerLoteRemessaFebraban240Ban037, ComandoGerarTraillerArquivoRemessaFebraban240Ban037>
{
	public ComandoGerarArquivoRemessaFebraban240Ban037(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_PARA}]...");
	}
}
