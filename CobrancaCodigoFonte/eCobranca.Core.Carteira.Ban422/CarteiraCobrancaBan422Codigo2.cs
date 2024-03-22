using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban422;

[Serializable]
public class CarteiraCobrancaBan422Codigo2 : CarteiraCobrancaBan422, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "2";

	public CarteiraCobrancaBan422Codigo2(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan422Codigo2(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "2";
	}
}
