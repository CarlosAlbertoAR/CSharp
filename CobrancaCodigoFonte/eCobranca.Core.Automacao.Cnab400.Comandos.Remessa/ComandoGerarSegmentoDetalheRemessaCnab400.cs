using eCobranca.Core.Automacao.Cnab400.Estrutura;
using eCobranca.Core.Carteira;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Comandos.Remessa;

public abstract class ComandoGerarSegmentoDetalheRemessaCnab400 : ComandoCnab400
{
	private CarteiraCobranca carteira;

	private SegmentoCnab400 segmento;

	private DocumentoCobranca documento;

	public CarteiraCobranca Carteira => carteira;

	public SegmentoCnab400 Segmento => segmento;

	public DocumentoCobranca Documento => documento;

	public ComandoGerarSegmentoDetalheRemessaCnab400()
	{
		Logger.Debug("Criando comando para gerar segmento de detalhe de arquivo de remessa no laydout CNAB400...");
	}

	protected string GetMensagem(EnumTipoMensagemCnab400 tipo)
	{
		string result = "";
		switch (tipo)
		{
		case EnumTipoMensagemCnab400.MENSAGEM_MULTA:
		{
			double num3 = ((documento.ValorMultaAtraso > 0.0) ? documento.ValorMultaAtraso : ((documento.PercentualMultaAtraso > 0.0) ? (documento.PercentualMultaAtraso / 100.0 * documento.ValorDocumento) : 0.0));
			result = ((num3 > 0.0) ? ("APOS VENCIMENTO COBRAR MULTA DE R$ " + MaskUtil.AplicarMascaraValorMonetario(num3)) : "");
			break;
		}
		case EnumTipoMensagemCnab400.MENSAGEM_JUROS:
		{
			double num = ((documento.ValorJurosDiasAtraso > 0.0) ? documento.ValorJurosDiasAtraso : ((documento.PercentualJurosDiaAtraso > 0.0) ? (documento.PercentualJurosDiaAtraso / 100.0 * documento.ValorDocumento) : 0.0));
			result = ((num > 0.0) ? ("APOS VENCIMENTO COBRAR JUROS DE R$ " + MaskUtil.AplicarMascaraValorMonetario(num) + " AO DIA") : "");
			break;
		}
		case EnumTipoMensagemCnab400.MENSAGEM_DESCONTO:
		{
			double num2 = ((documento.ValorDesconto > 0.0) ? documento.ValorDesconto : ((documento.PercentualDesconto > 0.0) ? (documento.PercentualDesconto / 100.0 * documento.ValorDocumento) : 0.0));
			result = ((num2 > 0.0) ? ("ATÉ O VENCIMENTO CONCEDER DESCONTO DE R$ " + MaskUtil.AplicarMascaraValorMonetario(num2)) : "");
			break;
		}
		case EnumTipoMensagemCnab400.MENSAGEM_PROTESTO:
			result = ((documento.DiasProtesto <= 0) ? "" : (documento.ProtestoDiasUteis ? ("PROTESTAR APOS " + documento.DiasProtesto + " DIAS UTEIS DO VENCIMENTO") : ("PROTESTAR APOS " + documento.DiasProtesto + " DIAS CORRIDOS DO VENCIMENTO")));
			break;
		}
		return result;
	}

	public virtual void PrepararComando(CarteiraCobranca carteira, SegmentoCnab400 segmento, DocumentoCobranca documento)
	{
		this.carteira = carteira;
		this.segmento = segmento;
		this.documento = documento;
	}
}
