using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban001;

public class TraillerRetornoCnab400Ban001 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban001
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca TipoOperacao => campos[1];

	public CampoLayoutArquivoCobranca Filler1 => campos[2];

	public CampoLayoutArquivoCobranca Filler2 => campos[3];

	public CampoLayoutArquivoCobranca Filler3 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaSimples => campos[7];

	public CampoLayoutArquivoCobranca Filler4 => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaVinculada => campos[10];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaVinculada => campos[11];

	public CampoLayoutArquivoCobranca Filler5 => campos[12];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[13];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaCaucionada => campos[14];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada => campos[15];

	public CampoLayoutArquivoCobranca Filler6 => campos[16];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada => campos[17];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaDescontada => campos[18];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaDescontada => campos[19];

	public CampoLayoutArquivoCobranca Filler7 => campos[20];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVendor => campos[21];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaVendor => campos[22];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaVendor => campos[23];

	public CampoLayoutArquivoCobranca Filler8 => campos[24];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[25];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_BRASIL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "2", "2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "01", "01", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 3, 4, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "001", "001", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Brancos", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Cobrança simples - quantidade de títulos", "Cobrança simples - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Cobrança simples - valor total", "Cobrança simples - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Cobrança simples - número do aviso", "Cobrança simples - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Cobrança simples - brancos", "Cobrança simples - brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 57, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Cobrança vinculada - quantidade de títulos", "Cobrança vinculada - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 65, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Cobrança vinculada - valor total", "Cobrança vinculada - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 79, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Cobrança vinculada - número do aviso", "Cobrança vinculada - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 87, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Cobrança vinculada - brancos", "Cobrança vinculada - brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 97, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Cobrança vinculada - quantidade de títulos", "Cobrança vinculada - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 98, 105, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Cobrança caucionada - valor total", "Cobrança caucionada - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 119, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.9", "Cobrança caucionada - número do aviso", "Cobrança caucionada - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 120, 127, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.9", "Cobrança caucionada - brancos", "Cobrança caucionada - brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 128, 137, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.9", "Cobrança descontada - quantidade de títulos", "Cobrança descontada - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 145, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.9", "Cobrança descontada - valor total", "Cobrança descontada - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 159, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.9", "Cobrança descontada - número do aviso", "Cobrança descontada - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 160, 167, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.9", "Cobrança descontada - brancos", "Cobrança descontada - brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 168, 217, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.9", "Cobrança vendor - quantidade de títulos", "Cobrança vendor - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 218, 225, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.9", "Cobrança vendor - valor total", "Cobrança vendor - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 226, 239, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.9", "Cobrança vendor - número do aviso", "Cobrança vendor - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 240, 247, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.9", "Cobrança vendor - brancos", "Cobrança vendor - brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 248, 394, 147, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
				Launcher.GetInstance().LancarExcecao(ExcecaoECobranca.ArquivoCobranca.FalhaInicializandoSegmentoRemessaCnab400(GetType().Name, ex), new StackTrace().GetFrame(1).GetMethod());
			}
		}
	}
}
