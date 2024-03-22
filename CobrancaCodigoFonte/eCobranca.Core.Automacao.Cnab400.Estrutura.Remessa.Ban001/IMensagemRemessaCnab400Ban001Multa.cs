using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban001;

public interface IMensagemRemessaCnab400Ban001Multa
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca ValorPercentualMulta { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
