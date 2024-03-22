using eCobranca.Core.Automacao.Cnab400.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoArquivoRetornoCnab400 : ComandoCnab400
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRetornoCnab400 arquivo;

	private string linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public ArquivoCobrancaRetornoCnab400 Arquivo => arquivo;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public ComandoCarregarSegmentoArquivoRetornoCnab400()
	{
		Logger.Debug("Criando comando para carregar segmento de arquivo de retorno no layout CNAB400...");
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRetornoCnab400 arquivo, string linhaDadosRetorno)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
		this.linhaDadosRetorno = linhaDadosRetorno;
	}
}
