using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil : SegmentoDetalhePFebraban240, ISegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca Filler1 => campos[0];

	public CampoLayoutArquivoCobranca TipoDoRegistro => campos[1];

	public CampoLayoutArquivoCobranca NumeroSequencialDoRegistroLote => campos[2];

	public CampoLayoutArquivoCobranca CodigoSegmentoDetalhe => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca CodigoInstrucao => campos[5];

	public CampoLayoutArquivoCobranca Filler3 => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[8];

	public CampoLayoutArquivoCobranca TipoDocumento => campos[9];

	public CampoLayoutArquivoCobranca IdentificacaoEmissorBoleto => campos[10];

	public CampoLayoutArquivoCobranca Filler4 => campos[11];

	public CampoLayoutArquivoCobranca NumeroDocumentoCobranca => campos[12];

	public CampoLayoutArquivoCobranca DataVencimento => campos[13];

	public CampoLayoutArquivoCobranca ValorDocumento => campos[14];

	public CampoLayoutArquivoCobranca Filler5 => campos[15];

	public CampoLayoutArquivoCobranca CodigoAceite => campos[16];

	public CampoLayoutArquivoCobranca Filler6 => campos[17];

	public CampoLayoutArquivoCobranca DataEmissao => campos[18];

	public CampoLayoutArquivoCobranca TipoDeMora => campos[19];

	public CampoLayoutArquivoCobranca ValorJurosDeMora => campos[20];

	public CampoLayoutArquivoCobranca Filler7 => campos[21];

	public CampoLayoutArquivoCobranca DataLimiteDesconto => campos[22];

	public CampoLayoutArquivoCobranca ValorDesconto => campos[23];

	public CampoLayoutArquivoCobranca Filler8 => campos[24];

	public CampoLayoutArquivoCobranca ValorAbatimento => campos[25];

	public CampoLayoutArquivoCobranca ControleBeneficiario => campos[26];

	public CampoLayoutArquivoCobranca ProtestoAutomatico => campos[27];

	public CampoLayoutArquivoCobranca NumeroDiasProtesto => campos[28];

	public CampoLayoutArquivoCobranca Filler9 => campos[29];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[30];

	public CampoLayoutArquivoCobranca NumeroContratoOperacaoCredito => campos[31];

	public CampoLayoutArquivoCobranca Filler10 => campos[32];

	public SegmentoDetalhePFebraban240Ban756CorrespondenteBancoBrasil(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN240.");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3P", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 7, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3P", "Registro detalhe", "Tipo do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3P", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3P", "Código do segmento do registro detalhe", "Código do segmento do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.ALFA, EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo(), EnumTipoSegmentoDetalheFebraban240.SEGMENTO_P.Codigo(), 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3P", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3P", "Código da instrução", "Código da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3P", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 40, 23, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3P", "Nosso número", "Nosso número", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 57, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3P", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 58, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3P", "Tipo de documento", "Tipo de documento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 59, 60, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3P", "Identificação do emissor do boleto", "1-Banco emite; 2-Beneficiário emite", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 61, 61, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3P", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 62, 62, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3P", "Numero documento de cobrança", "Número de documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 63, 77, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3P", "Data de vencimento do título", "Data de vencimento do título no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 85, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3P", "Valor do documento", "Valor do documento", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 86, 100, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3P", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 106, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3P", "Identificação de aceite", "A - Aceite, N - Não aceite", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 107, 107, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3P", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 108, 109, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3P", "Data de emissão", "Data no formatado DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 110, 117, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3P", "Tipo de mora", "1 - Isento, 2 - Valor, 3 - Porcentagem", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 118, 118, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3P", "Valor dos juros de mora", "Valor dos juros de mora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 119, 133, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3P", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 142, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3P", "Data limite para concessão de desconto", "Data no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 150, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3P", "Valor do desconto concedido", "Valor do desconto concedido com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 151, 165, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.3P", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 166, 180, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.3P", "Valor do abatimento", "Valor do abatimento com duas casas decimais", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 181, 195, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.3P", "Controle do beneficiário", "Valor de controle da empresa único para cada título", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 196, 220, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.3P", "Protesto automático", "0-Não, 1-Sim", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 221, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.3P", "Número de dias para protesto", "Número de dias para protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 222, 223, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("30.3P", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 224, 227, 4, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("31.3P", "Código da moeda", "09-real", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 228, 229, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("32.3P", "Número do contrato de operação de crédito", "Caso o título seja vinculado a um contrato de desconto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 230, 239, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("33.3P", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 240, 240, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
		}
		catch (Exception ex)
		{
			if (ex is ExcecaoECobranca)
			{
				Launcher.GetInstance().LancarExcecao(ex, new StackTrace().GetFrame(1).GetMethod());
			}
			else
			{
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoBaseDetalheFebraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
