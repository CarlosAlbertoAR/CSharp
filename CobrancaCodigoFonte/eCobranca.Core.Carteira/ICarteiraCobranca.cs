using System.Collections;

namespace eCobranca.Core.Carteira;

public interface ICarteiraCobranca
{
	string Carteira { get; set; }

	string Contrato { get; set; }

	ArrayList DadosConfiguracao { get; set; }

	void GerarArquivoCarteiraCobranca();
}
