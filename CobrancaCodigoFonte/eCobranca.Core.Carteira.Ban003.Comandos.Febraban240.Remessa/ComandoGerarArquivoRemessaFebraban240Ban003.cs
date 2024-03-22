using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban003.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban003 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban003, ComandoGerarLoteArquivoRemessaFebraban240Ban003, ComandoGerarHeaderLoteRemessaFebraban240Ban003, ComandoGerarSegmentoPRemessaFebraban240Ban003, ComandoGerarSegmentoQRemessaFebraban240Ban003, ComandoGerarSegmentoRRemessaFebraban240Ban003, ComandoGerarTraillerLoteRemessaFebraban240Ban003, ComandoGerarTraillerArquivoRemessaFebraban240Ban003>
{
	public ComandoGerarArquivoRemessaFebraban240Ban003(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_DA_AMAZONIA}]...");
	}
}
