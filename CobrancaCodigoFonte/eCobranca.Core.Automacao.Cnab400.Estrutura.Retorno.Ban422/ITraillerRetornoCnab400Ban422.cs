using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban422;

public interface ITraillerRetornoCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoArquivoRetorno { get; }

	CampoLayoutArquivoCobranca CodigoIdentificacaoServico { get; }

	CampoLayoutArquivoCobranca CodigoIdentificacaoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaSimples { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
