using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalheRFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoDesconto2 { get; }

	CampoLayoutArquivoCobranca DataDesconto2 { get; }

	CampoLayoutArquivoCobranca Desconto2 { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca Multa { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco3 { get; }

	CampoLayoutArquivoCobranca Mensagem3 { get; }

	CampoLayoutArquivoCobranca Mensagem4 { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco4 { get; }
}
