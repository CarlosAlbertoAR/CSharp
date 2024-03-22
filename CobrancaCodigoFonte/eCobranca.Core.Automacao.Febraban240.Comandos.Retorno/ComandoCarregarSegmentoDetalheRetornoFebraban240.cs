using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoDetalheRetornoFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private SegmentoDetalheFebraban240 segmento;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public SegmentoDetalheFebraban240 Segmento => segmento;

	public ComandoCarregarSegmentoDetalheRetornoFebraban240()
	{
		Logger.Debug("Criando comando para carregar segmento de detalhe de arquivo de retorno no layout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, SegmentoDetalheFebraban240 segmento, string linhaDados)
	{
		this.carteira = carteira;
		this.segmento = segmento;
		linhaDadosRetorno = linhaDados;
	}
}
