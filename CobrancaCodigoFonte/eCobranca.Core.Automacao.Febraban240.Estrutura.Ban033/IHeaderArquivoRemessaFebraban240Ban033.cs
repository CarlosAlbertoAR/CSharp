using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface IHeaderArquivoRemessaFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoTransmissao { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }

	CampoLayoutArquivoCobranca NomeEmpresa { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco3 { get; }

	CampoLayoutArquivoCobranca CodigoRemessa { get; }

	CampoLayoutArquivoCobranca DataGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco4 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivo { get; }

	CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco5 { get; }
}
