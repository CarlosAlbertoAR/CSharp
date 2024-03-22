using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalheQFebraban240Ban033 : SegmentoDetalheQFebraban240, ISegmentoDetalheQFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBanco => campos[0];

	public CampoLayoutArquivoCobranca NumeroLoteNaRemessa => campos[1];

	public new CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public new CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote => campos[3];

	public new CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe => campos[4];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoMovimentoRemessa => campos[6];

	public CampoLayoutArquivoCobranca TipoInscricaoSacado => campos[7];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacado => campos[8];

	public CampoLayoutArquivoCobranca NomeSacado => campos[9];

	public CampoLayoutArquivoCobranca EnderecoSacado => campos[10];

	public CampoLayoutArquivoCobranca BairroSacado => campos[11];

	public CampoLayoutArquivoCobranca CepSacado => campos[12];

	public CampoLayoutArquivoCobranca SufixoCepSacado => campos[13];

	public CampoLayoutArquivoCobranca CidadeSacado => campos[14];

	public CampoLayoutArquivoCobranca UfSacado => campos[15];

	public CampoLayoutArquivoCobranca TipoInscricaoSacadorAvalista => campos[16];

	public CampoLayoutArquivoCobranca NumeroInscricaoSacadorAvalista => campos[17];

	public CampoLayoutArquivoCobranca NomeSacadorAvalista => campos[18];

	public CampoLayoutArquivoCobranca IdentificadorCarne => campos[19];

	public CampoLayoutArquivoCobranca SequencialParcela => campos[20];

	public CampoLayoutArquivoCobranca QuantidadeTotalParcelas => campos[21];

	public CampoLayoutArquivoCobranca NumeroPlano => campos[22];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[23];

	public SegmentoDetalheQFebraban240Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.3Q", "Código do banco na compensação", "Código do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.3Q", "Número do lote na remessa", "Número do lote na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.3Q", "Tipo de registro", "Tipo de registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.3Q", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.3Q", "Código do segmento do registro detalhe", "Informar Q", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.3Q", "Reservado ao uso do banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.3Q", "Código de movimento remessa", "Código de movimento remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.3Q", "Tipo de inscrição do pagador", "Tipo de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 18, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.3Q", "Número de inscrição do pagador", "Número de inscrição do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 19, 33, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.3Q", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 34, 73, 40, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3Q", "Endereço do pagador", "Endereço do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 74, 113, 40, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.3Q", "Bairro do pagador", "Bairro do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 114, 128, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.3Q", "Cep do pagador", "Cep do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 129, 133, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.3Q", "Sufixo do cep", "Sufixo do cep", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 136, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.3Q", "Cidade do pagador", "Cidade do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 137, 151, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.3Q", "Unidade da federação do pagador", "Unidade da federação do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 152, 153, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.3Q", "Tipo de inscrição do sacador avalista", "Tipo de inscrição do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 154, 154, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.3Q", "Número de inscrição do sacador avalista", "Número de inscrição do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 155, 169, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.3Q", "Nome do sacador avalista", "Nome do sacador avalista", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 170, 209, 40, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.3Q", "Identificador de carnê", "Identificador de carnÊ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 210, 212, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.3Q", "Sequencial da parcela", "Sequencial da parcela ou número inicial da parcela", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 213, 215, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.3Q", "Quantidade total de parcelas", "Quantidade total de parcelas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 216, 218, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("23.3Q", "Número do plano", "Número do plano", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 219, 221, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("24.3Q", "Reservado uso do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 222, 240, 19, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
