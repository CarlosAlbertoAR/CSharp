using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoLoteRetornoFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRetornoFebraban240 lote;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public LoteCobrancaRetornoFebraban240 Lote => lote;

	public ComandoCarregarSegmentoLoteRetornoFebraban240()
	{
		Logger.Debug("Criando comando para carregar segmento de lote de arquivo de retorno no layout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRetornoFebraban240 lote, string linhaDados)
	{
		this.carteira = carteira;
		this.lote = lote;
		linhaDadosRetorno = linhaDados;
	}
}
