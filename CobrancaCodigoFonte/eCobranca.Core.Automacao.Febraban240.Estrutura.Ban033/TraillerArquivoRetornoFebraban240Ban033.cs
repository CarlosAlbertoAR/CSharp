using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class TraillerArquivoRetornoFebraban240Ban033 : TraillerArquivoFebraban240, ITraillerArquivoRetornoFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca NumeroLote => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca QuantidadeLotes => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeRegistros => campos[5];

	public CampoLayoutArquivoCobranca Filler2 => campos[6];

	public TraillerArquivoRetornoFebraban240Ban033()
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.9", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.9", "Número do lote", "Número do lote na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.9", "Tipo de registro", "Tipo do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.9", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 17, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.9", "Quantidade de lotes no arquivo", "Quantidade de lotes no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 23, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de registros", "Quantidade de registros no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 24, 29, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.9", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 30, 240, 211, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
