using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban104.Comandos.Febraban240.Remessa;

public class ComandoGerarArquivoRemessaFebraban240Ban104 : ComandoGerarArquivoRemessaFebraban240<ComandoGerarHeaderArquivoRemessaFebraban240Ban104, ComandoGerarLoteArquivoRemessaFebraban240Ban104, ComandoGerarHeaderLoteRemessaFebraban240Ban104, ComandoGerarSegmentoPRemessaFebraban240Ban104, ComandoGerarSegmentoQRemessaFebraban240Ban104, ComandoGerarSegmentoRRemessaFebraban240Ban104, ComandoGerarTraillerLoteRemessaFebraban240Ban104, ComandoGerarTraillerArquivoRemessaFebraban240Ban104>
{
	public ComandoGerarArquivoRemessaFebraban240Ban104(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar o arquivo de remessa FEBRABAN240 do [{EnumCodigoBanco.CAIXA_ECONOMICA_FEDERAL}]...");
	}
}
