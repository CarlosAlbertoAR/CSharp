using eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Retorno;

public abstract class ComandoCarregarSegmentoDetalheRetornoCnab400 : ComandoCnab400
{
	private CarteiraCobranca carteira;

	private DetalheRetornoCnab400 segmento;

	private string linhaDadosRetorno;

	public CarteiraCobranca Carteira => carteira;

	public DetalheRetornoCnab400 Segmento => segmento;

	public string LinhaDadosRetorno => linhaDadosRetorno;

	public ComandoCarregarSegmentoDetalheRetornoCnab400()
	{
		Logger.Debug("Criando comando para carregar segmento de detalhe de arquivo de retorno no layout CNAB400...");
	}

	public void Preparar(CarteiraCobranca carteira, DetalheRetornoCnab400 segmento, string linhaDadosRetorno)
	{
		this.carteira = carteira;
		this.segmento = segmento;
		this.linhaDadosRetorno = linhaDadosRetorno;
	}
}
