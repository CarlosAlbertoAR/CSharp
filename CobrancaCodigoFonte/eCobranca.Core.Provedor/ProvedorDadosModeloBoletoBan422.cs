namespace eCobranca.Core.Provedor;

public class ProvedorDadosModeloBoletoBan422 : ProvedorDadosModeloBoleto
{
	public override string GetLocalPagamento()
	{
		return "Pagável em qualquer Banco do Sistema de Compensação";
	}
}
