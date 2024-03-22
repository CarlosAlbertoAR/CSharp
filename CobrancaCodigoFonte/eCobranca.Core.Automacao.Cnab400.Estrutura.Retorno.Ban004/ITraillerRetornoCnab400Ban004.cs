using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban004;

public interface ITraillerRetornoCnab400Ban004
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca NumeroBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca NumeroAvisoLancamentos { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
