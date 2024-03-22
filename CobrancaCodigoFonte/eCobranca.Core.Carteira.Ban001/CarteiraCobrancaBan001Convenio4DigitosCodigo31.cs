using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio4DigitosCodigo31 : CarteiraCobrancaBan001Convenio4Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "31";

	public CarteiraCobrancaBan001Convenio4DigitosCodigo31(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio4DigitosCodigo31(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "31";
	}
}
