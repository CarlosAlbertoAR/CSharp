using eCobranca.Enumerator;

namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan133 : ProvedorDadosModeloBoleto
{
	public override string GetNossoNumero()
	{
		if (dc != null)
		{
			if (!string.IsNullOrEmpty(dc.NossoNumero))
			{
				return carteira.GetCodigoCarteiraImpressao() + "/" + dc.NossoNumero;
			}
			return "";
		}
		return "";
	}

	public override string GetMoeda()
	{
		return EnumCodigoMoeda.REAL.ToString();
	}
}
