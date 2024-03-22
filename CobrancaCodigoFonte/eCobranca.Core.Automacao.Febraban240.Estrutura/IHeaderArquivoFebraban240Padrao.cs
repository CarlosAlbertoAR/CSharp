using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

internal interface IHeaderArquivoFebraban240Padrao
{
	CampoLayoutArquivoCobranca CodigoBancoCompensacao { get; }

	CampoLayoutArquivoCobranca LoteServico { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban1 { get; }

	CampoLayoutArquivoCobranca TipoInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoConvenioBanco { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DVAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DVContaCorrente { get; }

	CampoLayoutArquivoCobranca DVAgenciaContaCorrente { get; }

	CampoLayoutArquivoCobranca NomeEmpresa { get; }

	CampoLayoutArquivoCobranca NomeBanco { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }

	CampoLayoutArquivoCobranca CodigoRemessaRetorno { get; }

	CampoLayoutArquivoCobranca DataGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca HoraGeracaoArquivo { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivo { get; }

	CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo { get; }

	CampoLayoutArquivoCobranca DensidadeGravacaoArquivo { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco { get; }

	CampoLayoutArquivoCobranca UsoReservadoEmpresa { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban3 { get; }
}
