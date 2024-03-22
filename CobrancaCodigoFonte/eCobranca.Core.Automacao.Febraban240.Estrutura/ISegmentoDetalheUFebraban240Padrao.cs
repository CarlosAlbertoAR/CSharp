using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public interface ISegmentoDetalheUFebraban240Padrao
{
	CampoLayoutArquivoCobranca ValorAcrescimos { get; }

	CampoLayoutArquivoCobranca ValorDesconto { get; }

	CampoLayoutArquivoCobranca ValorAbatimento { get; }

	CampoLayoutArquivoCobranca ValorIOF { get; }

	CampoLayoutArquivoCobranca ValorPago { get; }

	CampoLayoutArquivoCobranca ValorLiquido { get; }

	CampoLayoutArquivoCobranca ValorOutrasDespesas { get; }

	CampoLayoutArquivoCobranca ValorOutrosCreditos { get; }

	CampoLayoutArquivoCobranca DataOcorrencia { get; }

	CampoLayoutArquivoCobranca DataEfetivacaoCredito { get; }

	CampoLayoutArquivoCobranca CodigoOcorrenciaSacado { get; }

	CampoLayoutArquivoCobranca DataOcorrenciaSacado { get; }

	CampoLayoutArquivoCobranca ValorOcorrenciaSacado { get; }

	CampoLayoutArquivoCobranca ComplementoOcorrenciaSacado { get; }

	CampoLayoutArquivoCobranca CodigoBancoCorrespondente { get; }

	CampoLayoutArquivoCobranca NossoNumeroBancoCorrespondente { get; }

	CampoLayoutArquivoCobranca UsoExclusivoFebraban2 { get; }
}
