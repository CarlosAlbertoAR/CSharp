using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban001;

public interface ITraillerRetornoCnab400Ban001
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaSimples { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaSimples { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaVinculada { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaDescontada { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVendor { get; }

	CampoLayoutArquivoCobranca ValorTotalCobrancaVendor { get; }

	CampoLayoutArquivoCobranca NumeroAvisoCobrancaVendor { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
