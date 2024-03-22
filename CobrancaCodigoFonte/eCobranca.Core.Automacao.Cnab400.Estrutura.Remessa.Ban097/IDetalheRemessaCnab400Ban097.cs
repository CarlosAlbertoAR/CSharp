using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Remessa.Ban097;

public interface IDetalheRemessaCnab400Ban097
{
	CampoLayoutArquivoCobranca IdentificacaoRegistro { get; }

	CampoLayoutArquivoCobranca TipoInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario { get; }

	CampoLayoutArquivoCobranca CodigoAgenciaBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca ContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }

	CampoLayoutArquivoCobranca CodigoControleEmpresa { get; }

	CampoLayoutArquivoCobranca NossoNumero { get; }

	CampoLayoutArquivoCobranca Filler3 { get; }

	CampoLayoutArquivoCobranca Filler4 { get; }

	CampoLayoutArquivoCobranca ComandoIdentificacao { get; }

	CampoLayoutArquivoCobranca DataRealizacaoSituacao { get; }

	CampoLayoutArquivoCobranca Filler5 { get; }

	CampoLayoutArquivoCobranca Filler6 { get; }

	CampoLayoutArquivoCobranca Filler7 { get; }

	CampoLayoutArquivoCobranca ContaCaucao { get; }

	CampoLayoutArquivoCobranca CodigoResponsabilidade { get; }

	CampoLayoutArquivoCobranca DVCodigoResponsabilidade { get; }

	CampoLayoutArquivoCobranca NumeroBordero { get; }

	CampoLayoutArquivoCobranca Filler8 { get; }

	CampoLayoutArquivoCobranca CarteiraModalidade { get; }

	CampoLayoutArquivoCobranca CodigoMovimentoRemessa { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorTitulo { get; }

	CampoLayoutArquivoCobranca Filler9 { get; }

	CampoLayoutArquivoCobranca Filler10 { get; }

	CampoLayoutArquivoCobranca Filler11 { get; }

	CampoLayoutArquivoCobranca Filler12 { get; }

	CampoLayoutArquivoCobranca Filler13 { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca Filler14 { get; }

	CampoLayoutArquivoCobranca Filler15 { get; }

	CampoLayoutArquivoCobranca PercentualTaxaJuros { get; }

	CampoLayoutArquivoCobranca PercentualTaxaMulta { get; }

	CampoLayoutArquivoCobranca CodigoJuros { get; }

	CampoLayoutArquivoCobranca DiasJuros { get; }

	CampoLayoutArquivoCobranca CodigoMulta { get; }

	CampoLayoutArquivoCobranca DiasMulta { get; }

	CampoLayoutArquivoCobranca DataPrimeiroDesconto { get; }

	CampoLayoutArquivoCobranca ValorPrimeiroDesconto { get; }

	CampoLayoutArquivoCobranca DataSegundoDesconto { get; }

	CampoLayoutArquivoCobranca ValorSegundoDesconto { get; }

	CampoLayoutArquivoCobranca TipoInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoPagador { get; }

	CampoLayoutArquivoCobranca NomePagador { get; }

	CampoLayoutArquivoCobranca EnderecoPagador { get; }

	CampoLayoutArquivoCobranca BairroPagador { get; }

	CampoLayoutArquivoCobranca CepPagador { get; }

	CampoLayoutArquivoCobranca CidadePagador { get; }

	CampoLayoutArquivoCobranca UfPagador { get; }

	CampoLayoutArquivoCobranca NomeSacadorAvalista { get; }

	CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista { get; }

	CampoLayoutArquivoCobranca Protesto { get; }

	CampoLayoutArquivoCobranca Filler16 { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistro { get; }
}
