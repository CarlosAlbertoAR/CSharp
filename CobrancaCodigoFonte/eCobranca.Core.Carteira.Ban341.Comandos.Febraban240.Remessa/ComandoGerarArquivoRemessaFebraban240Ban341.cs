using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban341.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban341 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban341, ComandoGerarLoteArquivoRemessaFebraban240Ban341, ComandoGerarHeaderLoteRemessaFebraban240Ban341, ComandoGerarSegmentoPRemessaFebraban240Ban341, ComandoGerarSegmentoQRemessaFebraban240Ban341, ComandoGerarSegmentoRRemessaFebraban240Ban341, ComandoGerarTraillerLoteRemessaFebraban240Ban341, ComandoGerarTraillerArquivoRemessaFebraban240Ban341>
{
	public ComandoGerarArquivoRemessaFebraban240Ban341(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_ITAU}]...");
	}
}
