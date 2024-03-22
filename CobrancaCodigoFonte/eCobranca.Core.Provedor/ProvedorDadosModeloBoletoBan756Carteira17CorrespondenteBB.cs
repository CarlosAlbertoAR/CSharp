using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan756Carteira17CorrespondenteBB : ProvedorDadosModeloBoletoBan756
{
	public override string GetNomeCedente()
	{
		return "VIDE CAMPO SACADOR/AVALISTA ABAIXO";
	}

	public override string GetIdentificacaoCedente()
	{
		return string.Empty + GetNomeCedente();
	}

	public override string GetIdentificacaoSacadorAvalista()
	{
		string text = string.Empty;
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NomeBeneficiario, 50);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.NumeroInscricaoBeneficiario, 18);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.EnderecoBeneficiario, 30);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.BairroBeneficiario, 20);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CidadeBeneficiario, 30);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.UfBeneficiario, 2);
		}
		if (!string.IsNullOrEmpty(carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario))
		{
			text = text + " " + StringUtil.TruncateString(carteira.ConfiguracaoCarteiraCobranca.CepBeneficiario, 10);
		}
		return text;
	}
}
