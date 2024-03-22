using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban099;

public class TraillerRetornoCnab400Ban099 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban099
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoRetorno => campos[1];

	public CampoLayoutArquivoCobranca IdentificacaoTipoRegistro => campos[2];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobranca => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalCobranca => campos[6];

	public CampoLayoutArquivoCobranca NumeroAvisoBancario => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia02 => campos[9];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia02 => campos[10];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia06 => campos[11];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia06 => campos[12];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrenciaLiquidacao => campos[13];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia09e10 => campos[14];

	public CampoLayoutArquivoCobranca ValorRegistrosocorrencia09e10 => campos[15];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia13 => campos[16];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia13 => campos[17];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia14 => campos[18];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia14 => campos[19];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia12 => campos[20];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia12 => campos[21];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosOcorrencia19 => campos[22];

	public CampoLayoutArquivoCobranca ValorRegistrosOcorrencia19 => campos[23];

	public CampoLayoutArquivoCobranca Filler3 => campos[24];

	public CampoLayoutArquivoCobranca ValorTotalRateiosEfetuados => campos[25];

	public CampoLayoutArquivoCobranca QuantidadeTotalRateiosEfetuados => campos[26];

	public CampoLayoutArquivoCobranca Filler4 => campos[27];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[28];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.COOPERATIVA_CENTRAL_DE_ECONOMIA_E_CREDITO_MUTUO_DAS_UNICRED}]...");
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
			campoLayoutArquivoCobranca.Preparar("04.9", "Código do banco", "Informar 237", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de títulos", "Quantidade de títulos de cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Valor total em cobrança", "Valor total em cobrança", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 14, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Número do aviso bancário", "Número do aviso bancário", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 57, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Quantidade de registros de ocorrência 02", "Quantidade de registros de confirmação de entrada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 62, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Valor dos registros de ocorrência 02", "Valor dos registros de confirmação de entrada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 63, 74, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Valor dos registros de ocorrência 06", "Valor dos registros de liquidação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 75, 86, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Quantidade de registros de ocorrência 06", "Quantidade de registros de liquidação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 87, 91, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Valor dos registros de ocorrência 06", "Valor dos registros de liquidação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 92, 103, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Quantidade de registros de ocorrência 09  e 10", "Quantidade de títulos baixados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 104, 108, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.9", "Valor dos registros de ocorrência 09  e 10", "Valor dos títulos baixados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 109, 120, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.9", "Quantidade de registros de ocorrência 13", "Quantidade de títulos com abatimento cancelado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 121, 125, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.9", "Valor dos registros de ocorrência 13", "Valor dos títulos com abatimento cancelado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 126, 137, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.9", "Quantidade de registros de ocorrência 14", "Quantidade de títulos com vencimento alterado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 138, 142, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.9", "Valor dos registros de ocorrência 14", "Valor dos títulos com vencimento alterado", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 143, 154, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.9", "Quantidade de registros de ocorrência 12", "Quantidade de títulos com abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 155, 159, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("22.9", "Valor dos registros de ocorrência 12", "Valor dos títulos com abatimento concedido", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 160, 171, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("23.9", "Quantidade de registros de ocorrência 19", "Quantidade de títulos com confirmação de instrução de protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 172, 176, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("24.9", "Valor dos registros de ocorrência 19", "Valor dos títulos com confirmação de instrução de protesto", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 177, 188, 10, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("25.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 189, 362, 174, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("26.9", "Valor total dos rateios efetuados", "Valor total dos rateios efetuados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 363, 377, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("27.9", "Quantidade total dos rateios efetuados", "Quantidade total dos rateios efetuados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 378, 385, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("28.9", "Filler", "Brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 386, 394, 9, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("29.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
