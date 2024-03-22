namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan037 : ProvedorDadosModeloBoleto
{
	public override string GetLocalPagamento()
	{
		return "PAGAR PREFERENCIALMENTE EM AGÊNCIA DO BANPARÁ";
	}

	public override string GetAgenciaCodigoCedente()
	{
		if (((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor == null || ((DadoConfiguracao)carteira.DadosConfiguracao[1]).Valor == null || ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor == null)
		{
			return "";
		}
		return ((DadoConfiguracao)carteira.DadosConfiguracao[0]).Valor + "/" + ((DadoConfiguracao)carteira.DadosConfiguracao[1]).Valor + "/" + ((DadoConfiguracao)carteira.DadosConfiguracao[2]).Valor;
	}
}
