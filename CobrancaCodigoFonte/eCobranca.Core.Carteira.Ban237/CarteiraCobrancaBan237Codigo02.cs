using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban237;

[Serializable]
public class CarteiraCobrancaBan237Codigo02 : CarteiraCobrancaBan237, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "02";

	public CarteiraCobrancaBan237Codigo02(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan237Codigo02(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "02";
	}
}
