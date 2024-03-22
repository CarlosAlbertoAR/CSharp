using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban021;

public class TraillerRetornoCnab400Ban021 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban021
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoRetorno => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoTipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaSimples => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculaa => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaVinculada => campos[10];

	public CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaVinculada => campos[11];

	public CampoLayoutArquivoCobranca Filler3 => campos[12];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaCaucionada => campos[13];

	public CampoLayoutArquivoCobranca ValorTotalCobrancaCaucionada => campos[14];

	public CampoLayoutArquivoCobranca NumeroAvisoCobrancaCaucionada => campos[15];

	public CampoLayoutArquivoCobranca Filler4 => campos[16];

	public CampoLayoutArquivoCobranca Filler5 => campos[17];

	public CampoLayoutArquivoCobranca Filler6 => campos[18];

	public CampoLayoutArquivoCobranca Filler7 => campos[19];

	public CampoLayoutArquivoCobranca Filler8 => campos[20];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[21];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_ESPIRITO_SANTO}]...");
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
			campoLayoutArquivoCobranca.Preparar("03.9", "Identificação tipo de registro", "Informar 01", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 3, 4, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Código do banco", "Informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de títulos cobrança simples", "Quantidade de títulos de cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Valor total em cobrança simples", "Valor total em cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Número do aviso bancário cobrança simples", "Número do aviso bancário cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 57, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Quantidade de títulos em cobrança vinculada", "Quantidade de títulos em cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 65, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Valor total em cobrança vinculada", "Valor total em cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 79, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Número do aviso em cobrança vinculada", "Número do aviso em cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 80, 87, 8, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Filler3", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 97, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Quantidade de títulos em cobrança caucionada", "Quantidade de títulos em cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 98, 105, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Valor total em cobrança caucionada", "Valor total em cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 119, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.9", "Número do aviso em cobrança caucionada", "Número do aviso em cobrança caucionada", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 120, 127, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.9", "Filler4", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 128, 137, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.9", "Filler5", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 167, 30, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.9", "Filler6", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 168, 177, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.9", "Filler7", "Zeros", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 178, 250, 73, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.9", "Filler8", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 251, 394, 144, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
