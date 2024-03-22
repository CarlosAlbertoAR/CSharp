using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban341;

public interface IRegistroMensagemFrenteRemessaCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoFlash { get; }

	CampoLayoutArquivoCobranca NumeroLinha1 { get; }

	CampoLayoutArquivoCobranca ConteudoLinha1 { get; }

	CampoLayoutArquivoCobranca NumeroLinha2 { get; }

	CampoLayoutArquivoCobranca ConteudoLinha2 { get; }

	CampoLayoutArquivoCobranca NumeroLinha3 { get; }

	CampoLayoutArquivoCobranca ConteudoLinha3 { get; }

	CampoLayoutArquivoCobranca DestinoBoleto { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
