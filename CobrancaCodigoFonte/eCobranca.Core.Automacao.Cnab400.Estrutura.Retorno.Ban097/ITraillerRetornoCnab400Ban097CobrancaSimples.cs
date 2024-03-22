using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban097;

public interface ITraillerRetornoCnab400Ban097CobrancaSimples
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
