using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban136;

public interface ITraillerRetornoCnab400Ban136
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
