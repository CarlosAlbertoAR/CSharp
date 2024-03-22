using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public interface IDetalheOpcionalMultaRemessaCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca Multa { get; }

	CampoLayoutArquivoCobranca Brancos { get; }

	CampoLayoutArquivoCobranca NumeroSequencial { get; }
}
