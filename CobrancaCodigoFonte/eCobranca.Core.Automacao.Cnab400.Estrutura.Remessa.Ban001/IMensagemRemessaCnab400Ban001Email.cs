using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;

public interface IMensagemRemessaCnab400Ban001Email
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca EndcerecoEmailSacado { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
