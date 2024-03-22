using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban033;

public interface IRegistroTipo1RemessaCnab400Ban033
{
	CampoLayoutArquivoCobranca CodigoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca AgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaMovimentoBeneficiario { get; }

	CampoLayoutArquivoCobranca ContaCobrancaBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroControleParticipante { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca DataSegundoDesconto { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca PercentualMulta { get; }

	CampoLayoutArquivoCobranca UnidadeValorMoeda { get; }

	CampoLayoutArquivoCobranca ValorTituloEmOutraUnidade { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca DataMulta { get; }

	CampoLayoutArquivoCobranca CodigoCarteira { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca NumeroBancoCobrador { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca TipoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissaoTitulo { get; }

	CampoLayoutArquivoCobranca PrimeiraInstrucaoCobranca { get; }

	CampoLayoutArquivoCobranca SegundaInstrucaoCobranca { get; }

	CampoLayoutArquivoCobranca ValorJurosAoDia { get; }

	CampoLayoutArquivoCobranca DataLimiteDesconto { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca PrefixoCEPPagador { get; }

	CampoLayoutArquivoCobranca SufixoCEPPagador { get; }

	CampoLayoutArquivoCobranca MunicipioPagador { get; }

	CampoLayoutArquivoCobranca UFPagador { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca IdentificadorComplemento { get; }

	CampoLayoutArquivoCobranca Complemento { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca NumeroDiasProtesto { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
