using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban033;

public class TraillerRetornoCnab400Ban033 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban033
{
	public CampoLayoutArquivoCobranca CodigoRegistro => campos[0];

	public CampoLayoutArquivoCobranca CodigoRetorno => campos[1];

	public CampoLayoutArquivoCobranca CodigoServico => campos[2];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaSimples => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca Filler3 => campos[9];

	public CampoLayoutArquivoCobranca Filler4 => campos[10];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[11];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaCaucionada => campos[12];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada => campos[13];

	public CampoLayoutArquivoCobranca Filler5 => campos[14];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDescontada => campos[15];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaDescontada => campos[16];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaDescontada => campos[17];

	public CampoLayoutArquivoCobranca Filler6 => campos[18];

	public CampoLayoutArquivoCobranca NumeroVersao => campos[19];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[20];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SANTANDER}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Identificação do retorno", "Informar 2", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Identificação tipo de registro", "Informar 01", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 3, 4, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Código do banco", "Informar 033", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de títulos", "Quantidade de títulos de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Valor total em cobrança", "Valor total em cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Número do aviso bancário", "Número do aviso bancário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 57, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Filler", "Informar zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 87, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 97, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Quantidade títulos de cobrança caucionada", "Quantidade de títulos de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 98, 105, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Valor dos títulos de cobrança caucionada", "Valor dos títulos de cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 119, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Número do aviso da cobrança caucionada", "Número do aviso da cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 120, 127, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 128, 137, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.9", "Quantidade títulos de cobrança descontada", "Quantidade de títulos de cobrança descontada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 145, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.9", "Valor títulos de cobrança descontada", "Valor dos títulos de cobrança descontada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 146, 159, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.9", "Número do aviso da cobrança descontada", "Número do aviso da cobrança descontada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 160, 167, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.9", "Filler", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 168, 391, 224, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.9", "Número da versão", "Número da versão", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.9", "Número sequencial do registro no arquivo", "Número sequencial do registro no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
