using eCobranca.Core.Automacao.Febraban240.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoArquivoRetornoFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoFebraban240 arquivo;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public ArquivoCobrancaRetornoFebraban240 Arquivo => arquivo;

	public ComandoCarregarSegmentoArquivoRetornoFebraban240()
	{
		Logger.Debug("Criando comando para carregar segmento de arquivo de retorno no layout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoFebraban240 arquivo, string linhaDados)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		linhaDadosRetorno = linhaDados;
	}
}
