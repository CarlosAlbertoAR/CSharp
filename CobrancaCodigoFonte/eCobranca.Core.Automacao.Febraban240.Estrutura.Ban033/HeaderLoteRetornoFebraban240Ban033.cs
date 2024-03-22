using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class HeaderLoteRetornoFebraban240Ban033 : HeaderLoteFebraban240, IHeaderLoteRetornoFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca NumeroLote => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[3];

	public CampoLayoutArquivoCobranca TipoServico => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca NumeroVersaoLayout => campos[6];

	public CampoLayoutArquivoCobranca Filler2 => campos[7];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[9];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca Filler3 => campos[11];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[12];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[13];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[14];

	public CampoLayoutArquivoCobranca DvContaCorrenteBeneficiario => campos[15];

	public CampoLayoutArquivoCobranca Filler4 => campos[16];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[17];

	public CampoLayoutArquivoCobranca Filler5 => campos[18];

	public CampoLayoutArquivoCobranca NumeroRetorno => campos[19];

	public CampoLayoutArquivoCobranca DataGravacao => campos[20];

	public CampoLayoutArquivoCobranca Filler6 => campos[21];

	public HeaderLoteRetornoFebraban240Ban033()
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.1", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.1", "Número do lote", "Número do lote no retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.1", "Tipo de registro", "Tipo de registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.1", "Tipo de operação", "Tipo de operação", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 9, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.1", "Tipo de serviço", "Tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 10, 11, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.1", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 12, 13, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.1", "Número da versão do layout do lote", "Número da versão do layout do lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 14, 16, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.1", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 17, 17, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.1", "Tipo de inscrição do beneficiário", "Tipo de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.1", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 33, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.1", "Código do beneficiário", "Código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 34, 42, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.1", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 43, 53, 11, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.1", "Agência do beneficiário", "Agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 54, 57, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.1", "Dv agência do beneficiário", "Dígito verificador da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 58, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.1", "Número da conta corrente do beneficiário", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 67, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.1", "Dv conta corrente do beneficiário", "Dígito verificador da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 68, 68, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.1", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 69, 73, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.1", "Nome do beneficiário", "Nome do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 103, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.1", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 104, 183, 80, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.1", "Número do retorno", "Número do retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 184, 191, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.1", "Data de gravação do arquivo", "Data de gravação do arquivo no formato: DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 192, 199, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.1", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 200, 240, 41, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
