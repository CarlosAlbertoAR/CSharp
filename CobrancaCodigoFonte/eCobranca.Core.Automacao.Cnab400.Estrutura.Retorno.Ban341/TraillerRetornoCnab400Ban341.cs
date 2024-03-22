using System;
using System.Collections.Generic;
using System.Diagnostics;
using eCobranca.Core.Automacao.Estrutura;
using eCobranca.Core.Excecao;
using eCobranca.Core.Log;
using eCobranca.Enumerator;
using eCobranca.Util;

namespace eCobranca.Core.Automacao.Cnab400.Estrutura.Retorno.Ban341;

public class TraillerRetornoCnab400Ban341 : TraillerRetornoCnab400, ITraillerRetornoCnab400Ban341
{
	public CampoLayoutArquivoCobranca IdentificacaoRegistro => campos[0];

	public CampoLayoutArquivoCobranca IdentificacaoRetorno => campos[1];

	public CampoLayoutArquivoCobranca TipoServico => campos[2];

	public CampoLayoutArquivoCobranca CodigoBanco => campos[3];

	public CampoLayoutArquivoCobranca Filler1 => campos[4];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaSimples => campos[5];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaSimples => campos[6];

	public CampoLayoutArquivoCobranca AvisoBancarioCobrancaSimples => campos[7];

	public CampoLayoutArquivoCobranca Filler2 => campos[8];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaVinculada => campos[9];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaVinculada => campos[10];

	public CampoLayoutArquivoCobranca AvisoBancarioCobrancaVinculada => campos[11];

	public CampoLayoutArquivoCobranca Filler3 => campos[12];

	public CampoLayoutArquivoCobranca QuantidadeTitulosCobrancaDiretaEscritural => campos[13];

	public CampoLayoutArquivoCobranca ValorTitulosCobrancaDiretaEscritural => campos[14];

	public CampoLayoutArquivoCobranca AvisoBancarioCobrancaDiretaEscritural => campos[15];

	public CampoLayoutArquivoCobranca NumeroSequencialRetorno => campos[16];

	public CampoLayoutArquivoCobranca QuantidadeRegistrosTransacao => campos[17];

	public CampoLayoutArquivoCobranca ValorTitulosInformadosArquivo => campos[18];

	public CampoLayoutArquivoCobranca Filler4 => campos[19];

	public CampoLayoutArquivoCobranca NumeroSequencialRegistro => campos[20];

	protected override void CarregarCampos()
	{
		try
		{
			Logger.Debug($"Criando campos do REGISTRO TRAILLER de retorno CNAB400 do [{EnumCodigoBanco.BANCO_ITAU}]...");
			CampoLayoutArquivoCobranca campoLayoutArquivoCobranca = null;
			if (campos == null)
			{
				campos = new List<CampoLayoutArquivoCobranca>();
			}
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("01.9", "Identificação do registro Detalhe", "Identificação do registro Detalhe do arquivo de remessa CNAB400", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoRegistroCnab400.TRAILLER.Codigo(), "", 1, 1, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("02.9", "Código do retorno", "Indentificação de arquivo retorno", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoOperacao.RETORNO.Codigo(), "", 2, 2, 1, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("03.9", "Código de serviço", "Identificação do tipo de serviço", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumTipoServico.COBRANCA.Codigo(), "", 3, 4, 2, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("04.9", "Código do banco", "Identifiação do banco na compensação", EnumFormatoCampoLayoutArquivoCobranca.NUM, EnumCodigoBanco.BANCO_ITAU.Codigo(), "", 5, 7, 3, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("05.9", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 8, 17, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("06.9", "Quantidade de títulos de cobrança simples", "Quantidade de títulos de cobrança simples", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 18, 25, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("07.9", "Cobrança simples - valor total", "Cobrança simples - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 26, 39, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("08.9", "Cobrança simples - número do aviso", "Cobrança simples - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 40, 47, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("09.9", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 48, 57, 10, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("10.9", "Cobrança vinculada - quantidade de títulos", "Cobrança vinculada - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 58, 65, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("11.9", "Cobrança vinculada - valor total", "Cobrança vinculada - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 66, 79, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("12.9", "Cobrança vinculada - número do aviso", "Cobrança vinculada - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 80, 87, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("13.9", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 88, 177, 90, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("14.9", "Cobrança direta/escritural - quantidade de títulos", "Cobrança direta/escritural - quantidade de títulos", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 178, 185, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("15.9", "Cobrança direta/escritural - valor total", "Cobrança direta/escritural - valor total", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 186, 199, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("16.9", "Cobrança direta/escritural - número do aviso", "Cobrança direta/escritural - número do aviso", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 200, 207, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("17.9", "Controle do arquivo", "Número sequencial do arquivo de retorno", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 208, 212, 5, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("18.9", "Quantidade de detalhes", "Quantidade de registros de transação", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 213, 220, 8, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("19.9", "Valor total informado", "Valor dos títulos informados no arquivo", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 221, 234, 12, 2);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("20.9", "Complemento de registro", "Complemento de registro - Informar BRANCOS", EnumFormatoCampoLayoutArquivoCobranca.ALFA, "", "", 235, 394, 160, 0);
			campos.Add(campoLayoutArquivoCobranca);
			campoLayoutArquivoCobranca = new CampoLayoutArquivoCobranca();
			campoLayoutArquivoCobranca.Preparar("21.9", "Sequencial do registro", "Sequencial do registro", EnumFormatoCampoLayoutArquivoCobranca.NUM, "0", "", 395, 400, 6, 0);
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
