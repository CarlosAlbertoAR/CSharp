using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheRFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoDesconto2 { get; }

	CampoLayoutArquivoCobranca DataDesconto2 { get; }

	CampoLayoutArquivoCobranca Desconto2 { get; }

	CampoLayoutArquivoCobranca CodigoDesconto3 { get; }

	CampoLayoutArquivoCobranca DataDesconto3 { get; }

	CampoLayoutArquivoCobranca Desconto3 { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca Multa { get; }

	CampoLayoutArquivoCobranca InformacaoAoSacado { get; }

	CampoLayoutArquivoCobranca Mensagem3 { get; }

	CampoLayoutArquivoCobranca Mensagem4 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }

	CampoLayoutArquivoCobranca CodigoOcorrenciaSacado { get; }

	CampoLayoutArquivoCobranca CodigoBancoParaDebito { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaParaDebito { get; }

	CampoLayoutArquivoCobranca DvAgenciaParaDebito { get; }

	CampoLayoutArquivoCobranca ContaCorrenteParaDebito { get; }

	CampoLayoutArquivoCobranca DvContaCorrenteParaDebito { get; }

	CampoLayoutArquivoCobranca DvAgenciaContaCorrenteParaDebito { get; }

	CampoLayoutArquivoCobranca AvisoParaDebitoAutomatico { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban3 { get; }
}
