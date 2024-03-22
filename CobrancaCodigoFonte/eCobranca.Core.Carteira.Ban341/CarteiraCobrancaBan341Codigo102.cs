using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public class CarteiraCobrancaBan341Codigo102 : CarteiraCobrancaBan341, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "102";

	public CarteiraCobrancaBan341Codigo102(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341Codigo102(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "102";
	}
}
