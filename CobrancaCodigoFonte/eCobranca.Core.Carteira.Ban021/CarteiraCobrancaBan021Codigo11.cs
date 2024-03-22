using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban021;

[Serializable]
public class CarteiraCobrancaBan021Codigo11 : CarteiraCobrancaBan021
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "11";

	public CarteiraCobrancaBan021Codigo11(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan021Codigo11(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "11";
	}
}
