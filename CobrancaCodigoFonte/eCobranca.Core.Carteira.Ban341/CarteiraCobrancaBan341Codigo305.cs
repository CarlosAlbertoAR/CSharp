using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban341;

[Serializable]
public class CarteiraCobrancaBan341Codigo305 : CarteiraCobrancaBan341, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "305";

	public CarteiraCobrancaBan341Codigo305(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan341Codigo305(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "305";
	}
}
