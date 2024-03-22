using System.Collections.Generic;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class HeaderLoteRemessaFebraban240Ban033 : HeaderLoteFebraban240, IHeaderLoteRemessaFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[3];

	public CampoLayoutArquivoCobranca TipoServico => campos[4];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[5];

	public CampoLayoutArquivoCobranca NumeroVersaoLayoutLote => campos[6];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[7];

	public CampoLayoutArquivoCobranca TipoInscricaoEmpresa => campos[8];

	public CampoLayoutArquivoCobranca NumeroInscricaoEmpresa => campos[9];

	public CampoLayoutArquivoCobranca UsoReservadoBanco3 => campos[10];

	public CampoLayoutArquivoCobranca CodigoTransmissao => campos[11];

	public CampoLayoutArquivoCobranca UsoReservadoBanco4 => campos[12];

	public CampoLayoutArquivoCobranca NomeCedente => campos[13];

	public CampoLayoutArquivoCobranca Mensagem1 => campos[14];

	public CampoLayoutArquivoCobranca Mensagem2 => campos[15];

	public CampoLayoutArquivoCobranca NumeroRemessaRetorno => campos[16];

	public CampoLayoutArquivoCobranca DataGravacaoRemessaRetorno => campos[17];

	public CampoLayoutArquivoCobranca UsoReservadoBanco5 => campos[18];

	public HeaderLoteRemessaFebraban240Ban033()
	{
		List<CampoLayoutArquivoCobranca> list = new List<CampoLayoutArquivoCobranca>();
		for (int i = 0; i < campos.Count; i++)
		{
			if (i < 11)
			{
				list.Add(campos[i]);
			}
			else if (i > 15 && i < 21)
			{
				list.Add(campos[i]);
			}
		}
		campos = list;
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.1", "Código de transmissão", "Código de transmissão", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 54, 68, 15, 0);
		campos.Insert(11, campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.1", "Uso exclusivo Febraban240", "Filler - Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 69, 73, 5, 0);
		campos.Insert(12, campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.1", "Uso exclusivo Febraban240", "Filler - Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 200, 240, 41, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
