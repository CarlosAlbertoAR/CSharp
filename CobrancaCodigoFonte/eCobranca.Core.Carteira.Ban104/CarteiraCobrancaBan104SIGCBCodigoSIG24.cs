using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban104;

[Serializable]
public class CarteiraCobrancaBan104SIGCBCodigoSIG24 : CarteiraCobrancaBan104SIGCB, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "SIG24";

	public CarteiraCobrancaBan104SIGCBCodigoSIG24(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan104SIGCBCodigoSIG24(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "SIG24";
	}
}
