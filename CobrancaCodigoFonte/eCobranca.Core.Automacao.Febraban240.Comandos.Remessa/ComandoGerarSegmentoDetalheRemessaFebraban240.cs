using eCobranca.Core.Automacao.Febraban240.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;

namespace eCobranca.Core.Automacao.Febraban240.Comandos.Remessa;

public abstract class ComandoGerarSegmentoDetalheRemessaFebraban240 : ComandoFebraban240
{
	private CarteiraCobranca carteira;

	private SegmentoDetalheFebraban240 segmento;

	private DocumentoCobranca documento;

	public DocumentoCobranca Documento => documento;

	public SegmentoDetalheFebraban240 Segmento => segmento;

	public CarteiraCobranca Carteira => carteira;

	public ComandoGerarSegmentoDetalheRemessaFebraban240()
	{
		Logger.Debug("Criando comando para gerar segmento de detalhe de arquivo de remessa no laydout FEBRABAN240...");
	}

	public void Preparar(CarteiraCobranca carteira, SegmentoDetalheFebraban240 segmento, DocumentoCobranca documento)
	{
		this.carteira = carteira;
		this.segmento = segmento;
		this.documento = documento;
	}
}
