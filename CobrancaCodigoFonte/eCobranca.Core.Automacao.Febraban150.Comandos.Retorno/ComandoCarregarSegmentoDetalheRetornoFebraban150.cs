using eCobranca.Core.Automacao.Febraban150.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoDetalheRetornoFebraban150 : ComandoFebraban150
{
	private CarteiraCobranca carteira;

	private SegmentoDetalheFebraban150 segmento;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public SegmentoDetalheFebraban150 Segmento => segmento;

	public ComandoCarregarSegmentoDetalheRetornoFebraban150()
	{
		Logger.Debug("Criando comando para carregar segmento de detalhe de arquivo de retorno no layout FEBRABAN150...");
	}

	public void Preparar(CarteiraCobranca carteira, SegmentoDetalheFebraban150 segmento, string linhaDados)
	{
		this.carteira = carteira;
		this.segmento = segmento;
		linhaDadosRetorno = linhaDados;
	}
}
