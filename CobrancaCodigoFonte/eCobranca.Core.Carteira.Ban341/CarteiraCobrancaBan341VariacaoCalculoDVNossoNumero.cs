using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public abstract class CarteiraCobrancaBan341VariacaoCalculoDVNossoNumero : CarteiraCobrancaBan341, ISerializable
{
	public CarteiraCobrancaBan341VariacaoCalculoDVNossoNumero(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341VariacaoCalculoDVNossoNumero(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override string CalcularDVNossoNumero(string nossoNumeroSemDV)
	{
		string text = "";
		try
		{
			return DVGenerator.GetDVModulo10(base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + nossoNumeroSemDV);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaCalculadoDVNossoNumeroDocumentoCobranca(nossoNumeroSemDV, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return Convert.ToString(text);
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + DVGenerator.GetDVModulo10(base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1)) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1) + DVGenerator.GetDVModulo10(StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[0]).Valor, 1) + StringUtil.ObterValorDeCampoMascarado(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor, 1)) + StringUtil.ZerosLeft("", 3);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCampoLivre(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}
}
