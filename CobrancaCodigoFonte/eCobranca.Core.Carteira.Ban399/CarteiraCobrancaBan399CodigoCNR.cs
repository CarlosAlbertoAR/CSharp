using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban399;

[Serializable]
public class CarteiraCobrancaBan399CodigoCNR : CarteiraCobrancaBan399, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "CNR";

	public CarteiraCobrancaBan399CodigoCNR(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
		base.ConfiguracaoArquivoRemessa.LayoutsArquivoRemessa.Clear();
	}

	public CarteiraCobrancaBan399CodigoCNR(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "CNR";
	}
}
