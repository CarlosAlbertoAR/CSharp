using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoLoteRetornoFebraban150 : ComandoFebraban150
{
	private CarteiraCobranca carteira;

	private LoteCobrancaRetornoFebraban150 lote;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public LoteCobrancaRetornoFebraban150 Lote => lote;

	public ComandoCarregarSegmentoLoteRetornoFebraban150()
	{
		Logger.Debug("Criando comando para carregar segmento de lote de arquivo de retorno no layout FEBRABAN150...");
	}

	public void Preparar(CarteiraCobranca carteira, LoteCobrancaRetornoFebraban150 lote, string linhaDados)
	{
		this.carteira = carteira;
		this.lote = lote;
		linhaDadosRetorno = linhaDados;
	}
}
