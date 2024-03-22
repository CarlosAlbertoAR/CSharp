using eCobranca.Core.Carteira.Ban756;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan756 : ProvedorDadosModeloBoleto
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
		return StringUtil.TruncateString($"Pagável em qualquer banco até o vencimento.".ToUpper(), 90);
	}

	public override string GetLogoTipoBanco()
	{
		if (carteira is CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos)
		{
			return ImageUtil.GetInstance().ExtrairImagemDosRecursos(namespaceImagens, EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + ".jpg", diretorioTemporarioImagens);
		}
		return base.GetLogoTipoBanco();
	}

	public override string GetLogotipoCedente()
	{
		if (carteira is CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos)
		{
			if (!carteira.ConfiguracaoBoleto.ExibeLogotipoBeneficiario)
			{
				return ImageUtil.GetInstance().ExtrairImagemDosRecursos("eCobranca/Core/Modelo/Imagens/", EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + ".jpg", diretorioTemporarioImagens);
			}
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.LogotipoBeneficiario))
			{
				return carteira.ConfiguracaoBoleto.LogotipoBeneficiario;
			}
			return ImageUtil.GetInstance().ExtrairImagemDosRecursos("eCobranca/Core/Modelo/Imagens/", EnumCodigoBanco.BANCO_DO_BRASIL.Codigo() + ".jpg", diretorioTemporarioImagens);
		}
		return base.GetLogotipoCedente();
	}

	public override string GetNumeroBanco()
	{
		if (carteira is CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos)
		{
			if (!string.IsNullOrEmpty(carteira.ConfiguracaoBoleto.CodigoBancoImpressao))
			{
				return "|001-9|";
			}
			return "";
		}
		return base.GetNumeroBanco();
	}

	public override string GetNumeroBancoRecibo()
	{
		if (carteira is CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos)
		{
			return "|001-9|";
		}
		return base.GetNumeroBancoRecibo();
	}

	public override string GetAgenciaCodigoCedente()
	{
		if (carteira is CarteiraCobrancaBan756CorrespondenteBancoBrasilCarteira17Convenio7Digitos)
		{
			return (carteira.DadosConfiguracao[2] as DadoConfiguracao).Valor + "/" + (carteira.DadosConfiguracao[4] as DadoConfiguracao).Valor;
		}
		return (carteira.DadosConfiguracao[0] as DadoConfiguracao).Valor + "/" + (carteira.DadosConfiguracao[2] as DadoConfiguracao).Valor;
	}
}
