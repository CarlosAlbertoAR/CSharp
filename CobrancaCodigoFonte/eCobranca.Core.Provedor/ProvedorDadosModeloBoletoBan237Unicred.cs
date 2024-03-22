using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan237Unicred : ProvedorDadosModeloBoletoBan237
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
		return StringUtil.TruncateString($"PAGÁVEL PREFERENCIALMENTE NA REDE BRADESCO OU BRADESCO EXPRESSO.", 90);
	}

	public override string GetNomeCedente()
	{
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[7] as DadoConfiguracao).Valor))
		{
			return StringUtil.TruncateString((carteira.DadosConfiguracao[7] as DadoConfiguracao).Valor, 40);
		}
		return "";
	}

	public override string GetIdentificacaoCedente()
	{
		string empty = string.Empty;
		empty += GetNomeCedente();
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[8] as DadoConfiguracao).Valor))
		{
			empty = empty + " ENDEREÇO: " + StringUtil.TruncateString((carteira.DadosConfiguracao[8] as DadoConfiguracao).Valor, 30);
		}
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[9] as DadoConfiguracao).Valor))
		{
			empty = empty + " - " + StringUtil.TruncateString((carteira.DadosConfiguracao[9] as DadoConfiguracao).Valor, 20);
		}
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[10] as DadoConfiguracao).Valor))
		{
			empty = empty + " - CIDADE: " + StringUtil.TruncateString((carteira.DadosConfiguracao[10] as DadoConfiguracao).Valor, 30);
		}
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[11] as DadoConfiguracao).Valor))
		{
			empty = empty + " - UF: " + StringUtil.TruncateString((carteira.DadosConfiguracao[11] as DadoConfiguracao).Valor, 2);
		}
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[12] as DadoConfiguracao).Valor))
		{
			empty = empty + " - CEP: " + StringUtil.TruncateString((carteira.DadosConfiguracao[12] as DadoConfiguracao).Valor, 9);
		}
		if (!string.IsNullOrEmpty((carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor))
		{
			empty = empty + " / CNPJ: 0" + StringUtil.TruncateString((carteira.DadosConfiguracao[13] as DadoConfiguracao).Valor, 18);
		}
		return empty;
	}

	public override string GetIdentificacaoSacadorAvalista()
	{
		return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Empty + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario, 50), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario, 18)), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario, 30)), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario, 20)), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario, 30)), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario, 2)), " ", StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario, 10));
	}

	public override string GetCodigoUsoBanco()
	{
		return "00018";
	}
}
