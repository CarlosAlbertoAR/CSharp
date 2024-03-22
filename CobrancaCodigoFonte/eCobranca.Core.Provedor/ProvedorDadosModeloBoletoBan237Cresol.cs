using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan237Cresol : ProvedorDadosModeloBoletoBan237
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
		return StringUtil.TruncateString($"PAGÁVEL PREFERENCIALMENTE NA REDE CRESOL OU ASCOOB.", 90);
	}

	public override string GetNomeCedente()
	{
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario))
		{
			return StringUtil.TruncateString("Cresol Conf. - " + carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario, 80);
		}
		return "";
	}

	public override string GetIdentificacaoCedente()
	{
		string empty = string.Empty;
		empty += GetNomeCedente();
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor))
		{
			empty = empty + " CNPJ: " + StringUtil.TruncateString((carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor, 18);
		}
		return empty;
	}

	public override string GetIdentificacaoSacadorAvalista()
	{
		return string.Concat(string.Empty + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario, 70), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario, 18));
	}
}
