using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban084;

[Serializable]
public class CarteiraCobrancaBan084Codigo09 : CarteiraCobrancaBan084, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "009";

	public CarteiraCobrancaBan084Codigo09(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan084Codigo09(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "009";
	}
}
