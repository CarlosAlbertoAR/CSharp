using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban748;

[Serializable]
public class CarteiraCobrancaBan748CodigoA : CarteiraCobrancaBan748, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "1";

	public CarteiraCobrancaBan748CodigoA(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan748CodigoA(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			string value = "1";
			string text = "";
			text = ((!string.IsNullOrEmpty(dc.ModalidadeCobranca)) ? dc.ModalidadeCobranca.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo() : (base.DadosConfiguracao[4] as DadoConfiguracao).Valor.ToEnum<EnumModalidadeCarteiraCobranca>().Codigo());
			string value2 = StringUtil.RemoverMascara(dc.NossoNumero);
			string value3 = StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[0] as DadoConfiguracao).Valor, 1);
			string value4 = StringUtil.ObterValorDeCampoMascarado((base.DadosConfiguracao[0] as DadoConfiguracao).Valor, 2);
			string value5 = StringUtil.RemoverMascara((base.DadosConfiguracao[2] as DadoConfiguracao).Valor);
			string value6 = "1";
			string value7 = "0";
			stringBuilder.Append(value);
			stringBuilder.Append(text);
			stringBuilder.Append(value2);
			stringBuilder.Append(value3);
			stringBuilder.Append(value4);
			stringBuilder.Append(value5);
			stringBuilder.Append(value6);
			stringBuilder.Append(value7);
			string dVModulo11Ban = DVGenerator.GetDVModulo11Ban748(stringBuilder.ToString());
			stringBuilder.Append(dVModulo11Ban);
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

	public override string GetCodigoCarteiraImpressao()
	{
		return "1";
	}
}
