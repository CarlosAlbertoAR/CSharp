using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio6DigitosCodigo15 : CarteiraCobrancaBan001Convenio6Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "15";

	public CarteiraCobrancaBan001Convenio6DigitosCodigo15(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio6DigitosCodigo15(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "15";
	}
}
