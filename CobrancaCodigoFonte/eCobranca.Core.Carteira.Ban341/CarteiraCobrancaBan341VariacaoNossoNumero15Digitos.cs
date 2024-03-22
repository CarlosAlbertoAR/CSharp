using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public abstract class CarteiraCobrancaBan341VariacaoNossoNumero15Digitos : CarteiraCobrancaBan341, ISerializable
{
	public CarteiraCobrancaBan341VariacaoNossoNumero15Digitos(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341VariacaoNossoNumero15Digitos(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.CarregarDadosConfiguracao();
		DadoConfiguracao value = new DadoConfiguracao("CodigoCedente", "Código do cliente no banco", "Código do cedente", "00000");
		base.DadosConfiguracao.Add(value);
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + StringUtil.ZerosLeft(dc.NumeroDocumento, 7) + ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor + DVGenerator.GetDVModulo10(base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + dc.NumeroDocumento.Substring(0, 7) + ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor);
			StringUtil.ZerosLeft("", 1);
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

	protected override string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = EnumCodigoBanco.BANCO_ITAU.Codigo() + "9" + configuracaoCarteiraCobranca.CodigoCarteiraCobranca + dc.NossoNumero.Substring(0, 2);
			string text2 = text + DVGenerator.GetDVModulo10(text);
			text2 = text2.Insert(5, ".");
			string text3 = dc.NossoNumero.Substring(2, 6) + StringUtil.ZerosLeft(dc.NumeroDocumento, 7).Substring(0, 4);
			string text4 = text3 + DVGenerator.GetDVModulo10(text3);
			text4 = text4.Insert(5, ".");
			string text5 = StringUtil.ZerosLeft(dc.NumeroDocumento, 7).Substring(4, 3) + ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor + DVGenerator.GetDVModulo10(base.ConfiguracaoCarteiraCobranca.CodigoCarteiraCobranca + StringUtil.ObterValorDeCampoMascarado(dc.NossoNumero, 1) + StringUtil.ZerosLeft(dc.NumeroDocumento, 7) + ((DadoConfiguracao)base.DadosConfiguracao[6]).Valor) + StringUtil.ZerosLeft("", 1);
			string text6 = text5 + DVGenerator.GetDVModulo10(text5);
			text6 = text6.Insert(5, ".");
			string text7 = dc.CodigoBarras.Substring(4, 1);
			string text8 = GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10);
			result = text2 + " " + text4 + " " + text6 + " " + text7 + " " + text8;
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoLinhaDigitavel(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GetNossoNumeroSemDV(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando nosso número para o documento de cobrança...");
			string valor = ((DadoConfiguracao)base.DadosConfiguracao[5]).Valor;
			string mascara = ((DadoConfiguracao)base.DadosConfiguracao[5]).Mascara;
			string valor2 = ((DadoConfiguracao)base.DadosConfiguracao[3]).Valor;
			string valor3 = ((DadoConfiguracao)base.DadosConfiguracao[4]).Valor;
			valor = ((!string.IsNullOrEmpty(dc.NossoNumero)) ? StringUtil.IncrementString(dc.NossoNumero, valor2, valor3, mascara) : StringUtil.IncrementString(valor, valor2, valor3, mascara));
			if (string.IsNullOrEmpty(valor))
			{
				throw ExcecaoECobranca.CarteiraCobranca.LimiteSequencialNossoNumeroAtingido(valor3);
			}
			((DadoConfiguracao)base.DadosConfiguracao[5]).Valor = valor;
			result = valor + StringUtil.ZerosLeft(dc.NumeroDocumento, 7);
			return result;
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
				return result;
			}
			Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoNossoNumeroSemDV(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			return result;
		}
	}

	protected override string GetDVNossoNumero(string nossoNumero)
	{
		return "";
	}
}
