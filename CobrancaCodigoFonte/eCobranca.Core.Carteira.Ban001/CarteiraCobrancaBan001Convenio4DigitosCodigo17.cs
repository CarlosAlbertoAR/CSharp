using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio4DigitosCodigo17 : CarteiraCobrancaBan001Convenio4Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "17";

	public CarteiraCobrancaBan001Convenio4DigitosCodigo17(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio4DigitosCodigo17(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "17";
	}
}
