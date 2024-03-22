using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban021;

[Serializable]
public class CarteiraCobrancaBan021Codigo01 : CarteiraCobrancaBan021
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "01";

	public CarteiraCobrancaBan021Codigo01(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan021Codigo01(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "01";
	}
}
