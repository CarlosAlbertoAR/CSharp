using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban399;

[Serializable]
public class CarteiraCobrancaBan399CodigoCSB : CarteiraCobrancaBan399, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "CBS";

	public CarteiraCobrancaBan399CodigoCSB(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan399CodigoCSB(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "CBS";
	}
}
