using eCobranca.Core.Automacao.Febraban240.Remessa;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;

public abstract class ComandoGerarSegmentoArquivoRemessaFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private ArquivoCobrancaRemessaFebraban240 arquivo;

	public ArquivoCobrancaRemessaFebraban240 Arquivo => arquivo;

	public CarteiraCobranca Carteira => carteira;

	public ComandoGerarSegmentoArquivoRemessaFebraban240()
	{
		Logger.Debug("Criando comando para gerar segmento de arquivo de remessa no layout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, ArquivoCobrancaRemessaFebraban240 arquivo)
	{
		this.carteira = carteira;
		this.arquivo = arquivo;
	}
}
