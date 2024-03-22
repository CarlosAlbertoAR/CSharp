using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban021;

[Serializable]
public class CarteiraCobrancaBan021Codigo13 : CarteiraCobrancaBan021
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "13";

	public CarteiraCobrancaBan021Codigo13(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan021Codigo13(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "13";
	}
}
