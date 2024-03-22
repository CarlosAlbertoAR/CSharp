using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban104;

[Serializable]
public class CarteiraCobrancaBan104SIGCBCodigoSIG11 : CarteiraCobrancaBan104SIGCB, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "SIG11";

	public CarteiraCobrancaBan104SIGCBCodigoSIG11(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan104SIGCBCodigoSIG11(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "SIG11";
	}
}
