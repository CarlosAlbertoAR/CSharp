using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban033;

[Serializable]
public abstract class CarteiraCobrancaBan033Antiga : CarteiraCobrancaBan033, ISerializable
{
	public CarteiraCobrancaBan033Antiga(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan033Antiga(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override void CarregarDadosConfiguracao()
	{
		base.DadosConfiguracao = new ArrayList();
		DadoConfiguracao value = new DadoConfiguracao("CodigoAgencia", "Agência do beneficiário", "Código da agência", "000");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoCedente", "Código do cedente", "Código do cedente", "00 00000 0");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("NomeAgencia", "Nome da agência", "Nome da agência do beneficiário", "AAAAAAAAAAAAAAAAAAAA");
		base.DadosConfiguracao.Add(value);
		value = new DadoConfiguracao("CodigoTransmissao", "Código de transmissão", "Código de transmissão", "000000000000000");
		base.DadosConfiguracao.Add(value);
	}

	protected override string GetLinhaDigitavel(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando linha digitável para o documento de cobrança...");
			string text = StringUtil.RemoverMascara(dc.NossoNumero);
			if (text.Length == 8)
			{
				text = "00000" + text;
			}
			string text2 = EnumCodigoBanco.BANCO_SANTANDER.Codigo() + "99" + StringUtil.RemoverMascara((base.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(0, 4);
			string text3 = text2 + DVGenerator.GetDVModulo10(text2);
			text3 = text3.Insert(5, ".");
			string text4 = StringUtil.RemoverMascara((base.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(4, 3) + StringUtil.RemoverMascara(text).Substring(0, 7);
			string text5 = text4 + DVGenerator.GetDVModulo10(text4);
			text5 = text5.Insert(5, ".");
			string text6 = StringUtil.RemoverMascara(text).Substring(7, 6) + "0" + base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			string text7 = text6 + DVGenerator.GetDVModulo10(text6);
			text7 = text7.Insert(5, ".");
			string text8 = dc.CodigoBarras.Substring(4, 1);
			string text9 = GerarFatorVencimento(dc) + StringUtil.FormatValueToSizedString(dc.ValorDocumento, 10);
			result = text3 + " " + text5 + " " + text7 + " " + text8 + " " + text9;
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

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			string value = "9";
			string value2 = StringUtil.RemoverMascara((base.DadosConfiguracao[1] as DadoConfiguracao).Valor).Substring(0, 7);
			string text = StringUtil.RemoverMascara(dc.NossoNumero);
			if (text.Length == 8)
			{
				text = "00000" + text;
			}
			string value3 = "0";
			string value4 = base.ConfiguracaoCarteiraCobranca.TipoCarteiraCobranca.ToEnum<EnumTipoCarteiraCobranca>().Codigo();
			stringBuilder.Append(value);
			stringBuilder.Append(value2);
			stringBuilder.Append(text);
			stringBuilder.Append(value3);
			stringBuilder.Append(value4);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.CarteiraCobranca.FalhaGerandoCampoLivre(dc, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
		return stringBuilder.ToString();
	}
}
