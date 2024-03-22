using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public class CarteiraCobrancaBan341Codigo210 : CarteiraCobrancaBan341, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "210";

	public CarteiraCobrancaBan341Codigo210(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341Codigo210(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "210";
	}
}
