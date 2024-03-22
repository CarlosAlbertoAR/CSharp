using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio7DigitosCodigo12 : CarteiraCobrancaBan001Convenio7Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "12";

	public CarteiraCobrancaBan001Convenio7DigitosCodigo12(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio7DigitosCodigo12(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "12";
	}
}
