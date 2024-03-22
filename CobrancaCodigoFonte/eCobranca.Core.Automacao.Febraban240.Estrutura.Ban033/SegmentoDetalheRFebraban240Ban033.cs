using System.Collections.Generic;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalheRFebraban240Ban033 : SegmentoDetalheRFebraban240, ISegmentoDetalheRFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoDesconto2 => campos[7];

	public CampoLayoutArquivoCobranca DataDesconto2 => campos[8];

	public CampoLayoutArquivoCobranca Desconto2 => campos[9];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[10];

	public CampoLayoutArquivoCobranca CodigoMulta => campos[11];

	public CampoLayoutArquivoCobranca DataMulta => campos[12];

	public CampoLayoutArquivoCobranca Multa => campos[13];

	public CampoLayoutArquivoCobranca UsoReservadoBanco3 => campos[14];

	public CampoLayoutArquivoCobranca Mensagem3 => campos[15];

	public CampoLayoutArquivoCobranca Mensagem4 => campos[16];

	public CampoLayoutArquivoCobranca UsoReservadoBanco4 => campos[17];

	public SegmentoDetalheRFebraban240Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		List<CampoLayoutArquivoCobranca> list = new List<CampoLayoutArquivoCobranca>();
		for (int i = 0; i < campos.Count; i++)
		{
			if (i < 10)
			{
				list.Add(campos[i]);
			}
			else if (i > 12 && i < 19)
			{
				list.Add(campos[i]);
			}
		}
		campos = list;
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3R", "Uso reservado do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 42, 65, 24, 0);
		campos.Insert(10, campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.3Q", "Uso Reservado do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 180, 240, 61, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
