using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban033;

public interface ITraillerRetornoCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca CodigoRetorno { get; }

	CampoLayoutArquivoCobranca CodigoServico { get; }

	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaSimples { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca ValorTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca NumeroVersao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
