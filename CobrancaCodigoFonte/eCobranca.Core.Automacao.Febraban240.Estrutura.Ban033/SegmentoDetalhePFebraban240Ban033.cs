using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban033;

public class SegmentoDetalhePFebraban240Ban033 : SegmentoDetalhePFebraban240, ISegmentoDetalhePFebraban240Ban033
{
	public CampoLayoutArquivoCobranca CodigoBanco => campos[0];

	public CampoLayoutArquivoCobranca NumeroLoteNaRemessa => campos[1];

	public new CampoLayoutArquivoCobranca TipoRegistro => campos[2];

	public new CampoLayoutArquivoCobranca NumeroSequencialRegistroNoLote => campos[3];

	public new CampoLayoutArquivoCobranca CodigoSegmentoRegistroDetalhe => campos[4];

	public CampoLayoutArquivoCobranca UsoReservadoBanco1 => campos[5];

	public CampoLayoutArquivoCobranca CodigoMovimentoRemessa => campos[6];

	public CampoLayoutArquivoCobranca CodigoAgencia => campos[7];

	public CampoLayoutArquivoCobranca DvAgencia => campos[8];

	public CampoLayoutArquivoCobranca NumeroContaCorrente => campos[9];

	public CampoLayoutArquivoCobranca DvContaCorrente => campos[10];

	public CampoLayoutArquivoCobranca ContaCobranca => campos[11];

	public CampoLayoutArquivoCobranca DvContaCobranca => campos[12];

	public CampoLayoutArquivoCobranca UsoReservadoBanco2 => campos[13];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNoBanco => campos[14];

	public CampoLayoutArquivoCobranca TipoCobranca => campos[15];

	public CampoLayoutArquivoCobranca FormaCadastramento => campos[16];

	public CampoLayoutArquivoCobranca TipoDocumento => campos[17];

	public CampoLayoutArquivoCobranca UsoReservadoBanco3 => campos[18];

	public CampoLayoutArquivoCobranca UsoReservadoBanco4 => campos[19];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[20];

	public CampoLayoutArquivoCobranca DataVencimento => campos[21];

	public CampoLayoutArquivoCobranca ValorNominal => campos[22];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[23];

	public CampoLayoutArquivoCobranca DvAgenciaCobradora => campos[24];

	public CampoLayoutArquivoCobranca UsoReservadoBanco5 => campos[25];

	public CampoLayoutArquivoCobranca EspecieDocumento => campos[26];

	public CampoLayoutArquivoCobranca CodigoAceite => campos[27];

	public CampoLayoutArquivoCobranca DataEmissao => campos[28];

	public CampoLayoutArquivoCobranca CodigoJuros => campos[29];

	public CampoLayoutArquivoCobranca DataJuros => campos[30];

	public CampoLayoutArquivoCobranca JurosAoDia => campos[31];

	public CampoLayoutArquivoCobranca CodigoDesconto => campos[32];

	public CampoLayoutArquivoCobranca DataDesconto => campos[33];

	public CampoLayoutArquivoCobranca Desconto => campos[34];

	public CampoLayoutArquivoCobranca ValorIOF => campos[35];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[36];

	public CampoLayoutArquivoCobranca IdentificacaoTituloNaEmpresa => campos[37];

	public CampoLayoutArquivoCobranca CodigoProtesto => campos[38];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[39];

	public CampoLayoutArquivoCobranca CodigoBaixaDevolucao => campos[40];

	public CampoLayoutArquivoCobranca UsoReservadoBanco6 => campos[41];

	public CampoLayoutArquivoCobranca NumeroDiasBaixaDevolucao => campos[42];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[43];

	public CampoLayoutArquivoCobranca UsoReservadoBanco7 => campos[44];

	public SegmentoDetalhePFebraban240Ban033(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		campos.Clear();
		CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("01.3P", "Código do banco na compensação", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 3, 3, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("02.3P", "Número do lote na remessa", "Número do lote na remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 4, 7, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("03.3P", "Tipo de registro", "Informar 3", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("04.3P", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("05.3P", "Código do segmento do registro detalhe", "Informar P", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("06.3P", "Reservado ao banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("07.3P", "Código de movimento remessa", "Código de movimento remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("08.3P", "Agência do cedente", "Código da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 21, 4, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("09.3P", "Dv agência do cedente", "Dígito verificador da agência do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 22, 22, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("10.3P", "Número da conta corrente", "Número da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 23, 31, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("11.3P", "Dv da conta corrente", "Dígito verificador da conta corrente do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 32, 32, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("12.3P", "Conta cobrança", "Conta de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 33, 41, 9, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("13.3P", "Dígito da conta cobrança", "Dígito da conta de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 42, 42, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("14.3P", "Reservado uso do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 43, 44, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("15.3P", "Nosso número", "Nosso número, identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 45, 57, 13, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("16.3P", "Tipo de cobrança", "Tipo de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 58, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("17.3P", "Forma de cadastramento", "Forma de cadastramento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 59, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("18.3P", "Tipo de documento", "1-Tradicional, 2-Escritural", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 60, 60, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("19.3P", "Reservado uso do banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 61, 61, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("20.3P", "Reservado uso do banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 62, 62, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("21.3P", "Número do documento", "Seu número", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 77, 15, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("22.3P", "Data de vencimento do título", "Informar a data no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 85, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("23.3P", "Valor nominal do título", "Valor nominal do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 100, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("24.3P", "Agência cobradora", "Agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 104, 4, 0);
		campos.Insert(23, campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("25.3P", "Dígito agência cobradora", "Dígito agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 105, 105, 1, 0);
		campos.Insert(24, campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("26.3P", "Reservado uso do banco", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 106, 106, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("27.3P", "Espécie do título", "Espécie do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 107, 108, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("28.3P", "Identificação do título Aceito/Não aceito", "N-Não aceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 109, 109, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("29.3P", "Data da emissão do título", "Informar no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 110, 117, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("30.3P", "Código do juros de mora", "Código do juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 118, 118, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("31.3P", "Data do juros de mora", "Informar no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 119, 126, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("32.3P", "Valor da mora/dia ou taxa mensal", "Valor da mora/dia ou taxa mensal", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 127, 141, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("33.3P", "Código do desconto 1", "Código do desconto 1", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 142, 142, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("34.3P", "Data do desconto 1", "Informar no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 150, 8, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("35.3P", "Valor ou percentual de desconto concedido", "Valor ou percentual de desconto concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 165, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("36.3P", "Valor do IOF a ser recolhido", "Valor do IOF a ser recolhido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 166, 180, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("37.3P", "Valor do abatimento", "Valor do abatimento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 181, 195, 13, 2);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("38.3P", "Identificação do título na empresa", "Uso beneficiário opcional", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 196, 220, 25, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("39.3P", "Código para protesto", "Código para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 221, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("40.3P", "Número de dias para protesto", "Número de dias para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 222, 223, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("41.3P", "Código para baixa devolução", "Código para baixa devolução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 224, 224, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("42.3P", "Reservado uso do banco", "Filler - informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 225, 225, 1, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("43.3P", "Número de dias para baixa e devolução", "Número de dias para baixa e devolução", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 226, 227, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("44.3P", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 229, 2, 0);
		campos.Add(campoLayoutArquivoCobranca);
		campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
		campoLayoutArquivoCobranca.Preparar("45.3P", "Reservado uso do banco", "Filler - informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 230, 240, 11, 0);
		campos.Add(campoLayoutArquivoCobranca);
	}
}
