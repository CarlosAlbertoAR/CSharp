using System.Collections;

namespace eCobranca.Core.Repositorio;

public interface ICodigosConfiguracaoImpressao
{
	ArrayList ModosImpressao { get; }

	ArrayList FormatosSaida { get; }

	ArrayList ModosSaida { get; }
}
