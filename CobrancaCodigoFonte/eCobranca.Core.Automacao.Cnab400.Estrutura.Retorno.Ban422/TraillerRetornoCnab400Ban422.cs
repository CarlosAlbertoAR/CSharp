using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban422;

public class TraillerRetornoCnab400Ban422 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban422
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoArquivoRetorno => campos[1];

	public CampoLayoutArquivoCobranca CodigoIdentificacaoServico => campos[2];

	public CampoLayoutArquivoCobranca CodigoIdentificacaoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaSimples => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada => campos[9];

	public CampoLayoutArquivoCobranca ValorTotalTitulosCobrancaVinculada => campos[10];

	public CampoLayoutArquivoCobranca NumeroAvisoBancarioCobrancaVinculada => campos[11];

	public CampoLayoutArquivoCobranca Filler3 => campos[12];

	public CampoLayoutArquivoCobranca NumeroSequencialGeracaoArquivo => campos[13];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[14];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_SAFRA}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro", "Identificação do registro  do arquivo de retorno CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Identificação do arquivo retorno", "Identificação do arquivo retorno", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Código do serviço", "Código do serviço", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 3, 4, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Código do banco", "Código de compensação do banco", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Filler1", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de títulos da cobrança simples", "Quantidade de títulos de cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Valor total títulos de cobrança simples", "Valor total títulos de cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Número aviso bancário cobrança simples", "Número aviso bancário cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Filler2", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 97, 50, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Quantidade de títulos cobrança vinculada", "Quantidade de títulos da cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 98, 105, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Valor total dos títulos de cobrança vinculada", "Valor total dos títulos de cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 106, 119, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Número aviso bancário cobrança vinculada", "Número aviso bancário cobrança vinculada", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 120, 127, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Filler3", "Informar brancos", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 128, 391, 123, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Número sequencial do arquivo", "Número sequencial do arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 392, 394, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Número sequencial do registro", "Número sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
