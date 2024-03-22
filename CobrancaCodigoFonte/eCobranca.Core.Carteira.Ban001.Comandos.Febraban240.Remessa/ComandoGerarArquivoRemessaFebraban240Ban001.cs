using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban001.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban001 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban001, ComandoGerarLoteArquivoRemessaFebraban240Ban001, ComandoGerarHeaderLoteRemessaFebraban240Ban001, ComandoGerarSegmentoPRemessaFebraban240Ban001, ComandoGerarSegmentoQRemessaFebraban240Ban001, ComandoGerarSegmentoRRemessaFebraban240Ban001, ComandoGerarTraillerLoteRemessaFebraban240Ban001, ComandoGerarTraillerArquivoRemessaFebraban240Ban001>
{
	public ComandoGerarArquivoRemessaFebraban240Ban001(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
	}
}
