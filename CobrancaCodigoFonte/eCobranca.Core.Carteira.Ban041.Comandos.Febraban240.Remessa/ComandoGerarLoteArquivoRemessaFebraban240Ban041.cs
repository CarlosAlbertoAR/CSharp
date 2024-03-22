using eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Carteira.Ban041.Comandos.Febraban240.Remessa;

public class ComandoGerarLoteArquivoRemessaFebraban240Ban041 : ComandoGerarLoteArquivoRemessaFebraban240<ComandoGerarHeaderLoteRemessaFebraban240Ban041, ComandoGerarSegmentoPRemessaFebraban240Ban041, ComandoGerarSegmentoQRemessaFebraban240Ban041, ComandoGerarSegmentoRRemessaFebraban240Ban041, ComandoGerarTraillerLoteRemessaFebraban240Ban041>
{
	public ComandoGerarLoteArquivoRemessaFebraban240Ban041(CarteiraCobranca carteira)
		: base(carteira)
	{
		Logger.Debug($"Criando macro comando para gerar LOTE DE ARQUIVO de remessa FEBRABAN240 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
	}
}
