using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban237.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban237 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban237, ComandoGerarLoteArquivoRemessaFebraban240Ban237, ComandoGerarHeaderLoteRemessaFebraban240Ban237, ComandoGerarSegmentoPRemessaFebraban240Ban237, ComandoGerarSegmentoQRemessaFebraban240Ban237, ComandoGerarSegmentoRRemessaFebraban240Ban237, ComandoGerarTraillerLoteRemessaFebraban240Ban237, ComandoGerarTraillerArquivoRemessaFebraban240Ban237>
{
	public ComandoGerarArquivoRemessaFebraban240Ban237(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_BRADESCO}]...");
	}
}
