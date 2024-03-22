using eCobranca.Core.Automacao.Febraban150.Retorno;
using eCobranca.Core.Automacao.Febraban240.Comandos;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban150.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoArquivoRetornoFebraban150 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoFebraban150 arquivo;

	private string linhaDadosRetorno;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public ArquivoCobrancaRetornoFebraban150 Arquivo => arquivo;

	public ComandoCarregarSegmentoArquivoRetornoFebraban150()
	{
		Logger.Debug("Criando comando para carregar segmento de arquivo de retorno no layout FEBRABAN150...");
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoFebraban150 arquivo, string linhaDados)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		linhaDadosRetorno = linhaDados;
	}
}
