using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;

public abstract class ComandoGerarSegmentoLoteRemessaCnab400 : ComandoCnab400
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRemessaCnab400 lote;

	public CarteiraCobranca Carteira => carteira;

	public LoteCobrancaRemessaCnab400 Lote => lote;

	public ComandoGerarSegmentoLoteRemessaCnab400()
	{
		Logger.Debug("Criando comando para gerar segmento de Lote de remessa no layout CNAB400...");
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRemessaCnab400 lote)
	{
		this.carteira = carteira;
		this.lote = lote;
	}
}
