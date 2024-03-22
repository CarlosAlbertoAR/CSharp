using System;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Febraban240.Estrutura;

public abstract class SegmentoDetalheY51Febraban240 : SegmentoDetalheOpcionalFebraban240
{
	public SegmentoDetalheY51Febraban240(long sequenciaLote, long sequenciaSegmento)
		: base(EnumIdentificacaoRegistroOpcionalYFebraban.INFORMACOES_DE_NOTAS_FISCAIS.Codigo(), sequenciaLote, sequenciaSegmento)
	{
		try
		{
			Logger.Debug("Criando campos do SEGMENTO Y51 do layout FEBRABAN240...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.3Y", "Número da nota fiscal 1", "Número da nota fiscal referente a um título de cobrança, informado pelo Cedente. Este número é subordinado a uma série e local. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 20, 34, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.3Y", "Valor da nota fiscal 1", "Valor constante da nota fiscal do Cedente referente ao título de cobrança. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 35, 49, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.3Y", "Data de emissão da nota fiscal 1", "Data de emissão constante da nota fiscal do Cedente referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 50, 57, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.3Y", "Número da nota fiscal 2", "Número da nota fiscal referente a um título de cobrança, informado pelo Cedente. Este número é subordinado a uma série e local. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 58, 72, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.3Y", "Valor da nota fiscal 2", "Valor constante da nota fiscal do Cedente referente ao título de cobrança. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 73, 87, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.3Y", "Data de emissão da nota fiscal 2", "Data de emissão constante da nota fiscal do Cedente referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 88, 95, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.3Y", "Número da nota fiscal 3", "Número da nota fiscal referente a um título de cobrança, informado pelo Cedente. Este número é subordinado a uma série e local. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 96, 110, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.3Y", "Valor da nota fiscal 3", "Valor constante da nota fiscal do Cedente referente ao título de cobrança. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 111, 125, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.3Y", "Data de emissão da nota fiscal 3", "Data de emissão constante da nota fiscal do Cedente referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 126, 133, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.3Y", "Número da nota fiscal 4", "Número da nota fiscal referente a um título de cobrança, informado pelo Cedente. Este número é subordinado a uma série e local. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 134, 148, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.3Y", "Valor da nota fiscal 4", "Valor constante da nota fiscal do Cedente referente ao título de cobrança. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 149, 163, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.3Y", "Data de emissão da nota fiscal 4", "Data de emissão constante da nota fiscal do Cedente referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 164, 171, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.3Y", "Número da nota fiscal 5", "Número da nota fiscal referente a um título de cobrança, informado pelo Cedente. Este número é subordinado a uma série e local. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 172, 186, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.3Y", "Valor da nota fiscal 5", "Valor constante da nota fiscal do Cedente referente ao título de cobrança. Informação para repasse ao Sacado por ocasião de pagamento eletrônico. ", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 187, 201, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.3Y", "Data de emissão da nota fiscal 5", "Data de emissão constante da nota fiscal do Cedente referente ao título de cobrança. Utilizar o formato DDMMAAAA", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 202, 209, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.3Y", "Uso exclusivo FEBRABAN", "Texto de observações destinado para uso exclusivo da FEBRABAN. Preencher com brancos.", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "Brancos", 210, 240, 31, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoY51Febraban240(ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
