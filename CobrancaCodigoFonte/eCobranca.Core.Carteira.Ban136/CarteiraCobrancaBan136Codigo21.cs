using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban136;

[Serializable]
public class CarteiraCobrancaBan136Codigo21 : CarteiraCobrancaBan136, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "21";

	public CarteiraCobrancaBan136Codigo21(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan136Codigo21(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "21";
	}
}
