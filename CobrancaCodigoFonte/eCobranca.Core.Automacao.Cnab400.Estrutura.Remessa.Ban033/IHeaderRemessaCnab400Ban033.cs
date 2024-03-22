using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;

public interface IHeaderRemessaCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoRemessa { get; }

	CampoLayoutArquivoCobranca LiteralTransmissao { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca LiteralServico { get; }

	CampoLayoutArquivoCobranca CodigoTransmissao { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataGravacao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca Mensagem3 { get; }

	CampoLayoutArquivoCobranca Mensagem4 { get; }

	CampoLayoutArquivoCobranca Mensagem5 { get; }

	CampoLayoutArquivoCobranca Mensagem6 { get; }

	CampoLayoutArquivoCobranca NumeroVersao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
