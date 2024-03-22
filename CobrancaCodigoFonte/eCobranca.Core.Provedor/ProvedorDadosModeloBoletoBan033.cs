namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan033 : ProvedorDadosModeloBoleto
{
	public override string GetAgenciaCodigoCedente()
	{
		if (((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor == null || ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor == null)
		{
			return "";
		}
		return ((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor + "/" + ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor;
	}
}
