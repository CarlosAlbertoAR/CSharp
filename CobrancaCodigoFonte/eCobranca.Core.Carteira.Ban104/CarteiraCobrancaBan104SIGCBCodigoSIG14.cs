using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban104;

[Serializable]
public class CarteiraCobrancaBan104SIGCBCodigoSIG14 : CarteiraCobrancaBan104SIGCB, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "SIG14";

	public CarteiraCobrancaBan104SIGCBCodigoSIG14(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan104SIGCBCodigoSIG14(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "SIG14";
	}
}
