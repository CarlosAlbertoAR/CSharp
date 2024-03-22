using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban133;

public interface ITraillerRemessaCnab400Ban133
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
