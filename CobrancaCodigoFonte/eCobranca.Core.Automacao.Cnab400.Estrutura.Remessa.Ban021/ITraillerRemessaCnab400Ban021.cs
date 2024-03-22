using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban021;

public interface ITraillerRemessaCnab400Ban021
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
