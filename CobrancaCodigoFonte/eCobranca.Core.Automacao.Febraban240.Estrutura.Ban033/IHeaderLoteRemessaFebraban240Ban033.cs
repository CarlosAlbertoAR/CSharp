using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface IHeaderLoteRemessaFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca TipoServico { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca NumeroVersaoLayoutLote { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco3 { get; }

	CampoLayoutArquivoCobranca CodigoTransmissao { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco4 { get; }

	CampoLayoutArquivoCobranca NomeCedente { get; }

	CampoLayoutArquivoCobranca Mensagem1 { get; }

	CampoLayoutArquivoCobranca Mensagem2 { get; }

	CampoLayoutArquivoCobranca NumeroRemessaRetorno { get; }

	CampoLayoutArquivoCobranca DataGravacaoRemessaRetorno { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco5 { get; }
}
