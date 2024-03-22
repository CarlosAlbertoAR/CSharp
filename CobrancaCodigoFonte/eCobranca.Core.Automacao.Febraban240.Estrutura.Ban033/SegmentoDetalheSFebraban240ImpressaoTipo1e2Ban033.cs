using System.Collections.Generic;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalheSFebraban240ImpressaoTipo1e2Ban033 : SegmentoDetalheSFebraban240ImpressaoTipo1e2, ISegmentoDetalheSFebraban240ImpressaoTipo1e2Ban033
{
	public CampoLayoutArquivoCobranca NumeroLinha => campos[8];

	public CampoLayoutArquivoCobranca MensagemParaReciboSacado => campos[9];

	public CampoLayoutArquivoCobranca MensagemASerImpressa => campos[10];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[11];

	public SegmentoDetalheSFebraban240ImpressaoTipo1e2Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		List<CampoLayoutArquivoCobranca> list = new List<CampoLayoutArquivoCobranca>();
		for (int i = 0; i < campos.Count; i++)
		{
			if (i < 9)
			{
				list.Add(campos[i]);
			}
		}
		campos = list;
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.3S", "Mensagem para recibo do sacado", "Mensagem para recibo do sacado - 2 ou 4", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 21, 21, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3S", "Mensagem a ser impressa", "Mensagem a ser impressa", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 22, 121, 100, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.3S", "Uso reservado do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 122, 240, 119, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
