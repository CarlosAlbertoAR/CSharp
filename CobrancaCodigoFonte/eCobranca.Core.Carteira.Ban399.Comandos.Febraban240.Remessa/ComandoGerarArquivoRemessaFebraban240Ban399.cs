using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban399.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban399 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban399, ComandoGerarLoteArquivoRemessaFebraban240Ban399, ComandoGerarHeaderLoteRemessaFebraban240Ban399, ComandoGerarSegmentoPRemessaFebraban240Ban399, ComandoGerarSegmentoQRemessaFebraban240Ban399, ComandoGerarSegmentoRRemessaFebraban240Ban399, ComandoGerarTraillerLoteRemessaFebraban240Ban399, ComandoGerarTraillerArquivoRemessaFebraban240Ban399>
{
	public ComandoGerarArquivoRemessaFebraban240Ban399(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.HSBC_BANK_BRASIL}]...");
	}
}
