using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban136;

public interface IRegistroTipo5RemesaCnab400Ban136
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca EderecoEmail { get; }

	CampoLayoutArquivoCobranca TipoInscricao { get; }

	CampoLayoutArquivoCobranca NumeroInscricao { get; }

	CampoLayoutArquivoCobranca Logradouro { get; }

	CampoLayoutArquivoCobranca Bairro { get; }

	CampoLayoutArquivoCobranca Cep { get; }

	CampoLayoutArquivoCobranca Cidade { get; }

	CampoLayoutArquivoCobranca Estado { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
