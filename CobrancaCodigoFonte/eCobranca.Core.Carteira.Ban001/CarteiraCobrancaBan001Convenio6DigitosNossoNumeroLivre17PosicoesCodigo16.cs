using System;
using System.Runtime.Serialization;
using eCobranca.Core.Configuracoes;

namespace eCobranca.Core.Carteira.Ban001;

[Serializable]
public class CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17PosicoesCodigo16 : CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17Posicoes, ISerializable
{
	public const string CODIGO_CARTEIRA_IMPRESSAO = "16";

	public CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17PosicoesCodigo16(ConfiguracaoCarteiraCobranca configuracaoCarteiraCobranca)
		: base(configuracaoCarteiraCobranca)
	{
	}

	public CarteiraCobrancaBan001Convenio6DigitosNossoNumeroLivre17PosicoesCodigo16(SerializationInfo serobj, StreamingContext scontext)
		: base(serobj, scontext)
	{
	}

	public override string GetCodigoCarteiraImpressao()
	{
		return "16";
	}
}
