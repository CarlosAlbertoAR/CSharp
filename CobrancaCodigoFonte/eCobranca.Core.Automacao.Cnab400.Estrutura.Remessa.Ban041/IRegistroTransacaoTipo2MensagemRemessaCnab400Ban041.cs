using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban041;

public interface IRegistroTransacaoTipo2MensagemRemessaCnab400Ban041
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca ControleCanalMensagem1 { get; }

	CampoLayoutArquivoCobranca ConteudoMensagem1 { get; }

	CampoLayoutArquivoCobranca ControleCanalMensagem2 { get; }

	CampoLayoutArquivoCobranca ConteudoMensagem2 { get; }

	CampoLayoutArquivoCobranca ControleCanalMensagem3 { get; }

	CampoLayoutArquivoCobranca ConteudoMensagem3 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
