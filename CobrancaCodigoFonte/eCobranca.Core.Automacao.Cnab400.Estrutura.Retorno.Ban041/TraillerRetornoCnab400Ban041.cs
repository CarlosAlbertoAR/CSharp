using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban041;

public class TraillerRetornoCnab400Ban041 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban041
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => base.Campos[0];

	public CampoLayoutArquivoCobranca Filler1 => base.Campos[1];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCarteira => base.Campos[2];

	public CampoLayoutArquivoCobranca ValorTotalTitulos => base.Campos[3];

	public CampoLayoutArquivoCobranca NumeroSequenciaArquivo => base.Campos[4];

	public CampoLayoutArquivoCobranca Filler2 => base.Campos[5];

	public CampoLayoutArquivoCobranca QuantidadeTitulosRegistrados => base.Campos[6];

	public CampoLayoutArquivoCobranca ValorTotalTitulosRegistrados => base.Campos[7];

	public CampoLayoutArquivoCobranca QuantidadeTitulosLiquidados => base.Campos[8];

	public CampoLayoutArquivoCobranca ValorTotalTitulosLiquidados => base.Campos[9];

	public CampoLayoutArquivoCobranca Filler3 => base.Campos[10];

	public CampoLayoutArquivoCobranca QuantidadeTotalRateiosEfetuados => base.Campos[11];

	public CampoLayoutArquivoCobranca ValorTotalRateiosEfetuados => base.Campos[12];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => base.Campos[13];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_DO_ESTADO_DO_RIO_GRANDE_DO_SUL}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro", "Identificação do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 17, 16, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Quantidade de títulos na carteira", "Quantidade de títulos na carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Valor total de títulos na carteira", "Valor total de títulos na carteira", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Número da sequência do arquivo", "Número da sequência do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 48, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Quantidade de títulos registrados", "Quantidade de títulos registrados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 49, 55, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Valor total títulos registrados", "Valor total títulos registrados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 56, 70, 15, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Quantidade de títulos liquidados", "Quantidade de títulos liquidados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 71, 77, 7, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Valor total títulos liquidados", "Valor total títulos liquidados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 78, 92, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 93, 361, 269, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Quantidade total de títulos rateados", "Quantidade total de títulos rateados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 362, 379, 18, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Valor total dos títulos rateados", "Valor total dos títulos rateados", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 380, 394, 13, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
