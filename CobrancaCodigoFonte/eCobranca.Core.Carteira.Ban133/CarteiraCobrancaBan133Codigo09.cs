using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban133;

[Serializable]
public class CarteiraCobrancaBan133Codigo09 : CarteiraCobrancaBan133, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "09";

	public CarteiraCobrancaBan133Codigo09(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan133Codigo09(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "09";
	}
}
