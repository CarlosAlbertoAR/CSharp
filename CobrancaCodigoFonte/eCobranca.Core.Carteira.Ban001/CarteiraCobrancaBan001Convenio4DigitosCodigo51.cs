using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio4DigitosCodigo51 : CarteiraCobrancaBan001Convenio4Digitos, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "51";

	public CarteiraCobrancaBan001Convenio4DigitosCodigo51(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio4DigitosCodigo51(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "51";
	}
}
