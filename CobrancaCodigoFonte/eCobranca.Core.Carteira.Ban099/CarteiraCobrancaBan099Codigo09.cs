using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban099;

[Serializable]
public class CarteiraCobrancaBan099Codigo09 : CarteiraCobrancaBan099, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "09";

	public CarteiraCobrancaBan099Codigo09(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan099Codigo09(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "09";
	}
}
