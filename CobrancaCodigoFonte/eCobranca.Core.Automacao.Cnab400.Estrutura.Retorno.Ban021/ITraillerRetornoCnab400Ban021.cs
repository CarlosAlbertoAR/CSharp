using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban021;

public interface ITraillerRetornoCnab400Ban021
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca IdentificacaoRetorno { get; }

	CampoLayoutArquivoCobranca IdentificacaoTipoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaSimples { get; }

	CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaSimples { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculaa { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
