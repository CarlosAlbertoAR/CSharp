using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalhePFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca NumeroLoteNaRemessa { get; }

	CampoLayoutArquivoCobranca TipoRegistro { get; }

	CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote { get; }

	CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }

	CampoLayoutArquivoCobranca CodigoMovimentoRemessa { get; }

	CampoLayoutArquivoCobranca CodigoAgencia { get; }

	CampoLayoutArquivoCobranca DvAgencia { get; }

	CampoLayoutArquivoCobranca NumeroContaCorrente { get; }

	CampoLayoutArquivoCobranca DvContaCorrente { get; }

	CampoLayoutArquivoCobranca ContaCobranca { get; }

	CampoLayoutArquivoCobranca DvContaCobranca { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco2 { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco { get; }

	CampoLayoutArquivoCobranca TipoCobranca { get; }

	CampoLayoutArquivoCobranca FormaCadastramento { get; }

	CampoLayoutArquivoCobranca TipoDocumento { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco3 { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco4 { get; }

	CampoLayoutArquivoCobranca NumeroDocumento { get; }

	CampoLayoutArquivoCobranca DataVencimento { get; }

	CampoLayoutArquivoCobranca ValorNominal { get; }

	CampoLayoutArquivoCobranca AgenciaCobradora { get; }

	CampoLayoutArquivoCobranca DvAgenciaCobradora { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco5 { get; }

	CampoLayoutArquivoCobranca EspecieDocumento { get; }

	CampoLayoutArquivoCobranca CodigoAceite { get; }

	CampoLayoutArquivoCobranca DataEmissao { get; }

	CampoLayoutArquivoCobranca CodigoJuros { get; }

	CampoLayoutArquivoCobranca DataJuros { get; }

	CampoLayoutArquivoCobranca JurosAoDia { get; }

	CampoLayoutArquivoCobranca CodigoDesconto { get; }

	CampoLayoutArquivoCobranca DataDesconto { get; }

	CampoLayoutArquivoCobranca Desconto { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa { get; }

	CampoLayoutArquivoCobranca CodigoProtesto { get; }

	CampoLayoutArquivoCobranca NumeroDiasProtesto { get; }

	CampoLayoutArquivoCobranca CodigoBaixaDevolucao { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco6 { get; }

	CampoLayoutArquivoCobranca NumeroDiasBaixaDevolucao { get; }

	CampoLayoutArquivoCobranca CodigoMoeda { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco7 { get; }
}
