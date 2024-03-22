using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban422;

public interface IRegistroTransacaoTipo1RemessaCnab400Ban422
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca UsoExclusivoBeneficiario { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoIof { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Instrucao3 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominalTitulo { get; }

	CampoLayoutArquivoCobranca BancoEncarregadoCobranca { get; }

	CampoLayoutArquivoCobranca AgenciaEncarregadaCobranca { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca CodigoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Instrucao1 { get; }

	CampoLayoutArquivoCobranca Instrucao2 { get; }

	CampoLayoutArquivoCobranca JurosDiario { get; }

	CampoLayoutArquivoCobranca DataLimiteDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIof { get; }

	CampoLayoutArquivoCobranca ValorAbatimentoOuMulta { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UfPagador { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca BancoEmiteBoleto { get; }

	CampoLayoutArquivoCobranca NumeroSequencialArquivoRemessa { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroArquivo { get; }
}
