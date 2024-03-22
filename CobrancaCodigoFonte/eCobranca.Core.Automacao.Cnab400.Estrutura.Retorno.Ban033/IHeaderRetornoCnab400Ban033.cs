using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban033;

public interface IHeaderRetornoCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoRetorno { get; }

	CampoLayoutArquivoCobranca LiteralTransmissao { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca LiteralServico { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaMovimentoBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaCobrancaBeneficiario { get; }

	CampoLayoutArquivoCobranca NomeBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca DataMovimento { get; }

	CampoLayoutArquivoCobranca DensidadeGravacao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca SiglaEmpresaNoSistema { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroVersao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
