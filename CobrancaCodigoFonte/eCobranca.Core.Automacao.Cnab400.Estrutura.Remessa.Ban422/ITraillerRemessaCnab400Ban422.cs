using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;

public interface ITraillerRemessaCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca QuantidadeTitulos { get; }

	CampoLayoutArquivoCobranca ValorTotalTitulos { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRemessa { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
