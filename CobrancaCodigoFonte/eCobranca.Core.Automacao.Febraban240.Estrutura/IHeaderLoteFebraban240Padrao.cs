using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface IHeaderLoteFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca NumeroVersaoLayoutLote { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoConvenioBanco { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DVAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca DVAgenciaContaCorrente { get; }

	CampoLayoutArquivoCobranca NomeEmpresa { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca NumeroRemessaRetorno { get; }

	CampoLayoutArquivoCobranca DataGravacaoRemessaRetorno { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban3 { get; }
}
