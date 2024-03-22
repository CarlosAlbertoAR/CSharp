using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Util;

namespace eCobranca.Core.Carteira.Ban085;

[Serializable]
public class CarteiraCobrancaBan085Codigo01 : CarteiraCobrancaBan085, ISerializable
{
	private const string CODIGO_CARTEIRA_IMPRESSAO = "01";

	public CarteiraCobrancaBan085Codigo01(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan085Codigo01(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "01";
	}

	protected override string GetCampoLivre(DocumentoCobranca dc)
	{
		string result = "";
		try
		{
			Logger.Debug("Criando campo livre para o documento de cobrança...");
			result = ((DadoConfiguracao)base.DadosConfiguracao[2]).Valor + StringUtil.RemoverMascara(((DadoConfiguracao)base.DadosConfiguracao[1]).Valor) + dc.NossoNumeroSemMascara.Substring(8, 9) + "01";
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
