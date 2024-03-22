using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan136 : ProvedorDadosModeloBoleto
{
	public override string GetLocalPagamento()
	{
		if (!(ParameterUtil.GetInstance().GetValorParametroAdicional(EnumParametrosAdicionaisConfiguracao.BOL_PAGAMENTO_SOMENTE_BANCO_CEDENTE, carteira.ConfiguracaoBoleto.ParametrosDisponiveis.Boleto.PagamentoSomenteNoBancoCedente(), carteira.ConfiguracaoBoleto.ParametrosAdicionais) == "S") || 1 == 0)
		{
			if (!string.IsNullOrEmpty(dc.LocalPagamento))
			{
				return StringUtil.TruncateString(dc.LocalPagamento.ToUpper(), 90);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LocalPagamento))
			{
				return StringUtil.TruncateString(carteira.ConfiguracaoBoleto.LocalPagamento.ToUpper(), 90);
			}
			return StringUtil.TruncateString($"PAGÁVEL PREFERENCIALMENTE NA UNICRED", 90);
		}
		return StringUtil.TruncateString($"PAGÁVEL APENAS NAS AGÊNCIAS DO {carteira.ConfiguracaoCarteiraCobranca.Banco.ToEnum<EnumCodigoBanco>().Descricao()}.".ToUpper(), 90);
	}
}
