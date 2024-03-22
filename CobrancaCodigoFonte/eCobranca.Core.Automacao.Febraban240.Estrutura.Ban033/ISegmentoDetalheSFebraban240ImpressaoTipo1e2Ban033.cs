using eCobranca.Core.Automacao.Estrutura;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public interface ISegmentoDetalheSFebraban240ImpressaoTipo1e2Ban033
{
	CampoLayoutArquivoCobranca NumeroLinha { get; }

	CampoLayoutArquivoCobranca MensagemParaReciboSacado { get; }

	CampoLayoutArquivoCobranca MensagemASerImpressa { get; }

	CampoLayoutArquivoCobranca UsoReservadoBanco1 { get; }
}
