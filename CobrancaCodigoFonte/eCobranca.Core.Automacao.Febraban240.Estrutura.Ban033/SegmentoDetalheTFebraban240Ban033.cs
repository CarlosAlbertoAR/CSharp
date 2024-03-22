using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalheTFebraban240Ban033 : SegmentoDetalheTFebraban240, ISegmentoDetalheTFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBanco => campos[0];

	public CampoLayoutArquivoCobranca NumeroLote => campos[1];

	public CampoLayoutArquivoCobranca TipoDoRegistro => campos[2];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistroLote => campos[3];

	public CampoLayoutArquivoCobranca CodigoDoSegmentoRegistroDetalhe => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[6];

	public CampoLayoutArquivoCobranca AgenciaBeneficiario => campos[7];

	public CampoLayoutArquivoCobranca DVAgenciaBeneficiario => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrenteBeneficiario => campos[9];

	public CampoLayoutArquivoCobranca DVContaCorrenteBeneficiario => campos[10];

	public CampoLayoutArquivoCobranca Filler2 => campos[11];

	public CampoLayoutArquivoCobranca NossoNumero => campos[12];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[13];

	public CampoLayoutArquivoCobranca NumeroDocumentoCobranca => campos[14];

	public CampoLayoutArquivoCobranca DataVencimentoTitulo => campos[15];

	public CampoLayoutArquivoCobranca ValorNominalTitulo => campos[16];

	public CampoLayoutArquivoCobranca CodigoBancoCobrador => campos[17];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[18];

	public CampoLayoutArquivoCobranca DvAgenciaCobradora => campos[19];

	public CampoLayoutArquivoCobranca IdentificacaoTituloBeneficiario => campos[20];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[21];

	public CampoLayoutArquivoCobranca TipoInscricaoPagador => campos[22];

	public CampoLayoutArquivoCobranca NumeroInscricaoPagador => campos[23];

	public CampoLayoutArquivoCobranca NomePagador => campos[24];

	public CampoLayoutArquivoCobranca ContaCobranca => campos[25];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[26];

	public CampoLayoutArquivoCobranca MotivosOcorrencia => campos[27];

	public CampoLayoutArquivoCobranca Filler3 => campos[28];

	public SegmentoDetalheTFebraban240Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.3T", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.3T", "Número do lote", "Número do lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.3T", "Tipo de registro", "Informar 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.3T", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.3T", "Código do segmento do registro de detalhe", "Informar T", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.3T", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.3T", "Código da ocorrência", "Código da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.3T", "Agência do beneficiário", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.3T", "DV agência do beneficiário", "Dígito verificador da agência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 22, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.3T", "Número da conta corrente", "Número da conta corrente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 31, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3T", "DV conta corrente do beneficiário", "DV conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 32, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.3T", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 33, 40, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.3T", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 53, 13, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.3T", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 54, 54, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.3T", "Número do documento de cobrança", "Número do documento de cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 55, 69, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.3T", "Data de vencimento do título", "Dta de vencimento do título DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 70, 77, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.3T", "Valor nominal do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 92, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.3T", "Número do banco cobrador", "Número do banco cobrador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 95, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.3T", "Agência cobradora", "Agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 96, 99, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.3T", "DV agência cobradora", "DV agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 100, 100, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.3T", "Identificação do título no beneficiário", "Identificação do título no beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 101, 125, 25, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.3T", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 126, 127, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("23.3T", "Tipo inscrição do pagador", "Tipo inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 128, 128, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("24.3T", "Número inscrição do pagador", "Número inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 129, 143, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("25.3T", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 144, 183, 40, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("26.3T", "Conta cobrança", "Conta cobrança", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 184, 193, 10, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("27.3T", "Valor da tarifa", "Valor da tarifa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 194, 208, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("28.3T", "Motivos ocorrência", "Motivos ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 209, 218, 10, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("29.3T", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 219, 240, 22, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
