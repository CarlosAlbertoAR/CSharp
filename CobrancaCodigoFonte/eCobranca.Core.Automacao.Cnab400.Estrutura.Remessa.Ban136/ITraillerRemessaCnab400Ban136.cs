using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;

public interface ITraillerRemessaCnab400Ban136
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
