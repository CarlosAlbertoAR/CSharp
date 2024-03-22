using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;

public interface ITraillerRetornoCnab400Ban341
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoRetorno { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca AvisoBancarioCobrancaSimples { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca AvisoBancarioCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDiretaEscritural { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaDiretaEscritural { get; }

	CampoLayoutArquivoCobranca AvisoBancarioCobrancaDiretaEscritural { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRetorno { get; }

	CampoLayoutArquivoCobranca QuantidadeRegistrosTransacao { get; }

	CampoLayoutArquivoCobranca ValorTitulosInformadosArquivo { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
