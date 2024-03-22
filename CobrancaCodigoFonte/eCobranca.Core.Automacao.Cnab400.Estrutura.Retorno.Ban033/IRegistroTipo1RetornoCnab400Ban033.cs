using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban033;

public interface IRegistroTipo1RetornoCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaMovimentoBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaCobrancaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca NossoNumero2 { get; }

	CampoLayoutArquivoCobranca CodigoOriginalRemessa { get; }

	CampoLayoutArquivoCobranca CodigoErroPrimeiraOcorrencia { get; }

	CampoLayoutArquivoCobranca CodigoErroSegundaOcorrencia { get; }

	CampoLayoutArquivoCobranca CodigoErroTerceiraOcorrencia { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca NumeroBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaRecebedora { get; }

	CampoLayoutArquivoCobranca EspecieTitulo { get; }

	CampoLayoutArquivoCobranca ValorTarifaCobrada { get; }

	CampoLayoutArquivoCobranca ValorOutrasDespesas { get; }

	CampoLayoutArquivoCobranca ValorJuros { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorTotalRecebido { get; }

	CampoLayoutArquivoCobranca ValorJurosDeMora { get; }

	CampoLayoutArquivoCobranca ValorOutrosCreditos { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca CodigoAceite { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca IdentificadorComplemento { get; }

	CampoLayoutArquivoCobranca UnidadeValorMoeda { get; }

	CampoLayoutArquivoCobranca ValorTituloOutraUnidade { get; }

	CampoLayoutArquivoCobranca ValorIOFOutraUnidade { get; }

	CampoLayoutArquivoCobranca ValorDebitoCredito { get; }

	CampoLayoutArquivoCobranca TipoOperacao { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca Complemento { get; }

	CampoLayoutArquivoCobranca SiglaEmpresaNoSistema { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca NumeroVersao { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
