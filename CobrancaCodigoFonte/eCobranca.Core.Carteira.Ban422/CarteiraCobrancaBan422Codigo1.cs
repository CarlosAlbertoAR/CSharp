using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban422;

[Serializable]
public class CarteiraCobrancaBan422Codigo1 : CarteiraCobrancaBan422, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "1";

	public CarteiraCobrancaBan422Codigo1(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan422Codigo1(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "1";
	}
}
