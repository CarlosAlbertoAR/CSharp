using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura.Ban756;

public class SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil : SegmentoDetalheTFebraban240, ISegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil
{
	public CampoLayoutArquivoCobranca Filler1 => campos[0];

	public CampoLayoutArquivoCobranca RegistroDetalhe => campos[1];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistroLote => campos[2];

	public CampoLayoutArquivoCobranca CodigoSegmentoDoRegistroDetalhe => campos[3];

	public CampoLayoutArquivoCobranca Filler2 => campos[4];

	public CampoLayoutArquivoCobranca CodigoOcorrencia => campos[5];

	public CampoLayoutArquivoCobranca Filler3 => campos[6];

	public CampoLayoutArquivoCobranca NossoNumero => campos[7];

	public CampoLayoutArquivoCobranca CodigoCarteira => campos[8];

	public CampoLayoutArquivoCobranca NumeroDocumento => campos[9];

	public CampoLayoutArquivoCobranca DataVencimento => campos[10];

	public CampoLayoutArquivoCobranca ValorNominal => campos[11];

	public CampoLayoutArquivoCobranca NumeroBanco => campos[12];

	public CampoLayoutArquivoCobranca AgenciaCobradora => campos[13];

	public CampoLayoutArquivoCobranca ControleBeneficiario => campos[14];

	public CampoLayoutArquivoCobranca CodigoMoeda => campos[15];

	public CampoLayoutArquivoCobranca TipoInscricao => campos[16];

	public CampoLayoutArquivoCobranca NumeroInscricao => campos[17];

	public CampoLayoutArquivoCobranca NomePagador => campos[18];

	public CampoLayoutArquivoCobranca Filler4 => campos[19];

	public CampoLayoutArquivoCobranca ValorTarifa => campos[20];

	public CampoLayoutArquivoCobranca MotivosOcorrencia => campos[21];

	public CampoLayoutArquivoCobranca Filler5 => campos[22];

	public SegmentoDetalheTFebraban240Ban756CorrespondenteBancoBrasil(long sequenciaLote, long sequenciaSegmento)
		: base(sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando os campos de SEGMENTO DE DETALHE do layout FEBRABAN240.");
			campos.Clear();
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.3T", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 1, 7, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.3T", "Registro detalhe", "Tipo do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 8, 8, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.3T", "Número sequencial do registro no lote", "Número sequencial do registro no lote", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 9, 13, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.3T", "Código do segmento do registro detalhe", "Código do segmento do registro detalhe", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 14, 14, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.3T", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 15, 15, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.3T", "Código da instrução", "Código da ocorrência de remessa", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 16, 17, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.3T", "Campo exclusivo", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 18, 37, 20, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.3T", "Nosso número", "Identificação do título no banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 41, 57, 17, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3T", "Código da carteira", "Código da carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 59, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3T", "Número do documento", "Número do documento", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 60, 74, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3T", "Data de vencimento", "Data de vencimento no formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 82, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3T", "Valor do título", "Valor do título", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 83, 97, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3T", "Número do banco", "Número do banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 98, 100, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3T", "Código da agência cobradora", "Código da agência cobradora", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 101, 106, 6, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3T", "Controle do beneficiário", "Controle do beneficiário", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 107, 131, 25, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3T", "Código da moeda", "Código da moeda", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 132, 133, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3T", "Tipo de inscrição", "01-CPF, 02-CNPJ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 134, 135, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3T", "Número de inscrição", "Número de inscrição", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 136, 149, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3T", "Nome do pagador", "Nome do pagador", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 150, 189, 40, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3T", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 190, 199, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3T", "Valor tarifa", "Valor das tarifas", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 200, 214, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3T", "Motivos de ocorrência", "Motivos de ocorrência", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 215, 224, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3T", "Campo exclusivo", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 225, 240, 16, 0);
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
