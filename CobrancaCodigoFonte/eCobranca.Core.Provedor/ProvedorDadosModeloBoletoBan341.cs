using eCobranca.Core.Carteira.Ban341;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan341 : ProvedorDadosModeloBoleto
{
	public override string GetLocalPagamento()
	{
		if (!string.IsNullOrEmpty(dc.LocalPagamento))
		{
			return StringUtil.TruncateString(dc.LocalPagamento.ToUpper(), 90);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LocalPagamento))
		{
			return StringUtil.TruncateString(carteira.ConfiguracaoBoleto.LocalPagamento.ToUpper(), 90);
		}
		return StringUtil.TruncateString($"ATÉ O VENCIMENTO PAGUE PREFERENCIALMENTE NO ITAÚ. APÓS O VENCIMENTO PAGUE SOMENTE NO ITAÚ.", 90);
	}

	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			if (carteira is CarteiraCobrancaBan341VariacaoNossoNumero15Digitos)
			{
				return dc.NossoNumero;
			}
			if (!string.IsNullOrEmpty(dc.NossoNumero) && !string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca))
			{
				return carteira.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + "/" + dc.NossoNumero;
			}
			return "";
		}
		return "";
	}
}
