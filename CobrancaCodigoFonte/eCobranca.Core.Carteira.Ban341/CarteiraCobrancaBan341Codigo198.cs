using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public class CarteiraCobrancaBan341Codigo198 : CarteiraCobrancaBan341VariacaoNossoNumero15Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "198";

	public CarteiraCobrancaBan341Codigo198(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341Codigo198(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "198";
	}
}
