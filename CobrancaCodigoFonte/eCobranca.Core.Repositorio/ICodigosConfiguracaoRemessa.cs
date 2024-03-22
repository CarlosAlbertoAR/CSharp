using System.Collections;

namespace eCobranca.Core.Repositorio;

public interface ICodigosConfiguracaoRemessa
{
	ArrayList LayoutsArquivoRemessa { get; }

	ArrayList CodigosMovimentoRemessaCnab400 { get; }

	ArrayList CodigosMovimentoRemessaFebraban240 { get; }
}
