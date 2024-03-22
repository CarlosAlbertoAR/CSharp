using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban033.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban033 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban033, ComandoGerarLoteArquivoRemessaFebraban240Ban033, ComandoGerarHeaderLoteRemessaFebraban240Ban033, ComandoGerarSegmentoPRemessaFebraban240Ban033, ComandoGerarSegmentoQRemessaFebraban240Ban033, ComandoGerarSegmentoRRemessaFebraban240Ban033, ComandoGerarTraillerLoteRemessaFebraban240Ban033, ComandoGerarTraillerArquivoRemessaFebraban240Ban033>
{
	public ComandoGerarArquivoRemessaFebraban240Ban033(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
	}
}
