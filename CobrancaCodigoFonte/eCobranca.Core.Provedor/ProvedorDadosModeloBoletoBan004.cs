using System;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan004 : ProvedorDadosModeloBoleto
{
	public override string GetCarteira()
	{
		return carteira.ConfiguracaoBoleto.CodigoCarteiraImpressao.Substring(1, 2);
	}

	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			return dc.NossoNumero + "  " + carteira.ConfiguracaoBoleto.CodigoCarteiraImpressao.Substring(1, 2);
		}
		return "";
	}

	public override string GetLocalPagamento()
	{
		return "ATÉ O VENCIMENTO PAGUE PREFERENCIALMENTE NO BANCO DO NORDESTE " + Environment.NewLine + "APÓS O VENCIMENTO PAGUE SOMENTE NO BANCO DO NORDESTE";
	}
}
