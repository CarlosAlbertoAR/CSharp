using eCobranca.Core.Automacao.Cnab400.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;

public abstract class ComandoGerarSegmentoArquivoRemessaCnab400 : ComandoCnab400
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRemessaCnab400 arquivo;

	public CarteiraCobranca Carteira => carteira;

	public ArquivoCobrancaRemessaCnab400 Arquivo => arquivo;

	public ComandoGerarSegmentoArquivoRemessaCnab400()
	{
		Logger.Debug("Criando comando para gerar segmento de arquivo de remessa no layout CNAB400...");
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRemessaCnab400 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
	}
}
