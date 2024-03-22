using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban748;

public interface IRegistroTipo1RemessaCnab400Ban748
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoCobranca { get; }

	CampoLayoutArquivoCobranca TipoCarteira { get; }

	CampoLayoutArquivoCobranca TipoImpressao { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca TipoMoeda { get; }

	CampoLayoutArquivoCobranca TipoDesconto { get; }

	CampoLayoutArquivoCobranca TipoJuros { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca DataInstrucao { get; }

	CampoLayoutArquivoCobranca CampoAlterado { get; }

	CampoLayoutArquivoCobranca PostagemTitulo { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca TipoEmissaoBoleto { get; }

	CampoLayoutArquivoCobranca NumeroParcelaCarne { get; }

	CampoLayoutArquivoCobranca NumeroTotalParcelasCarne { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca ValorDescontoPorDiaAntecipacao { get; }

	CampoLayoutArquivoCobranca PercentualMulta { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca Instrucao { get; }

	CampoLayoutArquivoCobranca SeuNumero { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca TipoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca InstrucaoProtestoAutomatico { get; }

	CampoLayoutArquivoCobranca NumeroDiasProtestoAutomatico { get; }

	CampoLayoutArquivoCobranca ValorJurosAoDia { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca ValorPercentualDesconto { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca CodigoPagadorNaCooperativa { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca CodigoPagadorNoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
