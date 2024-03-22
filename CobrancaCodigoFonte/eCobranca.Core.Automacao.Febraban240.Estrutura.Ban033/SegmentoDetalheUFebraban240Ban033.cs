using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalheUFebraban240Ban033 : SegmentoDetalheUFebraban240, ISegmentoDetalheUFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBanco => campos[0];

	public CampoLayoutArquivoCobranca LoteDeServico => campos[1];

	public CampoLayoutArquivoCobranca TipoDoRegistro => campos[2];

	public CampoLayoutArquivoCobranca NumeroSequencialDoRegistroLote => campos[3];

	public CampoLayoutArquivoCobranca CodigoDoSegmentoRegistroDetalhe => campos[4];

	public CampoLayoutArquivoCobranca Filler1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[6];

	public CampoLayoutArquivoCobranca ValorJurosMultaEncargos => campos[7];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[8];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[9];

	public CampoLayoutArquivoCobranca ValorIOF => campos[10];

	public CampoLayoutArquivoCobranca ValorPago => campos[11];

	public CampoLayoutArquivoCobranca ValorLiquido => campos[12];

	public CampoLayoutArquivoCobranca ValorOutrasDespesas => campos[13];

	public CampoLayoutArquivoCobranca ValorOutrosCreditos => campos[14];

	public CampoLayoutArquivoCobranca DataOcorrencia => campos[15];

	public CampoLayoutArquivoCobranca DataCredito => campos[16];

	public CampoLayoutArquivoCobranca CodigoOcorrenciaPagador => campos[17];

	public CampoLayoutArquivoCobranca DataOcorrenciaPagador => campos[18];

	public CampoLayoutArquivoCobranca ValorOcorrenciaPagador => campos[19];

	public CampoLayoutArquivoCobranca ComplementoOcorrenciaPagador => campos[20];

	public CampoLayoutArquivoCobranca CodigoBancoCorrespondente => campos[21];

	public CampoLayoutArquivoCobranca Filler2 => campos[22];

	public SegmentoDetalheUFebraban240Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.3U", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.3U", "Lote de serviço", "Lote de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.3U", "Tipo do registro", "Tipo do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.3U", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.3U", "Código do segmento do registro detalhe", "Informar U", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.3U", "Filler 1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.3U", "Código da ocorrência", "Código da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.3U", "Valor juros/multa/encargos", "Valor dos juros + multa + encargos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 32, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.3U", "Valor do desconto", "Valor do desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 47, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.3U", "Valor do abatimento", "Valor do abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 48, 62, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3U", "Valor IOF", "Valor do IOF", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 77, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.3U", "Valor pago", "Valor pago", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 92, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.3U", "Valor líquido", "Valor líquido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 93, 107, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.3U", "Valor outras despesas", "Valor outras despesas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 108, 122, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.3U", "Valor outros créditos", "Valor outros créditos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 123, 137, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.3U", "Data da ocorrência", "Data da ocorrência", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 145, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.3U", "Data da efetivação do crédito", "Data de crédito", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 153, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.3U", "Código ocorrência do pagador", "Código da ocorrência do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 154, 157, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.3U", "Data da ocorrência do pagador", "Data da ocorrência do pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 158, 165, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.3U", "Valor ocorrência pagador", "Valor ocorrência pagador", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 180, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.3U", "Complemento ocorrência pagador", "Complemento da ocorrência do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 181, 210, 30, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.3U", "Código do banco correspondente", "Código do banco correspondente", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 211, 213, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("23.3U", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 214, 240, 27, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
