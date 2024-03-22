using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalheUFebraban240Ban033
{
	CampoLayoutArquivoCobranca CodigoBanco { get; }

	CampoLayoutArquivoCobranca LoteDeServico { get; }

	CampoLayoutArquivoCobranca TipoDoRegistro { get; }

	CampoLayoutArquivoCobranca NumeroSequencialDoRegistroLote { get; }

	CampoLayoutArquivoCobranca CodigoDoSegmentoRegistroDetalhe { get; }

	CampoLayoutArquivoCobranca Filler1 { get; }

	CampoLayoutArquivoCobranca CodigoOcorrencia { get; }

	CampoLayoutArquivoCobranca ValorJurosMultaEncargos { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorLiquido { get; }

	CampoLayoutArquivoCobranca ValorOutrasDespesas { get; }

	CampoLayoutArquivoCobranca ValorOutrosCreditos { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca DataCredito { get; }

	CampoLayoutArquivoCobranca CodigoOcorrenciaPagador { get; }

	CampoLayoutArquivoCobranca DataOcorrenciaPagador { get; }

	CampoLayoutArquivoCobranca ValorOcorrenciaPagador { get; }

	CampoLayoutArquivoCobranca ComplementoOcorrenciaPagador { get; }

	CampoLayoutArquivoCobranca CodigoBancoCorrespondente { get; }

	CampoLayoutArquivoCobranca Filler2 { get; }
}
