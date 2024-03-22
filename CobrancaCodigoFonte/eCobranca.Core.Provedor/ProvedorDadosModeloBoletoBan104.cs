using System.Text;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan104 : ProvedorDadosModeloBoleto
{
	public override string GetCarteira()
	{
		if (!carteira.ConfiguracaoCarteiraCobranca.CobrancaRegistrada)
		{
			return "SR";
		}
		return "RG";
	}

	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(dc.NossoNumero.Substring(0, 2));
			stringBuilder.Append("/");
			stringBuilder.Append(dc.NossoNumero.Substring(2));
			return stringBuilder.ToString();
		}
		return "";
	}

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
		return StringUtil.TruncateString($"PREFERENCIALMENTE NAS CASAS LOTÉRICAS ATÉ O VALOR LIMITE.", 90);
	}

	public override string GetAgenciaCodigoCedente()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string value = StringUtil.ObterValorDeCampoMascarado((carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor, 1);
		string valor = (carteira.DadosConfiguracao[2] as DadoConfiguracao).Valor;
		string dVModulo = DVGenerator.GetDVModulo11(valor.ToString());
		stringBuilder.Append(value);
		stringBuilder.Append("/");
		stringBuilder.Append(valor);
		stringBuilder.Append("-");
		stringBuilder.Append(dVModulo);
		return stringBuilder.ToString();
	}
}
