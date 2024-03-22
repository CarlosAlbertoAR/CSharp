using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban004;

public interface ITraillerRemessaCnab400Ban004
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca Filler { get; }

	CampoLayoutArquivoCobranca SequencialRegistro { get; }
}
