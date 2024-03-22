using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban756;

public interface ITraillerRemessaCnab400Ban756
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca Mensagem3 { get; }

	CampoLayoutArquivoCobranca Mensagem4 { get; }

	CampoLayoutArquivoCobranca Mensagem5 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
