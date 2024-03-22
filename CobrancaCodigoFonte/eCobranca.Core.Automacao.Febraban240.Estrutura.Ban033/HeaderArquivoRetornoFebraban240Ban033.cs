using System.Collections.Generic;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class HeaderArquivoRetornoFebraban240Ban033 : HeaderArquivoFebraban240, IHeaderArquivoRetornoFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBancoCompensacao => campos[0];

	public CampoLayoutArquivoCobranca LoteServico => campos[1];

	public CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca Filler1 => campos[3];

	public CampoLayoutArquivoCobranca TipoInscricaoBeneficiario => campos[4];

	public CampoLayoutArquivoCobranca NumeroInscricaoBeneficiario => campos[5];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[6];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[8];

	public CampoLayoutArquivoCobranca DVContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca Filler2 => campos[10];

	public CampoLayoutArquivoCobranca CodigoBeneficiario => campos[11];

	public CampoLayoutArquivoCobranca Filler3 => campos[12];

	public CampoLayoutArquivoCobranca NomeBeneficiario => campos[13];

	public CampoLayoutArquivoCobranca NomeBanco => campos[14];

	public CampoLayoutArquivoCobranca Filler4 => campos[15];

	public CampoLayoutArquivoCobranca CodigoRetorno => campos[16];

	public CampoLayoutArquivoCobranca DataGeracaoArquivo => campos[17];

	public CampoLayoutArquivoCobranca Filler5 => campos[18];

	public CampoLayoutArquivoCobranca NumeroSequencialArquivo => campos[19];

	public CampoLayoutArquivoCobranca NumeroVersaoLayoutArquivo => campos[20];

	public CampoLayoutArquivoCobranca Filler6 => campos[21];

	public HeaderArquivoRetornoFebraban240Ban033()
	{
		new List<CampoLayoutArquivoCobranca>();
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.0", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.0", "Lote de serviço", "Lote de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.0", "Tipo de registro", "Tipo de registro: informar 0", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.0", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 9, 16, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.0", "Tipo inscrição do beneficiário", "Tipo de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 17, 17, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.0", "Número de inscrição do beneficiário", "Número de inscrição do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 32, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.0", "Agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 36, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.0", "Dv da agência do beneficiário", "DV da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 37, 37, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.0", "Número da conta corrente do beneficiário", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 38, 46, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.0", "DV da conta corrente do beneficiário", "Dígito verificador da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 47, 47, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.0", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 52, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.0", "Código do beneficiário", "Código do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 53, 61, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.0", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 62, 72, 11, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.0", "Nome do beneficiário", "Nome do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 73, 102, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.0", "Nome do banco", "Nome do banco", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 103, 132, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.0", "Filler4", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 133, 142, 10, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.0", "Código do retorno", "Informar 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 143, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.0", "Data de geração do arquivo", "Data de geração do arquivo no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 144, 151, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.0", "Filler5", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 157, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.0", "Número sequencial do arquivo", "Número sequencial do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 163, 6, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.0", "Número da versão do layout do arquivo", "Informar 040", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 166, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.0", "Filler6", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 167, 240, 74, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}

	public override int GetNumeroSequencialArquivo()
	{
		return int.Parse(campos[19].Valor.Trim());
	}
}
