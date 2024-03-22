using System.Collections;

namespace eCobranca.Core.Repositorio;

public interface ICodigosConfiguracaoBoleto
{
	ArrayList FormatosBoleto { get; }

	ArrayList TiposPropaganda { get; }

	ArrayList TiposNomenclaturaBoleto { get; }
}
