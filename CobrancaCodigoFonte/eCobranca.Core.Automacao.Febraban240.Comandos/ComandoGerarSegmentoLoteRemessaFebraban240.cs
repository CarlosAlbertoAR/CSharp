using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos;

public abstract class ComandoGerarSegmentoLoteRemessaFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRemessaFebraban240 lote;

	public CarteiraCobranca Carteira => carteira;

	public LoteCobrancaRemessaFebraban240 Lote => lote;

	public ComandoGerarSegmentoLoteRemessaFebraban240()
	{
		Logger.Debug("Criando comando para gerar segmento de Lote de remessa no layout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRemessaFebraban240 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
	}
}
